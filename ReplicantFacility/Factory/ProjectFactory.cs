using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ProjectFactory
    {
        private static ProjectService _ProjectService;

        public ProjectFactory()
        {
            _ProjectService = _ProjectService ?? new ProjectService();
        }

        public ProjectResponse searchProject(ProjectRequest request)
        {
            return _ProjectService.searchProject(request);
        }

        public void saveProject(ProjectRequest request)
        {
            _ProjectService.saveProject(request);
        }

        public int nextCode()
        {
            return _ProjectService.nextCode();
        }
    }
}
