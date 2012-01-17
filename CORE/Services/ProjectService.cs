using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace CORE.Services
{
    public class ProjectService
    {
        public ProjectService()
        {
        }

        #region Object Mapping Methods

        private void mapper(ResourceTypeData source, Nexus.ResourceType destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }

        private void mapper(Nexus.ResourceType source, ResourceTypeData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }

        private void mapper(Nexus.ResourceType source, Nexus.ResourceType destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }


        private void mapper(MeasureData source, Nexus.Measure destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }

        private void mapper(Nexus.Measure source, MeasureData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }

        private void mapper(Nexus.Measure source, Nexus.Measure destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }


        private void mapper(ResourceData source, Nexus.Resource destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            //Nexus.Measure nm = new Nexus.Measure();
            //mapper(source.Measure, nm);
            //destination.Measure = nm;
            destination.MeasureId = source.Measure.Id;

            //Nexus.ResourceType nrt = new Nexus.ResourceType();
            //mapper(source.ResourceType, nrt);
            //destination.ResourceType = nrt;
            destination.ResourceTypeId = source.ResourceType.Id;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }

        private void mapper(Nexus.Resource source, ResourceData destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            MeasureData md = new MeasureData();
            mapper(source.Measure, md);
            destination.Measure = md;

            ResourceTypeData rtd = new ResourceTypeData();
            mapper(source.ResourceType, rtd);
            destination.ResourceType = rtd;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }

        private void mapper(Nexus.Resource source, Nexus.Resource destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            Nexus.Measure nm = new Nexus.Measure();
            mapper(source.Measure, nm);
            destination.Measure = nm;

            Nexus.ResourceType nrt = new Nexus.ResourceType();
            mapper(source.ResourceType, nrt);
            destination.ResourceType = nrt;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }


        private void mapper(TaskData source, Nexus.Task destination)
        {
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
        }

        private void mapper(Nexus.Task source, TaskData destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.ParentId = source.ParentId;
            destination.Name = source.Name;
            destination.Duration = TimeSpan.Parse(source.Duration);
            destination.PercentComplete = source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.RowNumber = source.RowNumber;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DeadLine = source.DeadLine;
            destination.DurationResolved = TimeSpan.Parse(source.DurationResolved);
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.Expanded = source.Expanded;
            destination.IsRoot = source.IsRoot;
            destination.IsSummary = source.IsSumary;
            destination.TaskLevel = source.TaskLevel;
            destination.Milestone = source.Milestone;
            destination.MilestoneResolved = source.MilestoneResolved;

            destination.Dependencies = loadDependencies(source);
            destination.resourceList = loadResources(source);
        }



        private void mapper(Nexus.Project source, ProjectData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.BudgetRequestId = source.BudgetRequestId;
            destination.CustumerId = source.CustumerId;
            destination.CustumerName = source.Customer.Name;
            destination.EmployeeId = source.EmployeeId;
            destination.ManagementApproval = source.ManagementApproval;
            destination.CxcApproval = source.CxcApproval;
            destination.CreateDate = source.CreateDate;
            destination.ContingenciesRate = source.ContingenciesRate;
            destination.GuaranteeRate = source.GuaranteeRate;
            destination.TotalUtilityRate = source.TotalUtilityRate;
            destination.DiscountRate = source.DiscountRate;
            destination.SalesTax = source.SalesTax;
            destination.OthersRate = source.OthersRate;
            destination.Comments = source.Comments;

            destination.taskList = loadTasks(source.Tasks);
        }

        private void mapper(ProjectData source, Nexus.Project destination)
        {
            destination.Id = source.Id;
            destination.BudgetRequestId = source.BudgetRequestId;
            destination.CustumerId = source.CustumerId;
            destination.EmployeeId = source.EmployeeId;
            destination.Name = source.Name;
            destination.ManagementApproval = source.ManagementApproval;
            destination.CxcApproval = source.CxcApproval;
            destination.CreateDate = source.CreateDate;
            destination.ContingenciesRate = source.ContingenciesRate;
            destination.GuaranteeRate = source.GuaranteeRate;
            destination.TotalUtilityRate = source.TotalUtilityRate;
            destination.DiscountRate = source.DiscountRate;
            destination.SalesTax = source.SalesTax;
            destination.OthersRate = source.OthersRate;
            destination.Comments = source.Comments;
        }

        #endregion

        #region Loads Methods

        /// <summary>
        /// Este método se encarga de cargar las dependecias de las tareas que se van cargando, es recursivo junto al 
        /// mapper de esta clase para mapear las mismas dependencias.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private List<TaskData> loadDependencies(Nexus.Task t)
        {
            List<TaskData> dependencies = new List<TaskData>();

            dependencies = loadTasks(t.Task1);

            return dependencies;
        }

        /// <summary>
        /// Este método se encarga de obtener la lista de recursos de una tarea
        /// </summary>
        /// <param name="t">Tarea de la cual se va a extraer la lista de recursos</param>
        /// <returns>La lista de recursos de la tarea</returns>
        private List<ResourceData> loadResources(Nexus.Task t)
        {
            List<ResourceData> resources = new List<ResourceData>();

            foreach(Nexus.Resource r in t.Resources)
            {
                ResourceData rd = new ResourceData();
                mapper(r, rd);
                resources.Add(rd);
            }

            return resources;
        }

        /// <summary>
        /// Este método se encarga de cargar las tareas desde Nexus a una lista de TaskData
        /// </summary>
        /// <param name="tasks">Lista de tareas de Nexus de tipo Task</param>
        /// <returns>Lista de tareas de tipo TaskData</returns>
        private List<TaskData> loadTasks(System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks)
        {
            List<TaskData> listTask = new List<TaskData>();

            if (tasks != null)
            {
                foreach (Nexus.Task task in tasks)
                {
                    TaskData tmpTask = new TaskData();
                    mapper(task, tmpTask);
                    listTask.Add(tmpTask);
                }
            }

            return listTask;
        }
        
        /// <summary>
        /// Este método se encarga de cargar los proyectos desde Nexus a una lista de ProjectData
        /// </summary>
        /// <param name="projectFounded">Lista de proyectos de tipo Project</param>
        /// <returns>Lista de proyectos de tipo ProjectData</returns>
        private List<ProjectData> loadProjects(List<Nexus.Project> projectFounded)
        {
            List<ProjectData> ProjectList = new List<ProjectData>();

            if (projectFounded != null)
            {
                foreach (var project in projectFounded)
                {
                    ProjectData tmpProjectData = new ProjectData();
                    mapper(project, tmpProjectData);
                    ProjectList.Add(tmpProjectData);
                }
            }


            return ProjectList;
        }

        #endregion

        #region Saves Methods

        private void saveResources(List<ResourceData> resources, Nexus.Task task)
        {
            foreach (ResourceData rd in resources)
            {
                Nexus.Resource resource = Olympus._Enterprise.Resources.Where(x => x.Id == rd.Id).SingleOrDefault();
                if (resource != null)
                {
                    mapper(rd, resource);
                }
                else
                {
                    Nexus.Resource r = new Nexus.Resource();
                    mapper(rd, r);
                    Olympus._Enterprise.AddToResources(r);
                }
            }
        }

        private void saveTasks(List<TaskData> tasks, Nexus.Project projectFound)
        {
            foreach (TaskData t in tasks.OrderBy(x => x.RowNumber))
            {
                Nexus.Task task = Olympus._Enterprise.Tasks.Where(y => y.ProjectId == t.ProjectId).Where(x => x.Id == t.Id).SingleOrDefault();

                if (task != null)
                {
                    mapper(t, task);
                    //******************************************************************************************************************
                    if (t.resourceList != null)
                    {
                        saveResources(t.resourceList, task);
                    }
                    //******************************************************************************************************************
                }
                else
                {
                    Olympus._Enterprise.AddToTasks(task);
                }
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Este método se encarga de buscar el siguinte código de proyecto
        /// </summary>
        /// <returns>Código de proyecto siguiente</returns>
        public int nextCode()
        {
            int code = Olympus._Enterprise.Projects.Max(x => x.Id) + 1;

            return code;
        }

        /// <summary>
        /// Este método se encarga de buscar los proyectos en la Base de Datos
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ProjectResponse searchProject(ProjectRequest request)
        {
            const int maximunResultRows = 20;

            var response = new ProjectResponse();

            // Inicitialize the list of customers
            response.ProjectList = new List<ProjectData>();

            //var projectFoundedById = Olympus._Enterprise.Projects.Where(x => x.Id.Contains(request.SearchProjectQuery)).OrderBy(y => y.Id).Take(maximunResultRows).ToList();
            var projectFoundByName = Olympus._Enterprise.Projects.Where(x => x.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            var projectFoundByCustumer = Olympus._Enterprise.Projects.Where(x => x.Customer.Name.ToUpper().Contains(request.SearchProjectQuery.ToUpper())).OrderBy(y => y.Customer.Name).Take(maximunResultRows).ToList();

            response.ProjectList.AddRange(loadProjects(projectFoundByName));
            response.ProjectList.AddRange(loadProjects(projectFoundByCustumer));

            return response;
        }

        /// <summary>
        /// Método que se encarga de acomodar y guardar un projecto
        /// </summary>
        /// <param name="request">Objeto donde viene el proyecto a ser almacenado en BD</param>
        public void saveProject(ProjectRequest request)
        {
            // Validate if the project exist
            Nexus.Project projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();

            //Si el proyecto existe se actualiza el mismo, si no existe se crea uno nuevo
            if (projectFound != null)
            {
                mapper(request.Project, projectFound);
                if (request.Project.taskList != null)
                {
                    saveTasks(request.Project.taskList, projectFound);
                }
            }
            else
            {
                Nexus.Project newProject = new Nexus.Project();
                mapper(request.Project, newProject);
                Olympus._Enterprise.AddToProjects(newProject);
            }
            
            Olympus._Enterprise.SaveChanges();
        }

        #endregion






        #region BASURA

        ///ESTE METODO NO SE ESTA UTILIZANDO
        /// <summary>
        /// Método que se encarga de crear una lista de Nexus.Task que sera almacenada en la BD
        /// </summary>
        /// <param name="taskList">Origen de las tareas</param>
        /// <returns>Lista con las tareas a ser almacenadas en la BD</returns>
        private System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> loadTask(List<TaskData> taskList)
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

        /// ESTE METODO NO SE ESTA UTILIZANDO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        private void saveResources(Nexus.Task task)
        {
            foreach (Nexus.Resource r in task.Resources)
            {
                Nexus.Resource resource = Olympus._Enterprise.Resources.Where(x => x.Id == r.Id).SingleOrDefault();
                if (resource != null)
                {
                    mapper(r, resource);
                }
                else
                {
                    Olympus._Enterprise.AddToResources(resource);
                }
            }
        }

        /// ESTE METODO NO SE ESTA UTILIZANDO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        private void mapper(Nexus.Task source, Nexus.Task destination)
        {
            destination.ProjectId = source.ProjectId;
            destination.Id = source.Id;

            destination.Name = source.Name;
            destination.Duration = source.Duration;
            destination.PercentComplete = source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.DeadLine = source.DeadLine;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
            destination.RowNumber = source.RowNumber;
            destination.TaskLevel = source.TaskLevel;
        }

        #endregion
    }
}
