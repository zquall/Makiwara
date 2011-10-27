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
            SearchCustomer("");
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
            grdCustomerControl.DataSource = searchResults;
        }
        #endregion

        private void txtSearchQuery_EditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            SearchCustomer(tmpTextEdit.Text);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dialogResult = new CustomerManager().ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                // El usuario ha creado un cliente nuevo
                // hay que devolverlo hasta el manager principal

            }
            else
            {
                this.Visible = true;
            }
        }

        private void txtSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && grdCustomerView.FocusedRowHandle >= 0)
            {                
                grdCustomerView.Focus();
            }
        }

        private void grdCustomerView_KeyDown(object sender, KeyEventArgs e)
        {
            if(grdCustomerView.FocusedRowHandle == 0){
                if (e.KeyCode == Keys.Up )
                {
                    txtSearchQuery.Focus();
                }
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var focusedRow = grdCustomerView.GetFocusedRow();
            if (focusedRow == null) { }
        }


    }
}