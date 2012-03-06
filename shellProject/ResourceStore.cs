using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class ResourceStore : DevExpress.XtraEditors.XtraForm
    {
        private ProjectDto _project = new ProjectDto();

        public ResourceStore()
        {
            InitializeComponent();
        }

        private void ConfigureResourcesGrid()
        {
            #region Set visible columns
            viewResources.Columns["Id"].Visible = false;
            viewResources.Columns["TaskId"].Visible = false;
            viewResources.Columns["Measure"].Visible = true;
            viewResources.Columns["ResourceType"].Visible = true;
            viewResources.Columns["Code"].Visible = true;
            viewResources.Columns["Name"].Visible = true;
            viewResources.Columns["Amount"].Visible = true;
            viewResources.Columns["Cost"].Visible = true;
            viewResources.Columns["TotalCost"].Visible = true;
            viewResources.Columns["RealUsed"].Visible = true;
            viewResources.Columns["Task"].Visible = false;
            viewResources.Columns["MeasureId"].Visible = false;
            viewResources.Columns["ResourceTypeId"].Visible = false;
            #endregion

            #region set caption columns
            viewResources.Columns["Id"].Caption = @"Id";
            //viewResources.Columns["ProjectId"].Caption = "Proyecto";
            viewResources.Columns["TaskId"].Caption = @"Tarea";
            viewResources.Columns["Measure"].Caption = @"Medida";
            viewResources.Columns["ResourceType"].Caption = @"Tipo";
            viewResources.Columns["Code"].Caption = @"Código";
            viewResources.Columns["Name"].Caption = @"Nombre";
            viewResources.Columns["Amount"].Caption = @"Cantidad";
            viewResources.Columns["Cost"].Caption = @"Costo";
            viewResources.Columns["TotalCost"].Caption = @"Total";
            viewResources.Columns["RealUsed"].Caption = @"Usado";
            #endregion

            #region set width columns
            viewResources.Columns["Measure"].Width = 50;
            viewResources.Columns["ResourceType"].Width = 60;
            viewResources.Columns["Code"].Width = 70;
            viewResources.Columns["Name"].Width = 250;
            viewResources.Columns["Amount"].Width = 60;
            viewResources.Columns["Cost"].Width = 60;
            viewResources.Columns["TotalCost"].Width = 70;
            viewResources.Columns["RealUsed"].Width = 50;
            #endregion

            #region set visible index
            viewResources.Columns["ResourceType"].VisibleIndex = 0;
            viewResources.Columns["Code"].VisibleIndex = 1;
            viewResources.Columns["Name"].VisibleIndex = 2;
            viewResources.Columns["Amount"].VisibleIndex = 3;
            viewResources.Columns["Measure"].VisibleIndex = 4;
            viewResources.Columns["Cost"].VisibleIndex = 5;
            viewResources.Columns["TotalCost"].VisibleIndex = 6;
            viewResources.Columns["RealUsed"].VisibleIndex = 7;
            #endregion

            #region set mask to the numeric columns
            viewResources.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            viewResources.Columns["Amount"].DisplayFormat.FormatString = "{0:N2}";
            viewResources.Columns["Cost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            viewResources.Columns["Cost"].DisplayFormat.FormatString = "{0:N2}";
            viewResources.Columns["TotalCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            viewResources.Columns["TotalCost"].DisplayFormat.FormatString = "{0:N2}";
            viewResources.Columns["RealUsed"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            viewResources.Columns["RealUsed"].DisplayFormat.FormatString = "{0:N2}";
            #endregion

            #region Set read only columns
            viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
            //viewResources.Columns["ProjectId"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["TaskId"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Measure"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["ResourceType"].OptionsColumn.ReadOnly = false;
            viewResources.Columns["Code"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Name"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Amount"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Cost"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["TotalCost"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["RealUsed"].OptionsColumn.ReadOnly = true;
            #endregion

            #region Set columns summaries

            viewResources.Columns["Cost"].SummaryItem.DisplayFormat = @"{0:N2}";
            viewResources.Columns["Cost"].SummaryItem.FieldName = "Cost";
            viewResources.Columns["Cost"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            viewResources.Columns["TotalCost"].SummaryItem.DisplayFormat = @"{0:N2}";
            viewResources.Columns["TotalCost"].SummaryItem.FieldName = "TotalCost";
            viewResources.Columns["TotalCost"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            #endregion

        }

        private void LoadTaskOnCombo()
        {
            foreach (var task in _project.Tasks)
            {
                cmbTask.Properties.Items.Add(task, true);
            }
        }

#region UI Events

        private void ResourceStoreLoad(object sender, EventArgs e)
        {
            _project = Tag as ProjectDto;
            LoadTaskOnCombo();
        }

        private void CmbTaskEditValueChanged(object sender, EventArgs e)
        {
            var resources = new List<ResourceDto>();

            foreach(CheckedListBoxItem  tmpTask in cmbTask.Properties.GetItems())
            {
                if (tmpTask.CheckState == CheckState.Checked)
                {
                    var t = tmpTask.Value as TaskDto;
                    if (t != null) resources.AddRange(t.Resources);
                }
            }

            grdResources.DataSource = resources;
            ConfigureResourcesGrid();
        }

        private void CmdOkClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

#endregion 

    }
}