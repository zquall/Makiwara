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

namespace shellProject
{
    public partial class ProjectManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// Lista que contiene las tareas seleccionadas por un usuario
        /// </summary>
        private List<Task> selectedTask = new List<Task>();

        private ProjectData _project = new ProjectData();

        public ProjectManager()
        {
            InitializeComponent();
        }

        private Project getProject()
        {
            Project tmpProject = new Project();
            tmpProject.Name = _project.Name;
            return tmpProject;
        }

        private void chargeTasks()
        {
            foreach (TaskData t in _project.taskList)
            {
                Task tmpTask = new Task();
                
                //tmpTask.Id = Guid.Parse(t.Id.ToString());
                //tmpTask.ProjectKey = t.ProjectId;
                //tmpTask.Parent = ultraCalendarInfo.Tasks[t.ParentId];
                tmpTask.Name = t.Name;
                tmpTask.Duration = t.Duration;
                tmpTask.PercentComplete = (float)t.PercentComplete;
                tmpTask.StartDateTime = t.StartDateTime;
                tmpTask.EndDateTime = t.EndDateTime;
                tmpTask.Notes = t.Notes;
                //tmpTask.RowNumber = t.Rownumber;
                //tmpTask.BindingListIndex = t.BindingListindex;
                //tmpTask.CompleteThrough = t.CompleteThrough;
                tmpTask.Deadline = t.DeadLine;
                //tmpTask.DurationResolved = t.DurationResolved;
                //tmpTask.EndDateTimeResolved = t.EndDateTimeResolved;
                tmpTask.Expanded = t.Expanded;
                //tmpTask.IsRoot = t.IsRoot;
                //tmpTask.IsSummary = t.IsSumary;
                //tmpTask.Level = t.TaskLevel;
                tmpTask.Milestone = t.Milestone;
                //tmpTask.MilestoneResolved = t.MilestoneResolved;
                ultraCalendarInfo.Tasks.Add(tmpTask);

                for (int i = 1; i <= t.TaskLevel; i++)
                    tmpTask.Indent();
            }
            
        }

        public void chargeProject(ProjectData project)
        {
            _project = project;

            repositoryItemProject.NullText = _project.Id.ToString();
            repositoryItemProjectName.NullText = _project.Name;
            repositoryItemCustumer.NullText = _project.CustumerName;

            //projectGantt.Project = getProject();
            chargeTasks();
        }

  
        #region Region encargada de las operaciones del menu de opciones

        private void createProject()
        {
            CreateProject cp = new CreateProject();
            cp.Text = "Crear Proyecto";
            cp.ShowDialog();
        }

        /// <summary>
        /// Agrega una tarea al Organigrama de Distribución de Tareas
        /// </summary>
        private void addTask()
        {
            Task t = new Task();
            t.SetDuration(new TimeSpan(1, 0, 0, 0, 0), Infragistics.Win.TimeSpanFormat.Days);
            ultraCalendarInfo.Tasks.Add(t);
            t.Name = "Tarea " + t.RowNumber;
        }

        /// <summary>
        /// Elimina todas las tareas que se encuentren seleccionadas por parte del usuario
        /// </summary>
        private void deleteTask()
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

        /// <summary>
        /// Agrega un nivel en la jerarquía de tareas a todas las tareas seleccionadas
        /// </summary>
        private void moveRightTask()
        {
            foreach (Task t in selectedTask)
            {
                if (!t.Indent())
                    MessageBox.Show("Operación no válida");
            }
        }

        /// <summary>
        /// Quita un nivel en la jerarquía de tareas a todas las tareas seleccionadas
        /// </summary>
        private void moveLeftTask()
        {
            foreach (Task t in selectedTask)
            {
                if (!t.Outdent())
                    MessageBox.Show("Operación no válida");
            }
        }

        /// <summary>
        /// Toma la lista de tareas que se encuentran en el selectedTask y las hace una dependiente de otra segun el orden 
        /// en que aparecen en el ODT
        /// </summary>
        private void linkTask(TaskDependencyType tdt)
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

        /// <summary>
        /// Toma la lista de tareas que se encuentran en el selectedTask y las desliga de forma que ninguna dependa de la otra
        /// </summary>
        private void unlinkTask()
        {
            if (selectedTask.Count >= 0)
            {
                for (int i = selectedTask.Count - 1; i >= 1; i--)
                {
                    selectedTask[i].Dependencies.Remove(selectedTask[i - 1]);
                }
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

        #region Region encargada de ejecutar las opciones del menu

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

        #endregion
    }
}