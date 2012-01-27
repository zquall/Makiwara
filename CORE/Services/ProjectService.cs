using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;

namespace CORE.Services
{
    public class ProjectService
    {
        public ProjectService()
        {
        }

        #region Loads Methods


        
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
                    MapperOld.mapper(project, tmpProjectData);
                    ProjectList.Add(tmpProjectData);
                }
            }


            return ProjectList;
        }

        #endregion
       
        #region Saves Methods

        private void saveDependencies(List<TaskData> dependencies, Nexus.Task task)
        { 
        }

        private void deleteResources(Nexus.Task task)
        {
            Nexus.Task t = Olympus._Enterprise.Tasks.Where(x => x.ProjectId == task.ProjectId & x.Id == task.Id).SingleOrDefault();

            List<Nexus.Resource> delete = new List<Nexus.Resource>();
            delete = task.Resources.ToList();
            foreach (Nexus.Resource r in delete)
            {
                Olympus._Enterprise.Resources.DeleteObject(r);
            }
        }

        private void saveResources(List<ResourceData> resources, Nexus.Task task)
        {
           // deleteResources(task);

            foreach (ResourceData rd in resources)
            {
                Nexus.Resource resource = Olympus._Enterprise.Resources.Where(x => x.Id == rd.Id).SingleOrDefault();
                //Nexus.Resource resource = task.Resources.Where(x => x.Id == rd.Id).SingleOrDefault();
                
                if (resource != null)
                {
                    MapperOld.mapper(rd, resource);
                }
                else
                {
                    Nexus.Resource r = new Nexus.Resource();
                    MapperOld.mapper(rd, r);
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
                    MapperOld.mapper(t, task);
                    //******************************************************************************************************************
                    if (t.resourceList != null)
                    {
                        saveResources(t.resourceList, task);
                    }
                    //******************************************************************************************************************
                }
                else
                {
                    task = new Nexus.Task();
                    MapperOld.mapper(t, task);
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
            var response = new ProjectResponse();
            // Inicitialize the list of customers
            response.ProjectList = new List<ProjectData>();
            var projectListFound = Olympus._Enterprise.Projects.Where(
                x => x.Name.Contains(request.SearchProjectQuery) ||
                     x.Customer.Name.Contains(request.SearchProjectQuery))                     
                     .OrderBy(y => y.Id)
                     .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                     .ToList();

            response.ProjectList.AddRange(loadProjects(projectListFound));

            return response;
        }

        /// <summary>
        /// Método que se encarga de acomodar y guardar un projecto
        /// </summary>
        /// <param name="request">Objeto donde viene el proyecto a ser almacenado en BD</param>
        public ProjectResponse saveProject(ProjectRequest request)
        {
            ProjectResponse response = new ProjectResponse(); //--

            // Validate if the project exist
            Nexus.Project projectFound = Olympus._Enterprise.Projects.Where(x => x.Id == request.Project.Id).SingleOrDefault();

            //Si el proyecto existe se actualiza el mismo, si no existe se crea uno nuevo
            if (projectFound != null)
            {
                MapperOld.mapper(request.Project, projectFound);
                if (request.Project.taskList != null)
                    saveTasks(request.Project.taskList, projectFound);
            }
            else
            {
                Nexus.Project newProject = new Nexus.Project();
                MapperOld.mapper(request.Project, newProject);
                Olympus._Enterprise.AddToProjects(newProject);
            }
            Olympus._Enterprise.SaveChanges();
            response.Project = request.Project;

            return response;
        }

        #endregion
    }
}
