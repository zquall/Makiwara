using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
using System.Linq;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class CreateProject : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Variable encargada de almacenar los datos del projecto
        /// </summary>
        private ProjectData _project = new ProjectData();
        private BudgetRequestData _budgetRequest = new BudgetRequestData();

        public CreateProject()
        {
            InitializeComponent();
        }

        #region Validations 

        private bool reviewExistData()
        {
            bool x = true;

            if (txtQuoteNumber.Text == "" || spinCode.Value == 0 || txtProject.Text == "" || txtCustumer.Text == "" || txtSalesConsultant.Text == "")
                x = false;

            ////if (txtSubtotal.Text == "" || txtDiscountAmount.Text == "" || textOtherAmount.Text == "" || txtTotal.Text == "")
            ////    x = false;

            return x;
        }

        #endregion

        #region Load Process

        private int getNextCode()
        {
            return new ProjectFactory().nextCode();
        }

        private void loadBudgetRequesToProject()
        {
            txtQuoteNumber.Text = _budgetRequest.Id.ToString();
            spinCode.Value = getNextCode();
            txtProject.Text = "";
            txtCustumer.Text = _budgetRequest.Customer.Name;
            txtSalesConsultant.Text = _budgetRequest.Employee.Person.Name;
            dtCreateDate.DateTime = System.DateTime.Now;
        }

        #endregion

        #region UI Events

        /// <summary>
        /// Este método se encargara de buscar un Presupuesto de Reparación y obtener los datos del mismo para tener la info
        /// disponible para cargarla en el Proyecto.
        /// </summary>
        /// 
        private void searchBudgetRequest()
        {
            _budgetRequest.Id = 1;

            CustomerDto customer = new CustomerDto();
            customer.Id = 1;
            customer.Name = "Renteco S.A.";
            customer.Address = "Barrio Cuba";
            _budgetRequest.Customer = customer;

            _budgetRequest.Employee.Person.Name = "Allan Badilla";
            _budgetRequest.DateModified = DateTime.Today;
            
            loadBudgetRequesToProject();
        }

        private void txtQuoteNumber_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    searchBudgetRequest();
                    break;
                default:
                    break;
            }
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            dtCreateDate.DateTime = System.DateTime.Today;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (reviewExistData())
            {
                _project = captureProject();
                saveProject();
                MessageBox.Show("Los Datos han sido guardados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Faltan datos por llenar en el formulario", "Advertencia", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Save Process

        private ProjectData captureProject()
        {
            ProjectData p = new ProjectData();
            List<TaskData> tasks = new List<TaskData>();

            p.Id = (int)spinCode.Value;
            p.BudgetRequestId = (int)_budgetRequest.Id;
            p.CustumerId = _budgetRequest.Customer.Id;
            p.EmployeeId = _budgetRequest.Customer.Id;
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
            p.taskList = tasks;

            return p;
        }

        private void saveProject()
        {
            var request = new ProjectRequest();
            request.Project = _project;
            new ProjectFactory().saveProject(request);
        }

        #endregion
    }
}