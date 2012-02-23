using System;
using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;
using AutoMapper;
using Nexus;

namespace CORE.Services
{
    public class ProjectService
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
        /// Delete all the resources and then put again in the task entity
        /// </summary>
        /// <param name="resources">The list of resources that will be added to the task entity</param>
        /// <param name="task">Task entity that contains the resources</param>
        private void SaveResources(IEnumerable<ResourceDto> resources, Task task)
        {
            if (task.Resources.Count > 0)
            {
                DeleteAllResources(task);
            }

            foreach (var rd in resources)
            {
                var resourceEntity = Mapper.Map<ResourceDto, Resource>(rd);
                Olympus._Enterprise.Resources.AddObject(resourceEntity);
            }
        }

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

        #region Public Zone

        /// <summary>
        /// Get the next project code
        /// </summary>
        /// <returns>Code of the next project</returns>
        public int NextCode()
        {
            int code = Olympus._Enterprise.Projects.Max(x => x.Id) + 1;

            return code;
        }

        /// <summary>
        /// Get one specific Project
        /// </summary>
        /// <param name="request">The project request</param>
        /// <returns>The project response</returns>
        public ProjectResponse  GetProject(ProjectRequest request)
        {
            var response = new ProjectResponse();
            if (request.Project.Id != 0)
            {
                var projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();
                if (projectFound != null)
                {
                    response.Project = MapperPaths.Map(projectFound);
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
                                             x.Customer.Name.Contains(request.SearchProjectQuery))
                                      .OrderBy(y => y.Name)
                                      .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                                      .ToList();

            foreach (var project in projectsFound)
            {
                var tmpResourceType = Mapper.Map<ProjectDto>(project);
                response.ProjectList.Add(tmpResourceType);
            }
            return response;
        }

        /// <summary>
        /// Método que se encarga de acomodar y guardar un projecto
        /// </summary>
        /// <param name="request">Objeto donde viene el proyecto a ser almacenado en BD</param>
        public ProjectResponse SaveProject(ProjectRequest request)
        {
            var response = new ProjectResponse();
            var projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();

            if (projectFound != null)
            {
                Mapper.Map(request.Project, projectFound);
                if (request.Project.Tasks != null)
                    SaveTasks(request.Project.Tasks, projectFound);
            }
            else
            {
                var newProject = Mapper.Map<Project>(request.Project);
                Olympus._Enterprise.AddToProjects(newProject);
            }
            Olympus._Enterprise.SaveChanges();
            response.Project = request.Project;

            return response;
        }

        #endregion
    }
}
