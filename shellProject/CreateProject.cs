using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ReplicantFacility.Factory;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.Request;

namespace shellProject
{
    public partial class CreateProject : DevExpress.XtraEditors.XtraForm
    {
        #region Private Properties

        private ProjectDto _project = new ProjectDto();

        private BudgetRequestDto _budgetRequest = new BudgetRequestDto();

        #endregion

        public CreateProject()
        {
            InitializeComponent();
        }

        #region Validations 

        private bool ReviewExistData()
        {
            var x = true;

            if (txtQuoteNumber.Text == "" || txtCode.Text == "" || txtProject.Text == "" || txtCustumer.Text == "" || txtSalesConsultant.Text == "")
                x = false;

            return x;
        }

        #endregion

        #region Calcs

        private void CalcSubtotal()
        {
            decimal subtotal = 0;

            if (_project.Tasks != null)
            {
                foreach(var tmpTask in _project.Tasks)
                {
                    foreach(var tmpResource in tmpTask.Resources)
                    {
                        subtotal += tmpResource.TotalCost;
                    }
                }
            }
            spinSubTotal.Value = subtotal;
        }

        private void CalcSubtotalB()
        {
            if (spinSubTotal.Value > 0)
            {
                spinSubTotalB.Value = spinSubTotal.Value + (spinSubTotal.Value * spinContingenciesRate.Value / 100)
                                                         + (spinSubTotal.Value*spinGuaranteeRate.Value/100)
                                                         + (spinSubTotal.Value*spinOthersRate.Value/100);
            }
        }

        private void CalcSubtotalC()
        {
            if (spinSubTotal.Value > 0)
            {
                spinSubTotalC.Value = spinSubTotalB.Value + (spinSubTotalB.Value * spinTotalUtilityRate.Value / 100);
            }
        }

        private void CalcDiscount()
        {
            if (spinSubTotalC.Value > 0)
            {
                spinDiscountAmount.Value = spinSubTotalC.Value * (spinDiscountRate.Value/100);
            }
        }

        private void CalcTotal()
        {
            if (spinSubTotalC.Value > 0)
            {
                spinTotal.Value = spinSubTotalC.Value - spinDiscountAmount.Value;
            }
        }

        private void Calcs()
        {
            CalcSubtotal();
            CalcSubtotalB();
            CalcSubtotalC();
            CalcDiscount();
            CalcTotal();
        }

        #endregion 

        #region Load Process

        private static string GetNextCode()
        {
            return new ProjectFactory().NextCode();
        }

        /// <summary>
        /// Este método se encargara de buscar un Presupuesto de Reparación y obtener los datos del mismo para tener la info
        /// disponible para cargarla en el Proyecto.
        /// </summary>
        /// 
        private void SearchBudgetRequest()
        {
            var budgetRequest = new BudgetRequestFinder();
            if (budgetRequest.ShowDialog() == DialogResult.OK)
            {
                _budgetRequest = budgetRequest.Tag as BudgetRequestDto;
                LoadBudgetRequesToProject();
            }
        }

        private void LoadBudgetRequesToProject()
        {
            txtQuoteNumber.Text = _budgetRequest.Id.ToString();
            txtCode.Text = GetNextCode();
            txtProject.Text = _budgetRequest.ProjectName;
            txtCustumer.Text = _budgetRequest.Customer.Name;
            txtSalesConsultant.Text = _budgetRequest.Employee.Person.Name;
            dtCreateDate.DateTime = DateTime.Now;
        }

        private void LoadProject()
        {
            dtCreateDate.DateTime = DateTime.Today;

            if (_project.ProjectState == null)
            {
                var request = new ProjectStateRequest { ProjectStateId = 1 };
                _project.ProjectState = new ProjectStateFactory().GetProjectState(request).ProjectState;
                txtState.Text = _project.ProjectState.Name;
            }
        }

