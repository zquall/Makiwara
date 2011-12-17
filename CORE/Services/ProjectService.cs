using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;

namespace CORE.Services
{
    public class ProjectService
    {
        public ProjectService()
        {
        }

        private List<TaskData> getDependencies(Nexus.Task t)
        {
            List<TaskData> dependencies = new List<TaskData>();

            dependencies = mapper(t.Task1);

            return dependencies;
        }

        private List<TaskData> mapper(System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks)
        {
            List<TaskData> listTask = new List<TaskData>();

            if (tasks != null)
            {
                foreach (Nexus.Task task in tasks)
                {
                    TaskData tmpTask = new TaskData();

                    tmpTask.Id = task.Id;
                    tmpTask.ProjectId = task.ProjectId;
                    tmpTask.ParentId = task.ParentId;
                    tmpTask.Name = task.Name;
                    tmpTask.Duration = TimeSpan.Parse(task.Duration);
                    tmpTask.PercentComplete = task.PercentComplete;
                    tmpTask.StartDateTime = task.StartDateTime;
                    tmpTask.EndDateTime = task.EndDateTime;
                    tmpTask.Notes = task.Notes;
                    tmpTask.RowNumber = task.RowNumber;
                    tmpTask.BindingListIndex = task.BindingListIndex;
                    tmpTask.CompleteThrough = task.CompleteThrough;
                    tmpTask.DeadLine = task.DeadLine;
                    tmpTask.DurationResolved = TimeSpan.Parse(task.DurationResolved);
                    tmpTask.EndDateTimeResolved = task.EndDateTimeResolved;
                    tmpTask.Expanded = task.Expanded;
                    tmpTask.IsRoot = task.IsRoot;
                    tmpTask.IsSummary = task.IsSumary;
                    tmpTask.TaskLevel = task.TaskLevel;
                    tmpTask.Milestone = task.Milestone;
                    tmpTask.MilestoneResolved = task.MilestoneResolved;

                    tmpTask.Dependencies = getDependencies(task);

                    listTask.Add(tmpTask);
                }
            }

            return listTask;
        }

        private List<ProjectData> getProjects(List<Nexus.Project> projectFounded)
        {
            List<ProjectData> ProjectList = new List<ProjectData>();

            if (projectFounded != null)
            {
                // Fill the response with the customers founded
                foreach (var project in projectFounded)
                {
                    ProjectData tmpProjectData = new ProjectData();

                    tmpProjectData.Id = project.Id;
                    tmpProjectData.Name = project.Name;
                    tmpProjectData.BudgetRequestId = project.BudgetRequestId;
                    tmpProjectData.CustumerId = project.CustumerId;
                    tmpProjectData.CustumerName = project.Customer.Name;
                    tmpProjectData.EmployeeId = project.EmployeeId;
                    tmpProjectData.ManagementApproval = project.ManagementApproval;
                    tmpProjectData.CxcApproval = project.CxcApproval;
                    tmpProjectData.CreateDate = project.CreateDate;
                    tmpProjectData.ContingenciesRate = project.ContingenciesRate;
                    tmpProjectData.GuaranteeRate = project.GuaranteeRate;
                    tmpProjectData.TotalUtilityRate = project.TotalUtilityRate;
                    tmpProjectData.DiscountRate = project.DiscountRate;
                    tmpProjectData.SalesTax = project.SalesTax;
                    tmpProjectData.OthersRate = project.OthersRate;
                    tmpProjectData.Comments = project.Comments;

                    tmpProjectData.taskList = mapper(project.Tasks);

                    ProjectList.Add(tmpProjectData);
                }
            }


            return ProjectList;
        }

