using System;
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
        /// Selected Task
        /// </summary>
        private List<Task> _selectedTask = new List<Task>();

        /// <summary>
        /// Project in execution
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

            destination.Resources = source.Tag as List<ResourceDto>;

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

        #endregion

        #region Loads Methods

        /// <summary>
        /// Clear the project in execution
        /// </summary>
        private void ClearProject()
        {
            projectGantt.CalendarInfo.Tasks.Clear();
        }

        /// <summary>
        /// Gets the dependencies and the type dependencie of the tasks in the project
        /// </summary>
        /// <param name="sourceDependencies">Task's dependencies from the DB</param>
        /// <param name="destination">Collection of dependencies for the Dev Express control</param>
        /// <param name="tasks">Dependencies source</param>
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
        /// Charge the tasks in the Dev Express Control
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

                if (t.Resources != null)
                    tmpTask.Tag = t.Resources;                                      

                if (t.Task1.Count > 0)
                    LoadDependencies(t.Task1, tmpTask.Dependencies, allTask);       

                for (var i = 1; i <= t.TaskLevel; i++)
                    tmpTask.Indent();
            }
        }

        /// <summary>
        /// Charge in the project the local variable _project
        /// </summary>
        public void LoadProject()
        {
            repositoryItemProject.NullText = _project.Code;
            repositoryItemProjectName.NullText = _project.Name;
            repositoryItemCustumer.NullText = _project.Customer.Name;

            LoadTasks();

            if ((_project.StateId == 2) || (_project.StateId == 3))
            {
                barButtonSave.Enabled = false;
                barButtonVoid.Enabled = false;
                barButtonClose.Enabled = false;
                barButtonNewTask.Enabled = false;
                barButtonDeleteTask.Enabled = false;
                barButtonResourceStore.Enabled = false;
                barButtonCalendar.Enabled = false;
                barButtonMoveLeft.Enabled = false;
                barButtonMoveRight.Enabled = false;
                barButtonLinkTask.Enabled = false;
                barButtonUnlinkTask.Enabled = false;
                barEditProject.Enabled = false;
                barEditName.Enabled = false;
                barEditClient.Enabled = false;
            }
        }

        /// <summary>
        /// Sets the value of the local variable _project and then load
        /// </summary>
        /// <param name="project"></param>
        public void LoadProject(ProjectDto project)
        {
            _project = project;
            LoadProject();
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
            var request = new ProjectRequest();

            _project.Tasks = GetTask();
            request.Project = _project;

            var id = new ProjectFactory().SaveProject(request).ProjectId;
            _project = new ProjectFactory().GetProject( new ProjectRequest { ProjectId = id}).Project;
        }

        private void SaveProcess()
        {
            try
            {
                SaveProject();
                ClearProject();
                LoadProject();
                MessageBox.Show(@"Proyecto guardado exitosamente", @"Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show(@"Se han generado errores a la hora de guardar el proyecto. " + e.Message, @"Lo siento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Operations of the Options Menu

        #region Project

        private static void CopyProject()
        {
            MessageBox.Show(@"Función en construcción", @"Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NullProject()
        {
            if (MessageBox.Show(@"Esta seguro que desea ANULAR este Proyecto.", @"Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _project.StateId = 2;
                SaveProcess();
            }
        }

        private void CloseProject()
        {
            if (MessageBox.Show(@"Esta seguro que desea CERRAR este Proyecto.", @"Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _project.StateId = 3;
                SaveProcess();
            }
        }

        #endregion

        #region Task

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

        private void ResourceStore()
        {
            _project.Tasks = GetTask();
            var resourceStoreView = new ResourceStore { Tag = _project };
            resourceStoreView.ShowDialog();
        }

        private static void Calendar()
        {
            var calendarView = new Calendar();
            calendarView.ShowDialog();
        }

        #endregion

        #region Hierarchy

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

        #endregion

        #region Links

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

        private void BarButtonSaveItemClick(object sender, ItemClickEventArgs e)
        {
            SaveProcess();
        }

        private void BarButtonCopyItemClick(object sender, ItemClickEventArgs e)
        {
            CopyProject();
        }

        private void BarButtonVoidItemClick(object sender, ItemClickEventArgs e)
        {
            NullProject();
        }

        private void BarButtonCloseItemClick(object sender, ItemClickEventArgs e)
        {
            CloseProject();
        }

        //****************************************************************************************

        private void BarButtonNewTaskItemClick(object sender, ItemClickEventArgs e)
        {
            AddTask();
        }

        private void BarButtonDeleteTaskItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteTask();
        }

        private void BarButtonResourceStoreItemClick(object sender, ItemClickEventArgs e)
        {
            ResourceStore();
        }

        private void BarButtonCalendarItemClick(object sender, ItemClickEventArgs e)
        {
            Calendar();
        }

        //****************************************************************************************

        private void BarButtonMoveRightItemClick(object sender, ItemClickEventArgs e)
        {
            MoveRightTask();
        }

        private void BarButtonMoveLeftItemClick(object sender, ItemClickEventArgs e)
        {
            MoveLeftTask();
        }

        //****************************************************************************************

        private void BarButtonLinkTaskItemClick(object sender, ItemClickEventArgs e)
        {
            LinkTask(TaskDependencyType.FinishToStart);
        }

        private void BarButtonUnlinkTaskItemClick(object sender, ItemClickEventArgs e)
        {
            UnlinkTask();
        }

        //****************************************************************************************

        private void ProjectGanttActiveTaskChanging(object sender, Infragistics.Win.UltraWinGanttView.ActiveTaskChangingEventArgs e)
        {
            //Si se selecciona una tarea mientras se mantiene control presionado, esta se agrega a una lista de
            //tareas sino se mantiene control presionado entonces se limpia la lista
            if (ModifierKeys.Equals(Keys.Control))
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

        private void ProjectGanttTaskDialogDisplaying(object sender, Infragistics.Win.UltraWinGanttView.TaskDialogDisplayingEventArgs e)
        {
            var ugv = sender as Infragistics.Win.UltraWinGanttView.UltraGanttView;
            if (ugv != null)
            {
                var t = ugv.ActiveTask;
                var ti = new TaskInfo { Tag = t, Project = _project, TaskDurationWorkingTimePerDay = ultraCalendarInfo.TaskDurationWorkingTimePerDay};
                ti.ShowDialog();
            }
            //Se cancela la pantalla por defecto que trae el control
            e.Cancel = true;
        }

        /// <summary>
        /// Show the Information Project Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RibDataCaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            #region Budget Request and State of the Project if both are null
            if (_project.BudgetRequest == null)
            {
                var request = new BudgetRequestRequest {BudgetResquestId = _project.BudgetRequestId};
                _project.BudgetRequest = new BudgetRequestFactory().GetBudgetRequest(request).BudgetRequest;
            }

            if (_project.ProjectState == null)
            {
                var request = new ProjectStateRequest { ProjectStateId = _project.StateId };
                _project.ProjectState = new ProjectStateFactory().GetProjectState(request).ProjectState;
            }
            #endregion

            var projectView = new CreateProject {Tag = _project, Text = @"Información del Projecto"};

            if (projectView.ShowDialog() == DialogResult.OK)
            {
                ClearProject();
                LoadProject(projectView.Tag as ProjectDto);
            }
        }

        #endregion
    }
}