        /// <summary>
        /// Carga los datos que se envian a la interfaz grafica
        /// </summary>
        /// <param name="p">Proyecto con los datos a cambiar</param>
        private void LoadProject(ProjectDto p)
        {
            _project = p;

            _budgetRequest.Id = _project.BudgetRequestId;
            _budgetRequest.CustomerId = _project.CustumerId;


            //Screen One
            txtQuoteNumber.Text = p.BudgetRequestId.ToString();
            dtCreateDate.DateTime = p.CreateDate;
            txtCode.Text = p.Code;
            txtProject.Text = p.Name;
            txtCustumer.Text = p.Customer.Name;
            txtSalesConsultant.Text = p.BudgetRequest != null ? p.BudgetRequest.Employee.Person.Name : @"Verificando";
            chkManagementApproval.Checked = p.ManagementApproval;
            chkCxcApproval.Checked = p.CxcApproval;
            txtState.Text = p.ProjectState.Name;

            //Screen Two
            spinContingenciesRate.Value = (decimal)p.ContingenciesRate;
            spinGuaranteeRate.Value = (decimal)p.GuaranteeRate;
            spinTotalUtilityRate.Value = (decimal)p.TotalUtilityRate;
            spinDiscountRate.Value = (decimal)p.DiscountRate;
            spinSubTotalB.Value = (decimal)p.SalesTax;
            spinOthersRate.Value = (decimal)p.OthersRate;
            Calcs();

            //Screen Three
            memoComments.Text = p.Comments;
        }

        #endregion

        #region Get Data

        private void CaptureProject()
        {
            _project.Code = txtCode.Text;
            _project.BudgetRequestId = _budgetRequest.Id;
            _project.CustumerId = _budgetRequest.CustomerId;
            _project.EmployeeId = _budgetRequest.CustomerId;
            _project.Name = txtProject.Text;
            _project.ManagementApproval = chkManagementApproval.Checked;
            _project.CxcApproval = chkCxcApproval.Checked;
            _project.CreateDate = dtCreateDate.DateTime;
            _project.ContingenciesRate = (double)spinContingenciesRate.Value;
            _project.GuaranteeRate = (double)spinGuaranteeRate.Value;
            _project.TotalUtilityRate = (double)spinTotalUtilityRate.Value;
            _project.DiscountRate = (double)spinDiscountRate.Value;
            _project.SalesTax = (double)spinSubTotalB.Value;
            _project.OthersRate = (double)spinOthersRate.Value;
            _project.Comments = memoComments.Text;

            if (_project.StateId == 0)
                _project.StateId = 1;

            if (_project.Customer == null)
                _project.Customer = _budgetRequest.Customer;

            if (_project.Tasks == null)
                _project.Tasks = new List<TaskDto>();
        }

        #endregion

        #region UI Events

        private void TxtQuoteNumberPropertiesButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    SearchBudgetRequest();
                    break;
            }
        }

        private void CreateProjectLoad(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                LoadProject(Tag as ProjectDto);
            }
            else
            {
                LoadProject();
            }
        }

        private void CmdCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CmdSaveClick(object sender, EventArgs e)
        {
            if (ReviewExistData())
            {
                CaptureProject();
                Tag = _project;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Faltan datos por llenar en el formulario", @"Advertencia", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }

        //********************************** spin events **********************************
        private void SpinContingenciesRateEditValueChanged(object sender, EventArgs e)
        {
            Calcs();
        }

        private void SpinGuaranteeRateEditValueChanged(object sender, EventArgs e)
        {
            Calcs();
        }

        private void SpinOthersRateEditValueChanged(object sender, EventArgs e)
        {
            Calcs();
        }

        private void SpinTotalUtilityRateEditValueChanged(object sender, EventArgs e)
        {
            Calcs();
        }

        private void SpinDiscountRateEditValueChanged(object sender, EventArgs e)
        {
            Calcs();
        }

        #endregion
    }
}