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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class SearchProject : DevExpress.XtraEditors.XtraForm
    {
        ProjectData _project = new ProjectData();

        public ProjectData projectSelected
        {
            get { return _project; }
        }

        public SearchProject()
        {
            InitializeComponent();
        }

        #region Search Project

        private void FindProject(string query)
        {
            var request = new ProjectRequest();
            request.SearchProjectQuery = query;
            ShowSearchResults(new ProjectFactory().searchProject(request).ProjectList);
        }

        private void ShowSearchResults(List<ProjectData> searchResults)
        {
            grdProjectControl.DataSource = searchResults;
            gridConfiguration();
        }

        private void SearchProject_Shown(object sender, EventArgs e)
        {
            FindProject("a");
        }

        #endregion

        #region Screen Configuration

        private void gridConfiguration()
        {
            #region Hide Columns
                viewProjects.Columns["Id"].Visible = true;
                viewProjects.Columns["BudgetRequestId"].Visible = false;
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
                //viewProjects.Columns["taskList"].Visible = false;
            #endregion

            #region Set Caption To Visible Columns
                viewProjects.Columns["Id"].Caption = "Código";
                viewProjects.Columns["Name"].Caption = "Nombre";
                viewProjects.Columns["CustumerName"].Caption = "Cliente";
            #endregion

            #region Set With To Visible Columns
                viewProjects.Columns["Id"].Width = 50;
                viewProjects.Columns["Name"].Width = 125;
                viewProjects.Columns["CustumerName"].Width = 125;
            #endregion

            #region Set ReadOnly To Visible Columns
                viewProjects.Columns["Id"].OptionsColumn.ReadOnly = true;
                viewProjects.Columns["Name"].OptionsColumn.ReadOnly = true;
                viewProjects.Columns["CustumerName"].OptionsColumn.ReadOnly = true;
            #endregion
        }

        #endregion

        #region UI Events

        private void txtFind_EditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            FindProject(tmpTextEdit.Text);
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            _project = viewProjects.GetFocusedRow() as ProjectData;

            this.DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}