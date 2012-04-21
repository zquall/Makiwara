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
using shellCommon.Employee;
using shellCommon.Item;

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

            public TimeSpan TaskDurationWorkingTimePerDay { get; set; }

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
        }

        private void LoadResources()
        {
            var tmpResources = _task.Tag as List<ResourceDto>;
            if (tmpResources != null)
            {
                grdResources.DataSource = new BindingList<ResourceDto>(tmpResources);
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
            repMeasures.Tag = new MeasureFactory().SearchMeasure(request).MeasureList;
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

        private void LoadRentalItem(RentalItemDto rentalItem)
        {
            if (rentalItem != null)
            {
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Code"], rentalItem.Code);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Name"], rentalItem.Name);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Cost"], rentalItem.Cost);
            }
        }

        private void LoadEmployee(EmployeeDto employee)
        {
            if (employee != null)
            {
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Code"], employee.Code);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Name"], employee.Person.Name + employee.Person.LastName);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Cost"], employee.SalaryByHour);
            }
        }

        #endregion

        #region Captures

        private void CaptureResources()
        {
            var temp = new List<ResourceDto>();
            foreach (var data in (BindingList<ResourceDto>)grdResources.DataSource)
            {
                temp.Add(data);
            }

            _task.Tag = temp;
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

        private bool IsRoot()
        {
            if ((_task.IsRoot) && (_task.Tasks.Count > 0))
                return true;
            return false;
        }

        private void ClearRow()
        {
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["RealUsed"], 0);
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["TotalCost"], 0);
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Cost"], 0);
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Measure"], new MeasureDto());
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Amount"], 0);
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Name"], "");
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Code"], "");
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

        private void ReadOnlyDefaultResources()
        {
            viewResources.Columns["Code"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Name"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["Amount"].OptionsColumn.ReadOnly = false;
            viewResources.Columns["Cost"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["TotalCost"].OptionsColumn.ReadOnly = true;
            viewResources.Columns["RealUsed"].OptionsColumn.ReadOnly = true;
        }

        private void AddMeasuresToRepMeasures(string measureType)
        {
            var measureDtos = repMeasures.Tag as List<MeasureDto>;
            repMeasures.Items.Clear();
            if (measureDtos != null)
                switch (measureType)
                {
                    case "E":
                        foreach (var r in measureDtos)
                            if (r.Symbol.Equals("h")) repMeasures.Items.Add(r);
                        break;
                    default:
                        foreach (var r in measureDtos)
                            repMeasures.Items.Add(r);
                        break;
                }
        }

        private bool CheckRepeatItem(ResourceDto resource)
        {
            var count = 0;

            if (viewResources.DataSource != null)
                foreach (var tmpResource in (IEnumerable<ResourceDto>)viewResources.DataSource)
                {
                    if ((resource.Code == tmpResource.Code) && (resource.ResourceType.Id == tmpResource.ResourceType.Id))
                        count++;
                }

            return count > 1;
        }

        private void ConfigureResourceEmployee()
        {
            ReadOnlyDefaultResources();
            viewResources.Columns["Amount"].OptionsColumn.ReadOnly = true;
            viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Amount"], TaskDurationWorkingTimePerDay.Hours * _task.Duration.Days);
            AddMeasuresToRepMeasures("E");
        }

        private void ConfigureResourceItem()
        {
            ReadOnlyDefaultResources();
            AddMeasuresToRepMeasures("I");
        }

        private void ConfigureResourceRent()
        {
            ReadOnlyDefaultResources();
            AddMeasuresToRepMeasures("R");
        }

        private void ConfigureResourcesGrid(string rtype)
        {
            switch(rtype)
            {
                case "PLANILLA":
                    ConfigureResourceEmployee();
                    break;
                case "PRODUCTO":
                    ConfigureResourceItem();
                    break;
                case "ALQUILERES":
                    ConfigureResourceRent();
                    break;
            }
        }

        #endregion

        #region UI Events

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
                ConfigureResourcesGrid(view.EditingValue != null ? view.EditingValue.ToString() : "");
            }
        }

        private void ViewResourcesFocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                var rd = view.GetRow(e.FocusedRowHandle) as ResourceDto;
                view.Columns["ResourceType"].OptionsColumn.ReadOnly = false;
                if (rd != null)
                {
                    if (e.FocusedRowHandle >= 0)
                    {
                        view.Columns["ResourceType"].OptionsColumn.ReadOnly = true;
                        ConfigureResourcesGrid(rd.ResourceType.Name);
                    }
                    else
                    {
                        ClearRow();
                        ConfigureResourcesGrid(rd.ResourceType.Name);
                    }

                }
            }
        }

        private void ViewResourcesCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                var rd = view.GetRow(e.RowHandle) as ResourceDto;

                switch (e.Column.FieldName)
                {
                    case "ResourceType":
                        if (rd != null) ConfigureResourcesGrid(rd.ResourceType.Name);
                        break;
                    case "Cost":
                        if (rd != null)
                            view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], rd.Cost * (decimal)rd.Amount);
                        break;

                    case "Amount":
                        if (rd != null)
                            view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], rd.Cost * (decimal)rd.Amount);
                        break;
                }
            }
        }

        private void ViewResourcesValidateRow(object sender, ValidateRowEventArgs e)
        {
            var tmpResource = e.Row as ResourceDto;
            
            if (CheckRepeatItem(tmpResource))
            {
                e.ErrorText = @"El item seleccionado ya a sido utilizado en esta tarea. Cambie la cantidad en lugar de agregarlo nuevamente";
                e.Valid = false;
            }
        }

        private void GrdResourcesKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                viewResources.DeleteRow(viewResources.FocusedRowHandle);
            }
        }

        private void RepResourceCodeButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tmpResource = viewResources.GetFocusedRow() as ResourceDto;
            if (tmpResource != null && tmpResource.ResourceType.Name == "PRODUCTO")
            {
                var itemFinder = new ItemFinder();
                if (itemFinder.ShowDialog() == DialogResult.OK)
                {
                    var itemDto = itemFinder.Tag as ItemDto;
                    LoadItem(itemDto);
                }
            }

            if (tmpResource != null && tmpResource.ResourceType.Name == "ALQUILERES")
            {
                var employeeFinder = new RentalItemFinder();
                if (employeeFinder.ShowDialog() == DialogResult.OK)
                {
                    var rentalItemDto = employeeFinder.Tag as RentalItemDto;
                    LoadRentalItem(rentalItemDto);
                }
            }

            if (tmpResource != null && tmpResource.ResourceType.Name == "PLANILLA")
            {
                var employeeFinder = new EmployeeFinder();
                if (employeeFinder.ShowDialog() == DialogResult.OK)
                {
                    var employeeDto = employeeFinder.Tag as EmployeeDto;
                    LoadEmployee(employeeDto);
                }
            }
        }

        //*****************************************************************************************************************************

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

        //*****************************************************************************************************************************

        private void TaskInfoLoad(object sender, EventArgs e)
        {
            LoadTask();
            ConfigureTaskInfoForm();

            //Se crea un backup de la tarea para ser restaurada en caso de que se presione el boton cancelar
            CopyTask(_task, _backupTask);
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

        #endregion
    }
}