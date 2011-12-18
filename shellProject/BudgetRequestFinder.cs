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
    public partial class BudgetRequestFinder : DevExpress.XtraEditors.XtraForm
    {
        public BudgetRequestFinder()
        {
            InitializeComponent();
        }

        #region UI Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Finder_Shown(object sender, EventArgs e)
        {
            Search("");
        }

        private void txtSearchQuery_EditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            Search(tmpTextEdit.Text);
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
            if (grdCustomerView.FocusedRowHandle == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    txtSearchQuery.Focus();
                }
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var focusedRow = grdCustomerView.GetFocusedRow() as BudgetRequestData;
            if (focusedRow != null)
            {
                // Check if the user select a valid object
                if (focusedRow.Id > 0)
                {
                    var request = new BudgetRequestRequest();
                    request.BudgetResquestId = focusedRow.Id;

                    // This customer must be returned with contacts
                    this.Tag = new BudgetRequestFactory().getBudgetRequest(request).BudgetRequest;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    // Check if is a new object                   
                }
            }
        }
        #endregion 
               
        #region Search Service Calls

        private void Search(string query)
        {
            var request = new BudgetRequestRequest();
            request.ResquestQuery = query;
            ShowSearchResults(new BudgetRequestFactory().searchBudgetRequest(request).BudgetRequestList);
        }

        private void ShowSearchResults(List<BudgetRequestData> searchResults)
        {           
            grdControl.DataSource = searchResults;
        }

        #endregion
            
    }
}