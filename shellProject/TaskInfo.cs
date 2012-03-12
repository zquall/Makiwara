using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using Infragistics.Win.UltraWinSchedule;
using DevExpress.XtraGrid.Views.Base;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class TaskInfo : DevExpress.XtraEditors.XtraForm
    {
        #region Private Properties

            //This task will be edited
            private Task _task;

            //This task is a backup of the edited task, for the cancel button option
            private Task _backupTask = new Task();

            //Dependencies list of the task
            List<TaskDependency> _dependenciesCollection = new List<TaskDependency>();

            //Project in use
            public ProjectDto Project { get; set; }

            

        #endregion

        public TaskInfo()
        {
            InitializeComponent();
        }

        #region Loads

        /// <summary>
        /// Este método almacena en un objeto aquellas propiedades que pueden ser cambiadas para restablecerlas si
        /// el usuario decide presionar el boton de cancelar
        /// </summary>
        /// <param name="t1">Source</param>
        /// <param name="t2">Destination</param>
        private static void CopyTask(Task t1, Task t2)
        {
            if (!t2.IsSummary)
            {
                t2.Name = t1.Name;
                t2.Duration = t1.Duration;
                t2.PercentComplete = t1.PercentComplete;
                t2.StartDateTime = t1.StartDateTime;
                t2.EndDateTime = t1.EndDateTime;
                t2.Notes = t1.Notes;
            }
        }

        private void LoadDependencies()
        {
            _dependenciesCollection.Clear();

            foreach (var t in _task.Dependencies)
            {
                _dependenciesCollection.Add(t);
            }

            grdPredecessors.DataSource = _dependenciesCollection;
            ConfigureDependenciesGrid();
        }

        private void LoadResourceRoot()
        {
            var tmpResources = new List<ResourceDto>();

            foreach(var tmpTask in _task.Tasks)
            {
                if (tmpTask.Tag != null)
                {
                    tmpResources.AddRange(tmpTask.Tag as List<ResourceDto>);
                }
            }

            grdResources.DataSource = new BindingList<ResourceDto>(tmpResources);
            ConfigureResourcesGrid();
        }

        private void LoadResources()
        {
            var tmpResources = _task.Tag as List<ResourceDto>;
            if (tmpResources != null)
            {
                grdResources.DataSource = new BindingList<ResourceDto>(tmpResources);
                ConfigureResourcesGrid();
            }
        }

        private void LoadResourceTypes()
        {
            var request = new ResourceTypeRequest();
            repResourceTypes.Items.Clear();
            foreach (ResourceTypeDto r in new ResourceTypeFactory().SearchResourceType(request).ResourceTypeList)
            {
                repResourceTypes.Items.Add(r);
            }
        }

        private void LoadMeasures()
        {
            var request = new MeasureRequest();
            repMeasures.Items.Clear();
            foreach (MeasureDto r in new MeasureFactory().SearchMeasure(request).MeasureList)
            {
                repMeasures.Items.Add(r);
            }
        }

        private void LoadTask()
        {
            _task = Tag as Task;

            if (_task != null)
            {
                txtTaskName.Text = _task.Name;
                drtDuration.Duration = _task.Duration;
                spinCompleteRate.Value = (decimal)_task.PercentComplete;
                dtStartDate.DateTime = _task.StartDateTime;
                dtEndDate.DateTime = _task.EndDateTimeResolved;
                memoEditNotes.Text = _task.Notes;
            }
            LoadDependencies();

            if (IsRoot())
                LoadResourceRoot();
            else
                LoadResources();

            LoadResourceTypes();
            LoadMeasures();
        }

        private void LoadItem(ItemDto item)
        {
            if (item != null)
            {
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Code"], item.Code);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Name"], item.Name);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Cost"], item.Cost);
            }
        }

        #endregion

        #region Captures

        private void CaptureResources()
        {
            var temp = new List<ResourceDto>();
            //foreach (var data in _resourcesCollection)
            foreach (var data in (BindingList<ResourceDto>)grdResources.DataSource)
            {
                temp.Add(data);
            }

            _task.Tag = temp;
            //_task.Tag = (BindingList<ResourceDto>)grdResources.DataSource;
        }

        /// <summary>
        /// Este método esta de mas ya que todas las capturas se realizan en caliente
        /// </summary>
        private void CaptureTask()
        {
            _task.Name = txtTaskName.Text;
            _task.Notes = memoEditNotes.Text;

            if (_task.Tasks.Count > 0) return;

            _task.Duration = drtDuration.Duration;
            _task.PercentComplete = (float)spinCompleteRate.Value;
            _task.StartDateTime = dtStartDate.DateTime;
            _task.EndDateTime = dtEndDate.DateTime;

            //Se asignan los recursos a la tarea
            CaptureResources();
        }

        #endregion

        #region UI Configuration

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
            //viewResources.Columns["Measure"].Width = 50;
            //viewResources.Columns["ResourceType"].Width = 70;
            //viewResources.Columns["Code"].Width = 70;
            viewResources.Columns["Name"].Width = 150;
            //viewResources.Columns["Amount"].Width = 70;
            //viewResources.Columns["Cost"].Width = 75;
            //viewResources.Columns["TotalCost"].Width = 50;
            //viewResources.Columns["RealUsed"].Width = 50;
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

            #region Set read only columns
            viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
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

            #region set repositories
            viewResources.Columns["ResourceType"].ColumnEdit = repResourceTypes;
            #endregion
        }

        private void ConfigureResourcesGrid(string rtype)
        {
            viewResources.Columns["Measure"].ColumnEdit = repMeasures;
            viewResources.Columns["Code"].ColumnEdit = null;

            if ((rtype.Equals("PRODUCTO")) || (rtype.Equals("ALQUILER")) || (rtype.Equals("PLANILLA")))
            {
                #region Set read only columns
                viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
                viewResources.Columns["TaskId"].OptionsColumn.ReadOnly = true;
                viewResources.Columns["Measure"].OptionsColumn.ReadOnly = false;
                viewResources.Columns["ResourceType"].OptionsColumn.ReadOnly = false;
                viewResources.Columns["Code"].OptionsColumn.ReadOnly = false;
                viewResources.Columns["Name"].OptionsColumn.ReadOnly = true;
                viewResources.Columns["Amount"].OptionsColumn.ReadOnly = false;
                viewResources.Columns["Cost"].OptionsColumn.ReadOnly = true;
                viewResources.Columns["TotalCost"].OptionsColumn.ReadOnly = true;
                viewResources.Columns["RealUsed"].OptionsColumn.ReadOnly = true;
                #endregion

                viewResources.Columns["Code"].ColumnEdit = repResourceCode;
            }
            else
                if (rtype.Equals(""))
                {
                    #region Set read only columns
                    viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
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
                }
                else
                {
                    #region Set read only columns
                    viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
                    viewResources.Columns["TaskId"].OptionsColumn.ReadOnly = true;
                    viewResources.Columns["Measure"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["ResourceType"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["Code"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["Name"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["Amount"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["Cost"].OptionsColumn.ReadOnly = false;
                    viewResources.Columns["TotalCost"].OptionsColumn.ReadOnly = true;
                    viewResources.Columns["RealUsed"].OptionsColumn.ReadOnly = false;
                    #endregion
                }
        }

        private void ConfigureDependenciesGrid()
        {
            viewDependencies.Columns["Predecessor"].Visible = true;
            viewDependencies.Columns["DependencyType"].Visible = true;
            viewDependencies.Columns["Tag"].Visible = false;

            viewDependencies.Columns["Predecessor"].Caption = @"Nombre de la Tarea";
            viewDependencies.Columns["DependencyType"].Caption = @"Tipo de Dependencia";
            viewDependencies.Columns["Tag"].Caption = @"Info";

            viewDependencies.Columns["Predecessor"].Width = 300;
            viewDependencies.Columns["DependencyType"].Width = 136;
            viewDependencies.Columns["Tag"].Width = 0;
            
            viewDependencies.Columns["Predecessor"].OptionsColumn.ReadOnly = true;
            viewDependencies.Columns["DependencyType"].OptionsColumn.ReadOnly = true;
            viewDependencies.Columns["Tag"].OptionsColumn.ReadOnly = true;
        }

        private bool IsRoot()
        {
            if ((_task.IsRoot) && (_task.Tasks.Count >0))
                return true;
            return false;
        }

        private void ConfigureTaskInfoForm()
        { 
            var readOnly = IsRoot();

            txtTaskName.Properties.ReadOnly = false;
            memoEditNotes.Properties.ReadOnly = false;

            drtDuration.Properties.ReadOnly = readOnly;
            spinCompleteRate.Properties.ReadOnly = readOnly;
            dtStartDate.Properties.ReadOnly = readOnly;
            dtEndDate.Properties.ReadOnly = readOnly;

            if (readOnly) viewResources.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }

        #endregion

        #region UI Events

        private void TaskInfoLoad(object sender, EventArgs e)
        {
            LoadTask();
            ConfigureTaskInfoForm();

            //Se crea un backup de la tarea para ser restaurada en caso de que se presione el boton cancelar
            CopyTask(_task, _backupTask);
        }

        private void ViewResourcesInitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as ColumnView;

            if (view != null)
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["ProjectId"], Project.Id);
                view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], 0);
                view.SetRowCellValue(e.RowHandle, view.Columns["Cost"], 0);
                view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], 0);
                view.SetRowCellValue(e.RowHandle, view.Columns["RealUsed"], 0);

                //Si se presiona el boton de agregar fila del Navegador del grid se genera un null en el EditingValue
                if (view.EditingValue != null)
                    ConfigureResourcesGrid(view.EditingValue.ToString());
                else
                    ConfigureResourcesGrid("");
            }
        }

        private void ViewResourcesFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var view = sender as ColumnView;

            if (view != null && view.EditingValue != null)
                ConfigureResourcesGrid(view.EditingValue.ToString());
            else
                ConfigureResourcesGrid("");
        }

        private void ViewResourcesCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                var rd = view.GetRow(e.RowHandle) as ResourceDto;

                if ((e.Column.FieldName == "Cost") || (e.Column.FieldName == "Amount"))
                {
                    if (rd != null)
                        view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], rd.Cost * (decimal)rd.Amount);
                }

                if (e.Column.FieldName == "ResourceType")
                {
                    if (rd != null) ConfigureResourcesGrid(rd.ResourceType.Name);
                }
            }
        }

        private void RepResourceCodeButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tmpResource = viewResources.GetFocusedRow() as ResourceDto;
            if (tmpResource != null && tmpResource.ResourceType.Name == "PRODUCTO")
            {
                var itemFinder = new ItemFinder();
                if(itemFinder.ShowDialog() == DialogResult.OK)
                {
                    var itemDto = itemFinder.Tag as ItemDto;
                    LoadItem(itemDto);
                }
            }
        }

        private void CmdCancelClick(object sender, EventArgs e)
        {
            //Se devuelve al estado original en el que fue abierta la tarea
            CopyTask(_backupTask, _task);

            Close();
            DialogResult = DialogResult.Cancel;
        }

        private void CmdOkClick(object sender, EventArgs e)
        {
            CaptureTask();
            DialogResult = DialogResult.OK;
        }

        private void DrtDurationTextChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.Duration = drtDuration.Duration;
                LoadTask();
            }
        }
 
        private void DtStartDateEditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.StartDateTime = dtStartDate.DateTime;
                LoadTask();
            }
        }

        private void DtEndDateEditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.EndDateTime = dtEndDate.DateTime.Add(TimeSpan.Parse("00:00:01"));
                LoadTask();
            }
        }

        private void SpinCompleteRateEditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.PercentComplete = (float)spinCompleteRate.Value;
                LoadTask();
            }
        }

        private void SpinCompleteRateEditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.PercentComplete = (float)spinCompleteRate.Value;
                LoadTask();
            }
        }

        private void TxtTaskNameEditValueChanged(object sender, EventArgs e)
        {
            _task.Name = txtTaskName.Text;
            LoadTask();
        }

        private void CmdDeleteClick(object sender, EventArgs e)
        {
            viewResources.DeleteRow(viewResources.FocusedRowHandle);
        }

        #endregion
    }
}