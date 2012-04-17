using System;
using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class ProjectInformService : ServiceBase
    {
        //private readonly ItemAdapter _itemAdapter;

        public ProjectInformService()
        {
            //_itemAdapter = new ItemAdapter();
        }

        // Search Item
        public ProjectInformResponse GetPendingProjectInform(ProjectInformRequest request)
        {
            var response = new ProjectInformResponse { ProjectInformList = new List<ProjectInformDto>() };

          
            // Search pending project informs
            var informsFound = Olympus._Enterprise.ProjectInforms.Where(x => x.UserId == request.EmployeeId &&
                             x.StateId == 1 && x.WasDeleted == false)
                             .OrderByDescending(y => y.DateModified)
                             .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                             .Distinct()
                             .ToList();

            if (informsFound.Count > 0)
            {
                response.ProjectInformList = Mapper.Map<List<ProjectInformDto>>(informsFound);
            } 
            return response;
        }
        
    }
}
