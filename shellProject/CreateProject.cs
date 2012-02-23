using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ReplicantFacility.Factory;
using ReplicantRepository.DataTransferObjects;

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

            if (txtQuoteNumber.Text == "" || spinCode.Value == 0 || txtProject.Text == "" || txtCustumer.Text == "" || txtSalesConsultant.Text == "")
                x = false;

            return x;
        }

        #endregion

        #region Load Process

        private static int GetNextCode()
        {
            return new ProjectFactory().NextCode();
        }

        private void LoadBudgetRequesToProject()
        {
            txtQuoteNumber.Text = _budgetRequest.Id.ToString();
            spinCode.Value = GetNextCode();
            txtProject.Text = _budgetRequest.ProjectName;
            txtCustumer.Text = _budgetRequest.Customer.Name;
            txtSalesConsultant.Text = _budgetRequest.Employee.Person.Name;
            dtCreateDate.DateTime = DateTime.Now;
        }

        private static decimal CalcSubtotal()
        {
            const decimal subtotal = 0;

            return subtotal;
        }

        private static decimal CalcDiscount()
        {
            const decimal discount = 0;

            return discount;
        }

        private static decimal CalcOther()
        {
            const decimal other = 0;

            return other;
        }

        /// <summary>
        /// Carga los datos que se envian a la interfaz grafica
        /// </summary>
        /// <param name="p">Proyecto con los datos a cambiar</param>
        private void LoadProject(ProjectDto p)
        {
            //Se carga el projecto a la variable local que almacena el projecto
            _project = p;

            _budgetRequest.Id = _project.BudgetRequestId;
            _budgetRequest.CustomerId = _project.CustumerId;


            //Screen One
            txtQuoteNumber.Text = p.BudgetRequestId.ToString();
            dtCreateDate.DateTime = p.CreateDate;
            spinCode.Value = p.Id;
            txtProject.Text = p.Name;
            txtCustumer.Text = p.Customer.Name;
            txtSalesConsultant.Text = p.BudgetRequest.Employee.Person.Name;
            chkManagementApproval.Checked = p.ManagementApproval;
            chkCxcApproval.Checked = p.CxcApproval;

            //Screen Two
            spinContingenciesRate.Value = (decimal)p.ContingenciesRate;
            spinGuaranteeRate.Value = (decimal)p.GuaranteeRate;
            spinTotalUtilityRate.Value = (decimal)p.TotalUtilityRate;
            spinSubTotal.Value = CalcSubtotal();
            spinDiscountRate.Value = (decimal)p.DiscountRate;
            spinDiscountAmount.Value = CalcDiscount();
            spinSalesTax.Value = (decimal)p.SalesTax;
            spinOthersRate.Value = (decimal)p.OthersRate;
            spinOtherAmount.Value = CalcOther();

            //Screen Three
            memoComments.Text = p.Comments;
        }

        #endregion

        #region UI Events

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

        private void txtQuoteNumber_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    SearchBudgetRequest();
                    break;
                default:
                    break;
            }
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                LoadProject(Tag as ProjectDto);
            }
            else
            {
                dtCreateDate.DateTime = System.DateTime.Today;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ReviewExistData())
            {
                _project = CaptureProject();

                if (_project.Customer == null)
                    _project.Customer = _budgetRequest.Customer;

                Tag = _project;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Faltan datos por llenar en el formulario", @"Advertencia", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Save Process

        private ProjectDto CaptureProject()
        {
            var p = new ProjectDto();
            var tasks = new List<TaskDto>();

            p.Id = (int)spinCode.Value;
            p.BudgetRequestId = _budgetRequest.Id;
            p.CustumerId = _budgetRequest.CustomerId;
            p.EmployeeId = _budgetRequest.CustomerId;
            p.Name = txtProject.Text;
            p.ManagementApproval = chkManagementApproval.Checked;
            p.CxcApproval = chkCxcApproval.Checked;
            p.CreateDate = dtCreateDate.DateTime;
            p.ContingenciesRate = (double)spinContingenciesRate.Value;
            p.GuaranteeRate = (double)spinGuaranteeRate.Value;
            p.TotalUtilityRate = (double)spinTotalUtilityRate.Value;
            p.DiscountRate = (double)spinDiscountRate.Value;
            p.SalesTax = (double)spinSalesTax.Value;
            p.OthersRate = (double)spinOthersRate.Value;
            p.Comments = memoComments.Text;
            p.Tasks = tasks;

            return p;
        }

        #endregion
    }
}