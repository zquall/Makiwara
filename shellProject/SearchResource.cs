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

namespace shellProject
{
    public partial class SearchResource : DevExpress.XtraEditors.XtraForm
    {
        //Tipo del recurso que se esta buscando
        public string Rtype { get; set; }

        public SearchResource()
        {
            InitializeComponent();
        }

        #region Search Resource

        private void FindResourceSource(string query)
        {
            var request = new ResourceSourceRequest();
            request.SearchResourceSourceQuery = query;
            request.SearchResourceSourceType = Rtype;
            ShowSearchResults(new ResourceSourceFactory().searchResourceSource(request).ResourceSourceList);
        }

        private void ShowSearchResults(List<ResourceSourceData> searchResults)
        {
            grdResourceControl.DataSource = searchResults;
            gridConfiguration();
        }

        #endregion

        #region Screen Configuration

        private void gridConfiguration()
        {
            #region set visible columns
            viewResourceSource.Columns["Code"].Visible = true;
            viewResourceSource.Columns["Name"].Visible = true;
            viewResourceSource.Columns["Balance"].Visible = true;
            viewResourceSource.Columns["RType"].Visible = false;
            viewResourceSource.Columns["Cost"].Visible = true;
            viewResourceSource.Columns["Taxed"].Visible = false;
            #endregion

            #region Set Caption To Visible Columns
            viewResourceSource.Columns["Code"].Caption = "Código";
            viewResourceSource.Columns["Name"].Caption = "Nombre";
            viewResourceSource.Columns["Balance"].Caption = "Saldo";
            viewResourceSource.Columns["RType"].Caption = "Tipo";
            viewResourceSource.Columns["Cost"].Caption = "Costo";
            viewResourceSource.Columns["Taxed"].Caption = "Exento";
            #endregion

            #region Set With To Visible Columns
            #endregion

            #region Set ReadOnly To Visible Columns
            viewResourceSource.Columns["Code"].OptionsColumn.ReadOnly = true;
            viewResourceSource.Columns["Name"].OptionsColumn.ReadOnly = true;
            viewResourceSource.Columns["Balance"].OptionsColumn.ReadOnly = true;
            viewResourceSource.Columns["RType"].OptionsColumn.ReadOnly = true;
            viewResourceSource.Columns["Cost"].OptionsColumn.ReadOnly = true;
            viewResourceSource.Columns["Taxed"].OptionsColumn.ReadOnly = true;
            #endregion
        }

        #endregion

        #region UI Events

        private void SearchResource_Shown(object sender, EventArgs e)
        {
            FindResourceSource("a");
        }

        private void txtFind_EditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            FindResourceSource(tmpTextEdit.Text);
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Tag = viewResourceSource.GetFocusedRow() as ResourceSourceData;

            this.DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}