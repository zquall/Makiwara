using Nexus;
using System;
using AutoMapper;
using System.Linq;
using Interceptor.Adapters;
using System.Collections.Generic;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class ProjectService : ServiceBase
    {
        #region Delete Zone

        /// <summary>
        /// Deletes all the resources of one task
        /// </summary>
        /// <param name="task">Task that contains the resources to eliminate</param>
        private static void DeleteAllResources(Task task)
        {
            var delete = task.Resources.ToList();
            foreach (var r in delete)
            {
                Olympus._Enterprise.Resources.DeleteObject(r);
            }
        }

        /// <summary>
        /// Delete a project task
        /// </summary>
        private static void DeleteAllTasks(Project project)
        {
            var delete = project.Tasks.OrderByDescending(x => x.RowNumber).ToList();
            foreach (var t in delete)
            {
                t.Task1.Clear();
                DeleteAllResources(t);
                Olympus._Enterprise.Tasks.DeleteObject(t);
            }
        }

        #endregion

        #region Save Zone

        /// <summary>
        /// Delete all the tasks and then put again in the project entity
        /// </summary>
        /// <param name="tasks">The collection of tasks that will be added to the project entity</param>
        /// <param name="projectFound">Project entity that contains the tasks</param>
        private static void SaveTasks(IEnumerable<TaskDto> tasks, Project projectFound)
        {
            if (projectFound.Tasks.Count > 0)
            {
                DeleteAllTasks(projectFound);
            }

            foreach (var tmpTask in tasks.OrderBy(x => x.RowNumber))
            {
                var taskEntity = Mapper.Map<TaskDto, Task>(tmpTask);
                Olympus._Enterprise.Tasks.AddObject(taskEntity);
            }
        }

        #endregion

        #region Copy Zone

        private void GetListOfTask(ICollection<TaskDto> source, ICollection<TaskDto> destination)
        {
            foreach(var tmpTask in source)
            {
                destination.Add(tmpTask);
                if (tmpTask.Tasks.Count > 0) GetListOfTask(tmpTask.Tasks, destination);
            }
        }

        private ProjectDto CopyProject(ProjectDto project)
        {
            var tasks = new List<TaskDto>();
            var tmpProject = Mapper.Map<ProjectDto, ProjectDto>(project);

            GetListOfTask(project.Tasks, tasks);
            tmpProject.Tasks.Clear();

            tmpProject.Tasks = tasks;
            return tmpProject;
            //return Mapper.Map<ProjectDto, ProjectDto>(project);
        }

        #endregion 

        #region Public Zone

        /// <summary>
        /// Get the next project code
        /// </summary>
        /// <returns>Code of the next project</returns>
        public string NextCode()
        {
            var year = DateTime.Today.Year.ToString();

            var month = DateTime.Today.Month.ToString();
            if (month.Length <= 1)
                month = "0" + month;

            var code = Olympus._Enterprise.Projects.Max(x => x.Code);
            code = code.Trim();

            if ((code.Substring(4, 2) == month) && (code.Substring(0, 4) == year))
                code = (int.Parse(code.Substring(6)) + 1).ToString();
            else
                code = "001";

            if (code.Length <= 1)
                code = "00" + code;

            return year + month + code;
        }

        /// <summary>
        /// Get one specific Project
        /// </summary>
        /// <param name="request">The project request</param>
        /// <returns>The project response</returns>
        public ProjectResponse  GetProject(ProjectRequest request)
        {
            var response = new ProjectResponse();
            if (request.ProjectId > 0)
            {
                var projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.ProjectId).SingleOrDefault();
                if (projectFound != null)
                {
                    //response.Project = MapperPaths.Map(projectFound);
                    response.Project = Mapper.Map<ProjectDto>(projectFound);
                }
            }
            return response;
        }

        /// <summary>
        /// Searches all projects in the database
        /// </summary>
        /// <param name="request">Project request with search parameters</param>
        /// <returns>Project response with list of projects</returns>
        public ProjectResponse SearchProject(ProjectRequest request)
        {
            var response = new ProjectResponse {ProjectList = new List<ProjectDto>()};

            var projectsFound = Olympus._Enterprise.Projects
                                      .Where(x => x.Name.Contains(request.SearchProjectQuery) ||
                                                  x.Customer.Name.Contains(request.SearchProjectQuery) ||
                                                  x.Code.Contains(request.SearchProjectQuery) &&
                                                  x.StateId == 1)
                                      .OrderBy(y => y.Code)
                                      .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                                      .ToList();

            foreach (var project in projectsFound)
            {
                var tmpResourceType = Mapper.Map<ProjectDto>(project);
                response.ProjectList.Add(tmpResourceType);
            }
            return response;
        }

        public ProjectResponse SaveProject(ProjectRequest request)
        {
            var budgetAdapter = new BudgetAdapter();
            budgetAdapter.SaveBudget(request);

            var response = new ProjectResponse();
            
            if (request.Project != null)
            {
                Project project = null;
                // Check if Edit or Add
                if (request.Project.Id > 0)
                {   // Edit
                    project = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();
                    Mapper.Map(request.Project, project);
                    if (request.Project.Tasks != null)
                        SaveTasks(request.Project.Tasks, project);
                }
                else
                {   // Add
                    if (request.Project.Code != null)
                    {
                        // Check some info from AlienDB
                        project = new Project();
                        Mapper.Map(request.Project, project);
                        if (request.Project.Tasks != null)
                            SaveTasks(request.Project.Tasks, project);
                        Olympus._Enterprise.Projects.AddObject(project);
                    }
                }
                Olympus._Enterprise.SaveChanges();
                if (project != null) response.ProjectId = project.Id;
            }
            return response;
        }

        public ProjectResponse CopyProject(ProjectRequest request)
        {
            var response = new ProjectResponse {Project = CopyProject(request.Project)};

            return response;
        }

        // Get Project Inform list
        public ProjectResponse GetActiveProjects()
        {
            var response = new ProjectResponse { ProjectList = new List<ProjectDto>() };

            // Search active project informs
            var projectsFound = Olympus._Enterprise.Projects.Where(x => x.StateId == (int)EnumCatalog.State.Active)
                             .OrderByDescending(y => y.Code)
                             .ToList();
            if (projectsFound.Count > 0)
            {
                // Detach all childs before mapping to avoid 
                // sending not needed data on the request
                foreach (var project in projectsFound)
                {
                    Olympus._Enterprise.Detach(project);
                }
                response.ProjectList = Mapper.Map<List<Project>, List<ProjectDto>>(projectsFound);
            }
            return response;
        }

        #endregion


    }
}
