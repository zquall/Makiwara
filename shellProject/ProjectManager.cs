﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using Infragistics.Win.UltraWinSchedule;
using System.Linq;
using ReplicantRepository.DataTransferObjects;

namespace shellProject
{
    public partial class ProjectManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades privadas de la clase

        /// <summary>
        /// Lista que contiene las tareas seleccionadas por un usuario
        /// </summary>
        private List<Task> _selectedTask = new List<Task>();

        /// <summary>
        /// Variable que contiene el proyecto que se esta trabajando
        /// </summary>
        private ProjectDto _project = new ProjectDto();

        #endregion

        public ProjectManager()
        {
            InitializeComponent();
        }

        #region Object-mapping methods

        private void Mapper(Task source, TaskDto destination)
        {
            destination.ProjectId = _project.Id;
            destination.Name = source.Name;
            destination.Duration = source.Duration.ToString();
            destination.PercentComplete = source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.DeadLine = source.Deadline;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
            destination.RowNumber = source.RowNumber;
            destination.TaskLevel = source.Level;

            #region Properties that are not necessary
            destination.IsRoot = source.IsRoot;
            destination.IsSumary = source.IsSummary;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DurationResolved = source.DurationResolved.ToString();
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.MilestoneResolved = source.MilestoneResolved;
            #endregion

        }

        private static void Mapper(TaskDto source, Task destination)
        {
            destination.Name = source.Name;
            destination.Duration = TimeSpan.Parse(source.Duration);
            destination.PercentComplete = (float)source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.Deadline = source.DeadLine;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
        }

        private static void Mapper(ProjectDto source, ProjectDto destination)
        {
            destination.Comments = source.Comments;
            destination.ContingenciesRate = source.ContingenciesRate;
            destination.CreateDate = source.CreateDate;
            destination.CxcApproval = source.CxcApproval;
            destination.DiscountRate = source.DiscountRate;
            destination.GuaranteeRate = source.GuaranteeRate;
            destination.ManagementApproval = source.ManagementApproval;
            destination.Name = source.Name;
            destination.OthersRate = source.OthersRate;
            destination.SalesTax = source.SalesTax;
            destination.TotalUtilityRate = source.TotalUtilityRate;
        }

        #endregion

        #region Loads Methods

        /// <summary>
        /// Gets the dependencies of a task
        /// </summary>
        /// <param name="sourceDependencies">Lista con las dependencias de la tarea, leidas de la BD</param>
        /// <param name="destination">Collección de tareas que el control leera como las dependencias de una tarea</param>
        /// <param name="tasks"></param>
        private static void LoadDependencies(IEnumerable<TaskDto> sourceDependencies, TaskDependenciesCollection destination, List<Task> tasks)
        {
            foreach (var t in sourceDependencies)
            {
                var task = tasks.Where(x => x.RowNumber == t.RowNumber).SingleOrDefault();
                if (task != null)
                {
                    destination.Add(task, TaskDependencyType.FinishToStart);
                }
            }
        }

        /// <summary>
        /// Este método se encarga de cargar las tareas traidas desde la BD al control encargado de desplegarlas al usuario
        /// </summary>
        private void LoadTasks()
        {
            var allTask = new List<Task>();
            foreach (var t in _project.Tasks.OrderBy(x => x.RowNumber))
            {
                var tmpTask = new Task();

                Mapper(t, tmpTask);
                ultraCalendarInfo.Tasks.Add(tmpTask);
                allTask.Add(tmpTask);

                if (t.Resources != null)                                             //Se los recursos de las tareas
                    tmpTask.Tag = t.Resources;

                if (t.Task1.Count > 0)                                           //Se incluyen las dependencias de la tarea
                    LoadDependencies(t.Task1, tmpTask.Dependencies, allTask);

                for (var i = 1; i <= t.TaskLevel; i++)                                  //Se agrega el nivel de la tarea
                    tmpTask.Indent();
            }
        }

