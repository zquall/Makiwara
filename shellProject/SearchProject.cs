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
        ProjectDto _project = new ProjectDto();

        public ProjectDto ProjectSelected
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
            #endregion

            #region Set Caption To Visible Columns
                viewProjects.Columns["Code"].Caption = @"Código";
                viewProjects.Columns["Name"].Caption = @"Nombre";
                viewProjects.Columns["Customer"].Caption = @"Cliente";
                viewProjects.Columns["ProjectState"].Caption = @"Estado";
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
                viewProjects.Columns["ProjectState"].OptionsColumn.ReadOnly = true;
            #endregion
        }

        #endregion

        #region UI Events

        private void TxtFindEditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            if (tmpTextEdit != null) FindProject(tmpTextEdit.Text);
        }

        private void CmdOkClick(object sender, EventArgs e)
        {
            _project = viewProjects.GetFocusedRow() as ProjectDto;

            if (_project != null) Tag = new ProjectDto { Id = _project.Id, Name = _project.Name};

            DialogResult = DialogResult.OK;
        }

        private void CmdCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SearchProjectShown(object sender, EventArgs e)
        {
            FindProject("a");
        }

        #endregion
    }
}