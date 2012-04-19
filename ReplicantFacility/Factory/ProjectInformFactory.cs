using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ProjectInformFactory
    {
        private static ProjectInformService _projectInformService;

        public ProjectInformFactory()
        {
            _projectInformService = _projectInformService ?? new ProjectInformService();
        }

        // Get Pending Projects
        public ProjectInformResponse GetPendingProjectInform(ProjectInformRequest request)
        {
            return _projectInformService.GetPendingProjectInform(request);
        }
    }
}
