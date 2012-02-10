using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public ProjectService()
        {
        }

        #region Delete Zone

        /// <summary>
        /// Deletes all the resources of a task
        /// </summary>
        /// <param name="task">Task that contains the resources to eliminate</param>
        private void deleteAllResources(Task task)
        {
            Task t = Olympus._Enterprise.Tasks.Where(x => x.ProjectId == task.ProjectId & x.Id == task.Id).SingleOrDefault();

            List<Resource> delete = new List<Resource>();
            delete = task.Resources.ToList();
            foreach (Resource r in delete)
            {
                Olympus._Enterprise.Resources.DeleteObject(r);
            }
        }

        /// <summary>
        /// Delete a project task
        /// </summary>
        private void deleteAllTasks(Project project)
        {
            Project p = Olympus._Enterprise.Projects.Where(x => x.Id == project.Id).SingleOrDefault();

            List<Task> delete = new List<Task>();
            delete = project.Tasks.OrderByDescending(x => x.RowNumber).ToList();
            foreach (Task t in delete)
            {
                t.Task1.Clear();
                deleteAllResources(t);
                Olympus._Enterprise.Tasks.DeleteObject(t);
            }
        }

        #endregion

        #region Save Zone

        /// <summary>
        /// Save the resources of a task
        /// </summary>
        /// <param name="resources">List of tasks to be stored</param>
        /// <param name="task">Task where the resources will be stored</param>
        private void saveResources(List<ResourceDto> resources, Task task)
        {
            if (task.Resources.Count > 0)
            {
                deleteAllResources(task);
            }

            foreach (ResourceDto rd in resources)
            {
                Nexus.Resource r = new Nexus.Resource();
                Mapper.Map<ResourceDto, Resource>(rd, r);
                Olympus._Enterprise.Resources.AddObject(r);
            }
        }

        private void saveTasks(ICollection<TaskDto> tasks, Project projectFound)
        {
            if (projectFound.Tasks.Count > 0)
            {
                deleteAllTasks(projectFound);
            }

            Olympus._Enterprise.SaveChanges();

            foreach (TaskDto tmpTask in tasks.OrderBy(x => x.RowNumber))
            {
                //if (tmpTask.Tasks.Count == 0)
                //{
                    var taskEntity = Mapper.Map<TaskDto, Task>(tmpTask);
                    Olympus._Enterprise.Tasks.AddObject(taskEntity);
                //}
            }
        }

        #endregion

        #region Public Zone

        // Get one specific Project
        public ProjectResponse  getProject(ProjectRequest request)
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
            var response = new ProjectResponse();

            response.ProjectList = new List<ProjectDto>();
            var projectFound = Olympus._Enterprise.Projects
                                      .Where(x => x.Name.Contains(request.SearchProjectQuery) ||
                                             x.Customer.Name.Contains(request.SearchProjectQuery))
                                      .OrderBy(y => y.Name)
                                      .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                                      .ToList();

            if (projectFound != null)
            {
                foreach (var project in projectFound)
                {
                    Olympus._Enterprise.Detach(project);
                    ProjectDto tmpResourceType = Mapper.Map<ProjectDto>(project);
                    response.ProjectList.Add(tmpResourceType);
                }
            }
            return response;
        }

        /// <summary>
        /// Método que se encarga de acomodar y guardar un projecto
        /// </summary>
        /// <param name="request">Objeto donde viene el proyecto a ser almacenado en BD</param>
        public ProjectResponse saveProject(ProjectRequest request)
        {
            ProjectResponse response = new ProjectResponse();

            // Validate if the project exist
            Project projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();

            if (projectFound != null)
            {
                if (request.Project.Tasks != null)
                    saveTasks(request.Project.Tasks, projectFound);
            }
            else
            {
                Project newProject = new Project();
                newProject = Mapper.Map<Project>(request.Project);
                Olympus._Enterprise.AddToProjects(newProject);
            }
            Olympus._Enterprise.SaveChanges();
            response.Project = request.Project;

            return response;
        }

        #endregion
    }
}
