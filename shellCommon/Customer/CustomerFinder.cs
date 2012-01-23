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
using ReplicantRepository.DataTransferObjects;

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

        // Move the focus to the grid when press Down on the search
        private void txtSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && grdCustomerView.FocusedRowHandle >= 0)
            {                
                grdCustomerView.Focus();
            }
        }

        // Move the focus to the search when the user press Up and is in the first row of the grid
        private void grdCustomerView_KeyDown(object sender, KeyEventArgs e)
        {
            if(grdCustomerView.FocusedRowHandle == 0){
                if (e.KeyCode == Keys.Up )
                {
                    txtSearchQuery.Focus();
                }
            }
            
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            var focusedRow = grdCustomerView.GetFocusedRow() as CustomerData;
            if (focusedRow != null) {
                // Check if the user select a customer
                if (focusedRow.Id > -1)
                {
                    var request = new CustomerRequest();
                    request.CustomerId = focusedRow.Id;
                    // Needed for Interceptor
                    request.Customer = new CustomerDto() { Name =  focusedRow.Name};

                    Tag = new CustomerFactory().getCustomer(request).Customer;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    // Check if is a new customer                   
                }
            }
        }
    }
}