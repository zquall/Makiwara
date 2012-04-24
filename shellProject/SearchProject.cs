using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class SearchProject : XtraForm
    {
        public SearchProject()
        {
            InitializeComponent();
        }

        #region Search Service Calls

        private void Search(string query)
        {
            var request = new ProjectRequest {SearchProjectQuery = query};
            ShowSearchResults(new ProjectFactory().SearchProject(request).ProjectList);
        }

        private void ShowSearchResults(List<ProjectDto> searchResults)
        {
            grdProjectControl.DataSource = searchResults;
            GridConfiguration();
        }

        #endregion

        #region Screen Configuration

        private void GridConfiguration()
        {
            #region Hide Columns
            viewProjects.Columns["Id"].Visible = false;
            viewProjects.Columns["Code"].Visible = true;
            viewProjects.Columns["BudgetRequestId"].Visible = false;
            viewProjects.Columns["StateId"].Visible = false;
            viewProjects.Columns["CustumerId"].Visible = false;
            viewProjects.Columns["EmployeeId"].Visible = false;
            viewProjects.Columns["Name"].Visible = true;
            viewProjects.Columns["ManagementApproval"].Visible = false;
            viewProjects.Columns["CxcApproval"].Visible = false;
            viewProjects.Columns["CreateDate"].Visible = false;
            viewProjects.Columns["ContingenciesRate"].Visible = false;
            viewProjects.Columns["GuaranteeRate"].Visible = false;
            viewProjects.Columns["TotalUtilityRate"].Visible = false;
            viewProjects.Columns["DiscountRate"].Visible = false;
            viewProjects.Columns["SalesTax"].Visible = false;
            viewProjects.Columns["OthersRate"].Visible = false;
            viewProjects.Columns["Comments"].Visible = false;
            viewProjects.Columns["Tasks"].Visible = false;
            viewProjects.Columns["BudgetRequest"].Visible = false;
            viewProjects.Columns["ProjectInforms"].Visible = false;
            viewProjects.Columns["TotalMeters"].Visible = false;
            #endregion

            #region Set Caption To Visible Columns
                viewProjects.Columns["Code"].Caption = @"Código";
                viewProjects.Columns["Name"].Caption = @"Nombre";
                viewProjects.Columns["Customer"].Caption = @"Cliente";
                viewProjects.Columns["State"].Caption = @"Estado";
            #endregion

            #region Set With To Visible Columns
                viewProjects.Columns["Code"].Width = 70;
                viewProjects.Columns["Name"].Width = 125;
                viewProjects.Columns["Customer"].Width = 125;
            #endregion

            #region Set ReadOnly To Visible Columns
                viewProjects.Columns["Code"].OptionsColumn.ReadOnly = true;
                viewProjects.Columns["Name"].OptionsColumn.ReadOnly = true;
                viewProjects.Columns["Customer"].OptionsColumn.ReadOnly = true;
                viewProjects.Columns["State"].OptionsColumn.ReadOnly = true;
            #endregion
        }

        #endregion

        #region UI Events

        private void SearchProjectShown(object sender, EventArgs e)
        {
            Search("A");
        }

        private void TxtSearchQueryEditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            if (tmpTextEdit != null) Search(tmpTextEdit.Text);
        }

        // Move the focus to the grid when press Down on the search
        private void TxtSearchQueryKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && viewProjects.FocusedRowHandle >= 0)
            {
                viewProjects.Focus();
            }
        }

        // Move the focus to the search when the user press Up and is in the first row of the grid
        private void ViewProjectsKeyDown(object sender, KeyEventArgs e)
        {
            if (viewProjects.FocusedRowHandle == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    txtSearchQuery.Focus();
                }
            }
        }

        private void CmdOkClick(object sender, EventArgs e)
        {
            var rowObject = viewProjects.GetFocusedRow() as ProjectDto;
            if (rowObject == null) return;
            // Check if the user select a valid object
            if (rowObject.Id <= 0 && rowObject.Code == null) return;
            Tag = new ProjectFactory().GetProject(new ProjectRequest { ProjectId = rowObject.Id, Project = rowObject }).Project;
            DialogResult = DialogResult.OK;
        }

        private void CmdCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}