        public ProjectResponse searchProject(ProjectRequest request)
        {
            const int maximunResultRows = 20;

            var response = new ProjectResponse();

            // Inicitialize the list of customers
            response.ProjectList = new List<ProjectData>();

            //var projectFoundedById = Olympus._Enterprise.Projects.Where(x => x.Id.Contains(request.SearchProjectQuery)).OrderBy(y => y.Id).Take(maximunResultRows).ToList();
            var projectFoundByName = Olympus._Enterprise.Projects.Where(x => x.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            var projectFoundByCustumer = Olympus._Enterprise.Projects.Where(x => x.Customer.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Customer.Name).Take(maximunResultRows).ToList();

            response.ProjectList.AddRange(getProjects(projectFoundByName));
            response.ProjectList.AddRange(getProjects(projectFoundByCustumer));

            return response;
        }

        public int nextCode()
        {
            int code = Olympus._Enterprise.Projects.Max(x => x.Id) + 1;

            return code;
        }


        #region Save Project

        /// <summary>
        /// Method responsible for setting the properties of an object type Nexus.Task in a object type Nexus.Task
        /// </summary>
        /// <param name="source">Data source</param>
        /// <param name="destination">Data destination</param>
        private void mapper(Nexus.Task source, Nexus.Task destination)
        {
            #region Propidades no seteables
            //destination.Parent = ultraCalendarInfo.Tasks[source.ParentId];
            #endregion

            destination.ProjectId = source.ProjectId;
            destination.Id = source.Id;

            destination.Name = source.Name;
            destination.Duration = source.Duration.ToString();
            destination.PercentComplete = (float)source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.DeadLine = source.DeadLine;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
            destination.RowNumber = source.RowNumber;
            destination.TaskLevel = source.TaskLevel;

            #region Properties that are not necessary
            destination.IsRoot = source.IsRoot;
            destination.IsSumary = source.IsSumary;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DurationResolved = source.DurationResolved.ToString();
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.MilestoneResolved = source.MilestoneResolved;
            #endregion

            #region Save Dependencies

            //foreach (TaskDependency t in source.Dependencies)
            //{
            //    TaskData task = new TaskData(); t.
            //    mapper(t, task);
            //     list.Add(task);
            //}

            #endregion
        }

        /// <summary>
        /// Method responsible for setting the properties of an object type TaskData in a object type Nexus.Task
        /// </summary>
        /// <param name="source">Data source</param>
        /// <param name="destination">Data destination</param>
        private void mapper(TaskData source, Nexus.Task destination)
        {
            #region Propidades no seteables
            //destination.Parent = ultraCalendarInfo.Tasks[source.ParentId];
            #endregion

            destination.ProjectId = source.ProjectId;
            destination.Id = source.Id;

            destination.Name = source.Name;
            destination.Duration = source.Duration.ToString();
            destination.PercentComplete = (float)source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.DeadLine = source.DeadLine;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
            destination.RowNumber = source.RowNumber;
            destination.TaskLevel = source.TaskLevel;

            #region Properties that are not necessary
            destination.IsRoot = source.IsRoot;
            destination.IsSumary = source.IsSummary;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DurationResolved = source.DurationResolved.ToString();
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.MilestoneResolved = source.MilestoneResolved;
            #endregion

            #region Save Dependencies

            //foreach (TaskDependency t in source.Dependencies)
            //{
            //    TaskData task = new TaskData(); t.
            //    mapper(t, task);
            //     list.Add(task);
            //}

            #endregion
        }

        /// <summary>
        /// Método que se encarga de obtener las tareas del proyecto que sera almacenado en la BD
        /// </summary>
        /// <param name="taskList">Origen de las tareas</param>
        /// <returns>Lista con las tareas a ser almacenadas en la BD</returns>
        private System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> getTask(List<TaskData> taskList)
        {
            System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks = new System.Data.Objects.DataClasses.EntityCollection<Nexus.Task>();

            foreach (TaskData t in taskList.OrderBy(x => x.RowNumber))
            {
                Nexus.Task task = new Nexus.Task();
                mapper(t, task);
                tasks.Add(task);
            }

            return tasks;
        }

        /// <summary>
        /// Se encarga de copiar los datos de un objeto ProjectData en un objeto Nexus.Project
        /// </summary>
        /// <param name="project">Origen de los datos</param>
        /// <returns>Objeto Nexus.Project con datos a ser guardados</returns>
        private Nexus.Project mapper(ProjectData project)
        {
            Nexus.Project p = new Nexus.Project();

            p.Id = project.Id;
            p.BudgetRequestId = project.BudgetRequestId;
            p.CustumerId = project.CustumerId;
            p.EmployeeId = project.EmployeeId;
            p.Name = project.Name;
            p.ManagementApproval = project.ManagementApproval;
            p.CxcApproval = project.CxcApproval;
            p.CreateDate = project.CreateDate;
            p.ContingenciesRate = project.ContingenciesRate;
            p.GuaranteeRate = project.GuaranteeRate;
            p.TotalUtilityRate = project.TotalUtilityRate;
            p.DiscountRate = project.DiscountRate;
            p.SalesTax = project.SalesTax;
            p.OthersRate = project.OthersRate;
            p.Comments = project.Comments;
            p.Tasks = getTask(project.taskList);

            return p;
        }



        /// <summary>
        /// Método que se encarga de acomodar y guardar un projecto
        /// </summary>
        /// <param name="request">Objeto donde viene el proyecto a ser almacenado en BD</param>
        public void saveProject(ProjectRequest request)
        {
            // Validate if the contact Exist
            Nexus.Project projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();

            if (projectFound != null)
            {
                projectFound = mapper(request.Project);
                foreach (Nexus.Task t in projectFound.Tasks)
                {
                    Nexus.Task task = Olympus._Enterprise.Tasks.Where(y => y.ProjectId == t.ProjectId).Where(x => x.Id == t.Id).SingleOrDefault();

                    if (task != null)
                    {
                        mapper(t, task);
                    }
                    else
                    {
                        Olympus._Enterprise.AddToTasks(task);
                    }
                }
            }
            else
            {
                Nexus.Project newProject = new Nexus.Project();
                newProject = mapper(request.Project);
                Olympus._Enterprise.AddToProjects(newProject);
            }

            Olympus._Enterprise.SaveChanges();
        }

        #endregion
    }
}
