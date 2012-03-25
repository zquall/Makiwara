using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace shellCommon.Employee
{
    public partial class EmployeeFinder : XtraForm
    {
        public EmployeeFinder()
        {
            InitializeComponent();
        }

        #region Search Service Calls

        private void Search(string query)
        {
            var request = new EmployeeRequest { SearchEmployeeQuery = query };
            ShowSearchResults(new EmployeeFactory().SearchEmployee(request).EmployeeList);
        }

        private void ShowSearchResults(List<EmployeeDto> searchResults)
        {
            grdControl.DataSource = searchResults;
        }

        #endregion

        #region UI Events

        private void EmployeeFinderShown(object sender, EventArgs e)
        {
            Search("");
        }

        private void TxtSearchQueryEditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            if (tmpTextEdit != null) Search(tmpTextEdit.Text);
        }

        private void TxtSearchQueryKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && grdControlView.FocusedRowHandle >= 0)
            {
                grdControlView.Focus();
            }
        }

        private void GrdControlViewKeyDown(object sender, KeyEventArgs e)
        {
            if (grdControlView.FocusedRowHandle == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    txtSearchQuery.Focus();
                }
            }
        }

        private void CmdOkClick(object sender, EventArgs e)
        {
            var rowObject = grdControlView.GetFocusedRow() as EmployeeDto;
            if (rowObject != null)
            {
                // Check if the user select a valid object
                if (rowObject.Id > 0 || rowObject.Code != null)
                {
                    Tag = new EmployeeFactory().GetEmployee(new EmployeeRequest { EmployeeId = rowObject.Id, Employee = rowObject }).Employee;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void CmdCancelarClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}