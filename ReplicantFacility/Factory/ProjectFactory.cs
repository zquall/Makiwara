using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ProjectFactory
    {
        private static ProjectService _projectService;

        public ProjectFactory()
        {
            _projectService = _projectService ?? new ProjectService();
        }

        public ProjectResponse GetProject(ProjectRequest request)
        {
            return _projectService.GetProject(request);
        }

        public ProjectResponse GetProjectByCode(ProjectRequest request)
        {
            return _projectService.GetProjectByCode(request);
        }

        public ProjectResponse SearchProject(ProjectRequest request)
        {
            return _projectService.SearchProject(request);
        }

        public ProjectResponse SaveProject(ProjectRequest request)
        {
            return _projectService.SaveProject(request);
        }

        public ProjectResponse CopyProject(ProjectRequest request)
        {
            return _projectService.CopyProject(request);
        }

        public ProjectResponse GetActiveProjects()
        {
            return _projectService.GetActiveProjects();
        }

        public string NextCode()
        {
            return _projectService.NextCode();
        }
    }
}
