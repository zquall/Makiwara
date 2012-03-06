using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ProjectStateFactory
    {
        private static ProjectStateService _projectStateService;

        public ProjectStateFactory()
        {
            _projectStateService = _projectStateService ?? new ProjectStateService();
        }

        public ProjectStateResponse GetProjectState(ProjectStateRequest request)
        {
            return _projectStateService.GetProjectState(request);
        }

        public ProjectStateResponse SearchProjectState(ProjectStateRequest request)
        {
            return _projectStateService.SearchProjectState(request);
        }
    }
}
