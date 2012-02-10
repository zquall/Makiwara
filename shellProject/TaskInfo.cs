﻿using System;
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

            //Resource list of the task
            BindingList<ResourceDto> _resourcesCollection = new BindingList<ResourceDto>();

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
        private void copyTask(Task t1, Task t2)
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

        private void loadDependencies()
        {
            _dependenciesCollection.Clear();

            foreach (TaskDependency t in _task.Dependencies)
            {
                _dependenciesCollection.Add(t);
            }

            grdPredecessors.DataSource = _dependenciesCollection;
            configureDependenciesGrid();
        }

        //Revisar para quitar la primer conversion
        private void loadResources()
        {
            _resourcesCollection.Clear();

            List<ResourceDto> l = new List<ResourceDto>();

            l = _task.Tag as List<ResourceDto>;

            if (_task.Tag != null)
            {
                foreach (ResourceDto rd in l /*_task.Tag as List<ResourceData>*/)
                {
                    _resourcesCollection.Add(rd);
                }
            }

            grdResources.DataSource = _resourcesCollection;
            configureResourcesGrid();
        }

        private void loadResourceTypes()
        {
            var request = new ResourceTypeRequest();
            repResourceTypes.Items.Clear();
            foreach (ResourceTypeDto r in new ResourceTypeFactory().searchResourceType(request).ResourceTypeList)
            {
                repResourceTypes.Items.Add(r);
            }
        }

        private void loadMeasures()
        {
            var request = new MeasureRequest();
            repMeasures.Items.Clear();
            foreach (MeasureDto r in new MeasureFactory().searchMeasure(request).MeasureList)
            {
                repMeasures.Items.Add(r);
            }
        }

        private void loadTask()
        {
            _task = this.Tag as Task;
            
            txtTaskName.Text = _task.Name;
            drtDuration.Duration = _task.Duration;
            spinCompleteRate.Value = (decimal)_task.PercentComplete;
            dtStartDate.DateTime = _task.StartDateTime;
            dtEndDate.DateTime = _task.EndDateTimeResolved;
            memoEditNotes.Text = _task.Notes;

            //Se cargan las tareas predecesoras en el grid correspondiente
            loadDependencies();

            //Se cargan los recursos en el grid correspondiente, estos recursos vienen en el Tag de la tarea
            loadResources();

            //Se cargan los tipos de recursos posibles y las medidas disponibles
            loadResourceTypes();
            loadMeasures();
        }

        #endregion

        #region Captures
        //No existe método de captura de Dependencias ya que estas son solo de lectura y pueden cambiarse unicamente
        //desde el ProjectManager

        private void captureResources()
        {
            List<ResourceDto> temp = new List<ResourceDto>();
            foreach (ResourceDto data in _resourcesCollection)
            {
                temp.Add(data);
            }

            _task.Tag = temp;
        }

        /// <summary>
        /// Este método esta de mas ya que todas las capturas se realizan en caliente
        /// </summary>
        private void captureTask()
        {
            _task.Name = txtTaskName.Text;
            _task.Notes = memoEditNotes.Text;

            if (!_task.IsRoot)
            {
                _task.Duration = drtDuration.Duration;
                _task.PercentComplete = (float)spinCompleteRate.Value;
                _task.StartDateTime = dtStartDate.DateTime;
                _task.EndDateTime = dtEndDate.DateTime;

                //Se asignan los recursos a la tarea
                captureResources();
            }
        }

        #endregion

        #region UI Configuration

        private void configureResourcesGrid()
        {
            #region Set visible columns
            viewResources.Columns["Id"].Visible = false;
            //viewResources.Columns["ProjectId"].Visible = false;
            viewResources.Columns["TaskId"].Visible = false;
            viewResources.Columns["Measure"].Visible = true;
            viewResources.Columns["ResourceType"].Visible = true;
            viewResources.Columns["Code"].Visible = true;
            viewResources.Columns["Name"].Visible = true;
            viewResources.Columns["Amount"].Visible = true;
            viewResources.Columns["Cost"].Visible = true;
            viewResources.Columns["TotalCost"].Visible = true;
            viewResources.Columns["RealUsed"].Visible = true;
            #endregion

            #region set caption columns
            viewResources.Columns["Id"].Caption = "Id";
            //viewResources.Columns["ProjectId"].Caption = "Proyecto";
            viewResources.Columns["TaskId"].Caption = "Tarea";
            viewResources.Columns["Measure"].Caption = "Medida";
            viewResources.Columns["ResourceType"].Caption = "Tipo";
            viewResources.Columns["Code"].Caption = "Código";
            viewResources.Columns["Name"].Caption = "Nombre";
            viewResources.Columns["Amount"].Caption = "Cantidad";
            viewResources.Columns["Cost"].Caption = "Costo";
            viewResources.Columns["TotalCost"].Caption = "Total";
            viewResources.Columns["RealUsed"].Caption = "Usado";
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
            //Todo se apaga hasta saber que tipo de recurso se va a utilizar
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

            #region set repositories
            viewResources.Columns["ResourceType"].ColumnEdit = repResourceTypes;
            #endregion
        }

        private void configureResourcesGrid(string rtype)
        {
            viewResources.Columns["Measure"].ColumnEdit = repMeasures;
            viewResources.Columns["Code"].ColumnEdit = null;

            if ((rtype.Equals("PRODUCTO")) || (rtype.Equals("ALQUILER")) || (rtype.Equals("PLANILLA")))
            {
                #region Set read only columns
                viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
                //viewResources.Columns["ProjectId"].OptionsColumn.ReadOnly = true;
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
                }
                else
                {
                    #region Set read only columns
                    viewResources.Columns["Id"].OptionsColumn.ReadOnly = true;
                    //viewResources.Columns["ProjectId"].OptionsColumn.ReadOnly = true;
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

        private void configureDependenciesGrid()
        {
            viewDependencies.Columns["Predecessor"].Visible = true;
            viewDependencies.Columns["DependencyType"].Visible = true;
            viewDependencies.Columns["Tag"].Visible = false;

            viewDependencies.Columns["Predecessor"].Caption = "Nombre de la Tarea";
            viewDependencies.Columns["DependencyType"].Caption = "Tipo de Dependencia";
            viewDependencies.Columns["Tag"].Caption = "Info";

            viewDependencies.Columns["Predecessor"].Width = 300;
            viewDependencies.Columns["DependencyType"].Width = 136;
            viewDependencies.Columns["Tag"].Width = 0;
            
            viewDependencies.Columns["Predecessor"].OptionsColumn.ReadOnly = true;
            viewDependencies.Columns["DependencyType"].OptionsColumn.ReadOnly = true;
            viewDependencies.Columns["Tag"].OptionsColumn.ReadOnly = true;
        }

        private bool isRoot()
        {
            if (_task.IsRoot)
                return true;
            else
                return false;
        }

        private void configureTaskInfoForm()
        { 
            bool readOnly = isRoot();

            txtTaskName.Properties.ReadOnly = false;
            memoEditNotes.Properties.ReadOnly = false;

            drtDuration.Properties.ReadOnly = readOnly;
            spinCompleteRate.Properties.ReadOnly = readOnly;
            dtStartDate.Properties.ReadOnly = readOnly;
            dtEndDate.Properties.ReadOnly = readOnly;
        }

        #endregion
        
        #region UI Events

        private void TaskInfo_Load(object sender, EventArgs e)
        {
            loadTask();
            configureTaskInfoForm();

            //Se crea un backup de la tarea para ser restaurada en caso de que se presione el boton cancelar
            copyTask(_task, _backupTask);
        }


        private void viewResources_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            ColumnView view = sender as ColumnView;

            view.SetRowCellValue(e.RowHandle, view.Columns["ProjectId"], Project.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["TaskId"], _task.RowNumber);
            view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["Cost"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["RealUsed"], 0);

            //Si se presiona el boton de agregar fila del Navegador del grid se genera un null en el EditingValue
            if (view.EditingValue != null)
                configureResourcesGrid(view.EditingValue.ToString());
            else
                configureResourcesGrid("");
        }

        private void viewResources_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ColumnView view = sender as ColumnView;

            if (view.EditingValue != null)
                configureResourcesGrid(view.EditingValue.ToString());
            else
                configureResourcesGrid("");
        }

        private void viewResources_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            ResourceDto rd = view.GetRow(e.RowHandle) as ResourceDto;

            if ((e.Column.FieldName == "Cost") || (e.Column.FieldName == "Amount"))
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["TotalCost"], rd.Cost * (decimal)rd.Amount);
            }

            if (e.Column.FieldName == "ResourceType")
            {
                configureResourcesGrid(rd.ResourceType.Name);
            }
        }

        private void loadResourceSource(ResourceSourceData resourceSource)
        {
            if (resourceSource != null)
            {
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Code"], resourceSource.Code);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Name"], resourceSource.Name);
                viewResources.SetRowCellValue(viewResources.FocusedRowHandle, viewResources.Columns["Cost"], resourceSource.Cost);
            }
        }

        private void repResourceCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SearchResource searchResource = new SearchResource();
            ResourceSourceData rsd = new ResourceSourceData();

            ResourceDto rtd = viewResources.GetFocusedRow() as ResourceDto;
            searchResource.Rtype = rtd.ResourceType.Name;

            if (searchResource.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rsd = searchResource.Tag as ResourceSourceData;
                loadResourceSource(rsd);
            }
        }


        #region controls
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //Se devuelve al estado original en el que fue abierta la tarea
            copyTask(_backupTask, _task);

            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            captureTask();
            //this.Tag = _task;

            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void drtDuration_TextChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.Duration = drtDuration.Duration;
                loadTask();
            }
        }
 
        private void dtStartDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.StartDateTime = dtStartDate.DateTime;
                loadTask();
            }
        }

        private void dtEndDate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.EndDateTime = dtEndDate.DateTime.Add(TimeSpan.Parse("00:00:01"));
                loadTask();
            }
        }

        private void spinCompleteRate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.PercentComplete = (float)spinCompleteRate.Value;
                loadTask();
            }
        }

        private void spinCompleteRate_EditValueChanged(object sender, EventArgs e)
        {
            if (!_task.IsSummary)
            {
                _task.PercentComplete = (float)spinCompleteRate.Value;
                loadTask();
            }
        }

        private void txtTaskName_EditValueChanged(object sender, EventArgs e)
        {
            _task.Name = txtTaskName.Text;
            loadTask();
        }

        #endregion

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            viewResources.DeleteRow(viewResources.FocusedRowHandle);
        }

        

        #endregion

        
    }
}