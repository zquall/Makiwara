using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using System.Collections.Generic;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace shellCommon.Employee
{
    public partial class PostFinder : DevExpress.XtraEditors.XtraForm
    {
        public PostFinder()
        {
            InitializeComponent();
        }

        #region Search Service Calls

        private void ShowSearchResults(List<PostDto> searchResults)
        {
            grdControl.DataSource = searchResults;
        }

        private void Search(string query)
        {
            var request = new PostRequest { SearchPostQuery = query };
            ShowSearchResults(new PostFactory().SearchPost(request).PostList);
        }

        #endregion

        #region UI Events

        private void PostFinderShown(object sender, EventArgs e)
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

        private void GrdControlKeyDown(object sender, KeyEventArgs e)
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
            var rowObject = grdControlView.GetFocusedRow() as PostDto;
            if (rowObject != null)
            {
                // Check if the user select a valid object
                if (rowObject.Id > 0)
                {
                    Tag = new PostFactory().GetPost(new PostRequest { PostId = rowObject.Id, Post = rowObject }).Post;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void CmdCloseClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}