        /// <summary>
        /// Método que se encarga de cargar en una variable local el proyecto que se esta trabajando.
        /// </summary>
        /// <param name="project"></param>
        public void LoadProject(ProjectDto project)
        {
            var request = new ProjectRequest {Project = project};
            _project = new ProjectFactory().GetProject(request).Project ?? project;

            repositoryItemProject.NullText = _project.Id.ToString();
            repositoryItemProjectName.NullText = _project.Name;
            repositoryItemCustumer.NullText = _project.Customer.Name;

            LoadTasks();
        }

        #endregion

        #region Save Methods

        /// <summary>
        /// Recursive method that gets all the tasks
        /// </summary>
        /// <param name="taskList">Lista de tareas a agregar en _allTask</param>
        /// /// <returns>Sequential list of tasks</returns>
        private static IEnumerable<Task> GetTaskInCalendar(IEnumerable<Task> taskList)
        {
            var odt = new List<Task>();
            try
            {
                foreach (var t in taskList)
                {
                    odt.Add(t);
                    if (t.Tasks.Count > 0)
                    {
                        var tasks = GetTaskInCalendar(t.Tasks.ToList());
                        odt.AddRange(tasks);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return odt;
        }

        /// <summary>
        /// Gets all the tasks that will be stored in the data source
        /// </summary>
        /// <returns>Tasks of the project</returns>
        private List<TaskDto> GetTask()
        {
            var taskDtoListIndexes = new List<TaskDto>();
            var taskDtoList = new List<TaskDto>();

            foreach (var tmpTask in GetTaskInCalendar(ultraCalendarInfo.Tasks.ToList()))
            {
                if (tmpTask.Dependencies.Count > 0)
                {
                    foreach (var tmpTaskDependency in tmpTask.Dependencies)
                    {
                        var taskParent = taskDtoListIndexes.Where(x => x.RowNumber == tmpTaskDependency.Predecessor.RowNumber).SingleOrDefault();
                        var tmpTaskDto = new TaskDto();
                        Mapper(tmpTask, tmpTaskDto);
                        if (taskParent != null) taskParent.Tasks.Add(tmpTaskDto);
                        taskDtoListIndexes.Add(tmpTaskDto);
                    }
                }
                else
                {
                    var tmpTaskDto = new TaskDto();
                    Mapper(tmpTask, tmpTaskDto);
                    //Si la tarea no tiene dependencias se agrega normal a la lista
                    taskDtoList.Add(tmpTaskDto);
                    taskDtoListIndexes.Add(tmpTaskDto);
                }
            }
            return taskDtoList;
        }

        private void SaveProject()
        {
            try
            {
                var request = new ProjectRequest();
                _project.Tasks = GetTask();
                request.Project = _project;
                _project = new ProjectFactory().SaveProject(request).Project;
                MessageBox.Show(@"Proyecto guardado exitosamente", @"Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Operations of the Options Menu

        /// <summary>
        /// Add a task to the TDO
        /// </summary>
        private void AddTask()
        {
            try
            {
                var t = new Task();
                t.SetDuration(new TimeSpan(1, 0, 0, 0, 0), Infragistics.Win.TimeSpanFormat.Days);
                t.Deadline = DateTime.Today;
                ultraCalendarInfo.Tasks.Add(t);
                t.Name = "Tarea " + t.RowNumber;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes all the tasks that are selected by the user
        /// </summary>
        private void DeleteTask()
        {
            try
            {
                foreach (var task in _selectedTask)
                {
                    if (task.Level > 0)
                    {
                        var tmpTask = task.Parent;
                        tmpTask.Tasks.Remove(task);
                    }
                    else
                        if (task.Level == 0)
                        {
                            ultraCalendarInfo.Tasks.Remove(task);
                        }
                }
                _selectedTask.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add a level in the hierarchy of tasks to all the selected tasks
        /// </summary>
        private void MoveRightTask()
        {
            try
            {
                foreach (var t in _selectedTask)
                {
                    if (!t.Indent())
                        MessageBox.Show(@"Operación no válida");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Removes one level in the hierarchy of tasks to all selected tasks
        /// </summary>
        private void MoveLeftTask()
        {
            try
            {
                foreach (var t in _selectedTask)
                {
                    if (!t.Outdent())
                        MessageBox.Show(@"Operación no válida");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Take the list of tasks that are in the selectedTask and makes one dependent on another in the order they appear in the ODT
        /// </summary>
        private void LinkTask(TaskDependencyType tdt)
        {
            try
            {
                UnlinkTask();
                if (_selectedTask.Count >= 0)
                {
                    for (var i = _selectedTask.Count - 1; i >= 1; i--)
                    {
                        _selectedTask[i].Dependencies.Add(_selectedTask[i - 1], tdt);
                    }
                }
                ultraCalendarInfo.Appearances.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Take the list of tasks that are in the selectedTask and disclaims any way dependent on the other
        /// </summary>
        private void UnlinkTask()
        {
            try
            {
                if (_selectedTask.Count >= 0)
                {
                    for (var i = _selectedTask.Count - 1; i >= 1; i--)
                    {
                        _selectedTask[i].Dependencies.Remove(_selectedTask[i - 1]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Región encargada de seleccionar una o varias tareas en el organigrama de distribución de tareas

        /// <summary>
        /// Método que se encarga de marcar visualmente una tarea cambiadole el color de fondo y el color de letra,
        /// si la tarea ya estaba marcada la retorna a su estado original.
        /// Ademas se encarga de agregar a tarea a la lista de tareas marcadas y si esta ya estaba entonces la saca.
        /// </summary>
        /// <param name="t">Tarea a la que se le cambia la forma de visualizarse</param>
        private void SelectTask(Task t)
        {
            if (t.GridSettings.RowAppearance.BackColor.Equals(Color.Black))
            {
                _selectedTask.Remove(t);
                t.GridSettings.RowAppearance.BackColor = Color.White;
                t.GridSettings.RowAppearance.ForeColor = Color.Black;
            }
            else
            {
                _selectedTask.Add(t);
                t.GridSettings.RowAppearance.BackColor = Color.Black;
                t.GridSettings.RowAppearance.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Devuelve la lista de tareas a su apariencia original y limpia la lista de tareas para que no quede 
        /// ninguna marcada
        /// </summary>
        private void ResetSelectedTaskList()
        {
            foreach (var t in _selectedTask)
            {
                t.GridSettings.RowAppearance.BackColor = Color.White;
                t.GridSettings.RowAppearance.ForeColor = Color.Black;
            }
            _selectedTask.Clear();
        }

        /// <summary>
        /// Implementación no clásica de la función Pivote. En lugar de recorrer el vector simultáneamente
        /// desde ambos extremos hasta el cruce de índices, se recorre desde el comienzo hasta el final.
        /// </summary>
        /// <param name="v">Array que contiene las tareas</param>
        /// <param name="prim">Primer elemento del array</param>
        /// <param name="ult">Ultimo elemento del array</param>
        /// <param name="piv">Elemento donde se encuentra el pivote</param>
        /// <returns></returns>
        private static int Pivote(Task[] v, int prim, int ult, int piv)
        {
            var p = v[piv].RowNumber;
            var j = prim;

            // Mueve el pivote a la última posición del vector
            Intercambia(v, piv, ult);

            /* Recorre el vector moviendo los elementos menores
             o iguales que el pivote al comienzo del mismo */
            for (var i = prim; i < ult; i++)
            {
                if (v[i].RowNumber <= p)
                {
                    Intercambia(v, i, j);
                    j++;
                }
            }

            // Mueve el pivote a la posición que le corresponde
            Intercambia(v, j, ult);

            return j;
        }

        /// <summary>
        /// Intercambia dos valores de posición dentro del array que contiene las tareas
        /// </summary>
        /// <param name="v">Array que contiene las tareas</param>
        /// <param name="a">Posición dentro del array que contiene el primer valor</param>
        /// <param name="b">Posición dentro del array que contiene el segundo valor</param>
        private static void Intercambia(Task[] v, int a, int b)
        {
            if (a == b) return;
            var tmp = v[a];
            v[a] = v[b];
            v[b] = tmp;
        }

        /// <summary>
        /// Método que implementa el algoritmo quicksort para ordenar las tareas que se han seleccionado en el organigrama
        /// de distribución de tareas
        /// </summary>
        /// <param name="v">Array que contiene las tareas que se desean ordenar</param>
        /// <param name="prim">Primer elemento del arreglo</param>
        /// <param name="ult">Ultimo elemento del arreglo</param>
        private static void QuickSort(Task[] v, int prim, int ult)
        {
            if (prim < ult)
            {
                //Selecciona un elemento del vector y coloca los menores que él a su izquierda y los mayores a su derecha
                var p = Pivote(v, prim, ult, ult);

                //Repite el proceso para cada una de las particiones generadas en el paso anterior
                QuickSort(v, prim, p - 1);
                QuickSort(v, p + 1, ult);
            }
        }

        /// <summary>
        /// Ordena las tareas agregadas a la lista segun el numero de tarea que se le asigna mediante e método quicksort
        /// </summary>
        private void OrderTaskList()
        {
            var tasks = _selectedTask.ToArray();
            QuickSort(tasks, 0, tasks.Length - 1);
            _selectedTask = tasks.ToList();
        }

        #endregion

        #region UI Events

        private void projectGantt_ActiveTaskChanging(object sender, Infragistics.Win.UltraWinGanttView.ActiveTaskChangingEventArgs e)
        {
            //Si se selecciona una tarea mientras se mantiene control presionado, esta se agrega a una lista de
            //tareas sino se mantiene control presionado entonces se limpia la lista
            if (Control.ModifierKeys.Equals(Keys.Control))
            {
                //Se desactiva el dialogo de tareas.
                projectGantt.AutoDisplayTaskDialog = Infragistics.Win.UltraWinGanttView.AutoDisplayTaskDialog.No;
                SelectTask(e.NewActiveTask);
                OrderTaskList();
            }
            else
            {
                //Se activa el dialogo de tareas.
                projectGantt.AutoDisplayTaskDialog = Infragistics.Win.UltraWinGanttView.AutoDisplayTaskDialog.GridArea;
                ResetSelectedTaskList();
                SelectTask(e.NewActiveTask);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se da doble click sobre alguna tarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectGantt_TaskDialogDisplaying(object sender, Infragistics.Win.UltraWinGanttView.TaskDialogDisplayingEventArgs e)
        {
            //Se saca la tarea seleccionada el ODT
            var ugv = sender as Infragistics.Win.UltraWinGanttView.UltraGanttView;
            if (ugv != null)
            {
                var t = ugv.ActiveTask;

                //Se instancia la pantalla donde se veran los datos de la tarea
                var ti = new TaskInfo {Tag = t, Project = _project};
                ti.ShowDialog();
            }
            //Se cancela la pantalla por defecto que trae el control
            e.Cancel = true;
        }

        private void barButtonNewTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTask();
        }

        private void barButtonDeleteTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteTask();
        }

        private void barButtonMoveRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoveRightTask();
        }

        private void barButtonMoveLeft_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoveLeftTask();
        }

        private void barButtonLinkTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            LinkTask(TaskDependencyType.FinishToStart);
        }

        private void barButtonUnlinkTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            UnlinkTask();
        }

        private void barButtonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveProject();
        }

        private void ribData_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            var projectView = new CreateProject {Tag = _project, Text = @"Información del Projecto"};
            
            if (projectView.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Mapper(projectView.Tag as ProjectDto, _project);
        }

        #endregion
    }
}