using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantRepository.Response;
using ReplicantFacility.Factory;
using shellCommon.Customer;

namespace shellProject
{
    public partial class BudgetRequestManager : DevExpress.XtraEditors.XtraForm
    {
        public BudgetRequestManager()
        {
            InitializeComponent();
        }

        private void RequestBugetCell_Load(object sender, EventArgs e)
        {
            loadNewRequestBudgetManager();
        }

        private void loadNewRequestBudgetManager()
        {
            loadRequestBudgetManager(new BudgetRequestFactory().getNewBudgetRequest());
        }

        private void loadRequestBudgetManager(BudgetRequestResponse budgetRequestResponse)
        {
            lblEmployeeName.Text = budgetRequestResponse.EmployeeName;
            edtDate.EditValue = budgetRequestResponse.DateModified;
            loadCustomer(budgetRequestResponse.Customer);
        }

        private void loadCustomer(CustomerData customer)
        {
            btnCustomerName.Text = customer.Name;
            lblAddress.Text = customer.Address;
        }

        private void btnCustomerName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tmpCustomerName = sender as DevExpress.XtraEditors.ButtonEdit;
            var searchCustomer = new CustomerFinder().ShowDialog();
        }

    }
}