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

namespace shellCommon.Customer
{
    public partial class CustomerFinder : DevExpress.XtraEditors.XtraForm
    {
        public CustomerFinder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void CustomerFinder_Shown(object sender, EventArgs e)
        {
            SearchCustomer("a");
        }

        #region Search Customers Service Calls
        private void SearchCustomer(string query)
        {
            var request = new CustomerRequest();
            request.SearchCustomerQuery = query;
            ShowSearchResults(new CustomerFactory().searchCustomer(request).CustomerList);
        }

        private void ShowSearchResults(List<CustomerData> searchResults)
        {
            //if (searchResults.Count > 0)
            //{
                grdCustomerControl.DataSource = searchResults;
            //}
        }
        #endregion

        private void txtSearchQuery_EditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            SearchCustomer(tmpTextEdit.Text);
        }

    }
}