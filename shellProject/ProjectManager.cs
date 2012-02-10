using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
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
        private List<Task> selectedTask = new List<Task>();

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

        private void mapper(TaskDto source, Task destination)
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

        private void mapper(Task source, TaskDto destination)
        {
            #region Propidades no seteables
            //destination.Parent = ultraCalendarInfo.Tasks[source.ParentId];
            #endregion

            destination.ProjectId = _project.Id;
            //destination.Id = source.RowNumber;

            destination.Name = source.Name;
            destination.Duration = source.Duration.ToString();
            destination.PercentComplete = (float)source.PercentComplete;
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

        #endregion

        #region Loads Methods

        /// <summary>
        /// Gets the dependencies of a task
        /// </summary>
        /// <param name="sourceDependencies">Lista con las dependencias de la tarea, leidas de la BD</param>
        /// <param name="destination">Collección de tareas que el control leera como las dependencias de una tarea</param>
        private void loadDependencies(ICollection<TaskDto> sourceDependencies, TaskDependenciesCollection destination, List<Task> tasks)
        {
            foreach (TaskDto t in sourceDependencies)
            {
                Task task = tasks.Where(x => x.RowNumber == t.RowNumber).SingleOrDefault();
                if (task != null)
                {
                    destination.Add(task, TaskDependencyType.FinishToStart);
                }
            }
        }

        /// <summary>
        /// Este método se encarga de cargar las tareas traidas desde la BD al control encargado de desplegarlas al usuario
        /// </summary>
        private void loadTasks()
        {
            List<Task> allTask = new List<Task>();
            foreach (var t in _project.Tasks.OrderBy(x => x.RowNumber))
            {
                Task tmpTask = new Task();

                mapper(t, tmpTask);
                ultraCalendarInfo.Tasks.Add(tmpTask);
                allTask.Add(tmpTask);

                if (t.Resources != null)                                             //Se los recursos de las tareas
                    tmpTask.Tag = t.Resources;

                if (t.Task1.Count > 0)                                           //Se incluyen las dependencias de la tarea
                    loadDependencies(t.Task1, tmpTask.Dependencies, allTask);

                for (int i = 1; i <= t.TaskLevel; i++)                                  //Se agrega el nivel de la tarea
                    tmpTask.Indent();
            }
        }

        /// <summary>
        /// Método que se encarga de cargar en una variable local el proyecto que se esta trabajando.
        /// </summary>
        /// <param name="project"></param>
        public void loadProject(ProjectDto project)
        {
            var request = new ProjectRequest();
            request.Project = project;
            _project = new ProjectFactory().getProject(request).Project;

            repositoryItemProject.NullText = _project.Id.ToString();
            repositoryItemProjectName.NullText = _project.Name;
            repositoryItemCustumer.NullText = _project.Customer.Name;

            loadTasks();
        }

        #endregion

        #region Save Methods

        /// <summary>
        /// Recursive method that gets all the tasks
        /// </summary>
        /// <param name="taskList">Lista de tareas a agregar en _allTask</param>
        /// /// <returns>Sequential list of tasks</returns>
        private List<Task> getTaskInCalendar(List<Task> taskList)
        {
            List<Task> ODT = new List<Task>();
            try
            {
                foreach (Task t in taskList)
                {
                    ODT.Add(t);
                    if (t.Tasks.Count > 0)
                    {
                        List<Task> tasks = new List<Task>();
                        tasks = getTaskInCalendar(t.Tasks.ToList());
                        ODT.AddRange(tasks);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ODT;
        }

        /// <summary>
        /// Gets all the tasks that will be stored in the data source
        /// </summary>
        /// <returns>Tasks of the project</returns>
        private List<TaskDto> getTask()
        {
            List<TaskDto> TaskDtoListIndexes = new List<TaskDto>();
            List<TaskDto> TaskDtoList = new List<TaskDto>();

            foreach (Task tmpTask in getTaskInCalendar(ultraCalendarInfo.Tasks.ToList()))
            {
                if (tmpTask.Dependencies.Count > 0)
                {    
                    foreach (TaskDependency tmpTaskDependency in tmpTask.Dependencies)
                    {
                        TaskDto taskParent = TaskDtoListIndexes.Where(x => x.RowNumber == tmpTaskDependency.Predecessor.RowNumber).SingleOrDefault();
                        TaskDto tmpTaskDto = new TaskDto();
                        mapper(tmpTask, tmpTaskDto);
                        taskParent.Tasks.Add(tmpTaskDto);
                        TaskDtoListIndexes.Add(tmpTaskDto);
                    }
                }
                else
                {
                    TaskDto tmpTaskDto = new TaskDto();
                    mapper(tmpTask, tmpTaskDto);
                    //Si la tarea no tiene dependencias se agrega normal a la lista
                    TaskDtoList.Add(tmpTaskDto);
                    TaskDtoListIndexes.Add(tmpTaskDto);
                }
            }
            return TaskDtoList;
        }

        private void saveProject()
        {
            //try
            //{
                var request = new ProjectRequest();
                _project.Tasks = getTask();
                request.Project = _project;
                _project = new ProjectFactory().saveProject(request).Project;
                MessageBox.Show("Proyecto guardado exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #endregion

        #region Operations of the Options Menu

        /// <summary>
        /// Displays the creation of projects screen
        /// </summary>
        private void createProject()
        {
            CreateProject cp = new CreateProject();
            cp.Text = "Crear Proyecto";
            cp.ShowDialog();
        }

        /// <summary>
        /// Add a task to the TDO
        /// </summary>
        private void addTask()
        {
            try
            {
                Task t = new Task();
                t.SetDuration(new TimeSpan(1, 0, 0, 0, 0), Infragistics.Win.TimeSpanFormat.Days);
                t.Deadline = DateTime.Today;
                ultraCalendarInfo.Tasks.Add(t);
                t.Name = "Tarea " + t.RowNumber;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes all the tasks that are selected by the user
        /// </summary>
        private void deleteTask()
        {
            try
            {
                Task tmpTask = new Task();

                foreach (Task task in selectedTask)
                {
                    if (task.Level > 0)
                    {
                        tmpTask = task.Parent;
                        tmpTask.Tasks.Remove(task);
                    }
                    else
                        if (task.Level == 0)
                        {
                            ultraCalendarInfo.Tasks.Remove(task);
                        }
                }
                selectedTask.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add a level in the hierarchy of tasks to all the selected tasks
        /// </summary>
        private void moveRightTask()
        {
            try
            {
                foreach (Task t in selectedTask)
                {
                    if (!t.Indent())
                        MessageBox.Show("Operación no válida");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Removes one level in the hierarchy of tasks to all selected tasks
        /// </summary>
        private void moveLeftTask()
        {
            try
            {
                foreach (Task t in selectedTask)
                {
                    if (!t.Outdent())
                        MessageBox.Show("Operación no válida");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Take the list of tasks that are in the selectedTask and makes one dependent on another in the order they appear in the ODT
        /// </summary>
        private void linkTask(TaskDependencyType tdt)
        {
            try
            {
                unlinkTask();
                if (selectedTask.Count >= 0)
                {
                    for (int i = selectedTask.Count - 1; i >= 1; i--)
                    {
                        selectedTask[i].Dependencies.Add(selectedTask[i - 1], tdt);
                    }
                }
                ultraCalendarInfo.Appearances.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Take the list of tasks that are in the selectedTask and disclaims any way dependent on the other
        /// </summary>
        private void unlinkTask()
        {
            try
            {
                if (selectedTask.Count >= 0)
                {
                    for (int i = selectedTask.Count - 1; i >= 1; i--)
                    {
                        selectedTask[i].Dependencies.Remove(selectedTask[i - 1]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void selectTask(Task t)
        {
            if (t.GridSettings.RowAppearance.BackColor.Equals(Color.Black))
            {
                selectedTask.Remove(t);
                t.GridSettings.RowAppearance.BackColor = Color.White;
                t.GridSettings.RowAppearance.ForeColor = Color.Black;
            }
            else
            {
                selectedTask.Add(t);
                t.GridSettings.RowAppearance.BackColor = Color.Black;
                t.GridSettings.RowAppearance.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Devuelve la lista de tareas a su apariencia original y limpia la lista de tareas para que no quede 
        /// ninguna marcada
        /// </summary>
        private void resetSelectedTaskList()
        {
            foreach (Task t in selectedTask)
            {
                t.GridSettings.RowAppearance.BackColor = Color.White;
                t.GridSettings.RowAppearance.ForeColor = Color.Black;
            }
            selectedTask.Clear();
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
        private int Pivote(Task[] v, int prim, int ult, int piv)
        {
            int p = v[piv].RowNumber;
            int j = prim;

            // Mueve el pivote a la última posición del vector
            Intercambia(v, piv, ult);

            /* Recorre el vector moviendo los elementos menores
             o iguales que el pivote al comienzo del mismo */
            for (int i = prim; i < ult; i++)
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
        private void Intercambia(Task[] v, int a, int b)
        {
            if (a != b)
            {
                Task tmp = v[a];
                v[a] = v[b];
                v[b] = tmp;
            }
        }

        /// <summary>
        /// Método que implementa el algoritmo quicksort para ordenar las tareas que se han seleccionado en el organigrama
        /// de distribución de tareas
        /// </summary>
        /// <param name="v">Array que contiene las tareas que se desean ordenar</param>
        /// <param name="prim">Primer elemento del arreglo</param>
        /// <param name="ult">Ultimo elemento del arreglo</param>
        private void quickSort(Task[] v, int prim, int ult)
        {
            if (prim < ult)
            {
                ///Selecciona un elemento del vector y coloca los menores que él a su izquierda y los mayores a su derecha
                int p = Pivote(v, prim, ult, ult);

                ///Repite el proceso para cada una de las particiones generadas en el paso anterior
                quickSort(v, prim, p - 1);
                quickSort(v, p + 1, ult);
            }
        }

        /// <summary>
        /// Ordena las tareas agregadas a la lista segun el numero de tarea que se le asigna mediante e método quicksort
        /// </summary>
        private void orderTaskList()
        {
            Task[] tasks = selectedTask.ToArray();
            quickSort(tasks, 0, tasks.Length - 1);
            selectedTask = tasks.ToList();
        }

        /// <summary>
        /// Muestra en un messagebox la lista de tareas que se encuentran seleccionadas.
        /// </summary>
        private void showSelectedTasks()
        {
            string s = "Las Tareas Seleccionadas son: ";
            foreach (Task t in selectedTask)
            {
                s += t.RowNumber + "; ";
            }
            MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void projectGantt_ActiveTaskChanging(object sender, Infragistics.Win.UltraWinGanttView.ActiveTaskChangingEventArgs e)
        {
            ///Si se selecciona una tarea mientras se mantiene control presionado, esta se agrega a una lista de
            ///tareas sino se mantiene control presionado entonces se limpia la lista
            if (Control.ModifierKeys.Equals(Keys.Control))
            {
                ///Se desactiva el dialogo de tareas.
                projectGantt.AutoDisplayTaskDialog = Infragistics.Win.UltraWinGanttView.AutoDisplayTaskDialog.No;
                selectTask(e.NewActiveTask);
                orderTaskList();
            }
            else
            {
                ///Se activa el dialogo de tareas.
                projectGantt.AutoDisplayTaskDialog = Infragistics.Win.UltraWinGanttView.AutoDisplayTaskDialog.GridArea;
                resetSelectedTaskList();
                selectTask(e.NewActiveTask);
            }
        }

        #endregion

        #region UI Events

        /// <summary>
        /// Método que se ejecuta cuando se da doble click sobre alguna tarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectGantt_TaskDialogDisplaying(object sender, Infragistics.Win.UltraWinGanttView.TaskDialogDisplayingEventArgs e)
        {
            //Se saca al tarea seleccionada el ODT
            Infragistics.Win.UltraWinGanttView.UltraGanttView ugv = sender as Infragistics.Win.UltraWinGanttView.UltraGanttView;
            Task t = ugv.ActiveTask;

            //Se instancia la pantalla donde se veran los datos de la tarea
            TaskInfo ti = new TaskInfo();
            ti.Tag = t;
            ti.Project = _project;
            ti.ShowDialog();
            //Se cancela la pantalla por defecto que trae el control
            e.Cancel = true;
        }

        private void barButtonCreateProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            createProject();
        }

        private void barButtonNewTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTask();
        }

        private void barButtonDeleteTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            deleteTask();
        }

        private void barButtonMoveRight_ItemClick(object sender, ItemClickEventArgs e)
        {
            moveRightTask();
        }

        private void barButtonMoveLeft_ItemClick(object sender, ItemClickEventArgs e)
        {
            moveLeftTask();
        }

        private void barButtonLinkTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            linkTask(TaskDependencyType.FinishToStart);
        }

        private void barButtonUnlinkTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            unlinkTask();
        }

        private void barButtonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveProject();
        }

        private void ribData_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            CreateProject projectView = new CreateProject();
            projectView.Tag = _project;
            projectView.Text = "Información del Projecto";
            projectView.ShowDialog();
        }

        #endregion
    }
}