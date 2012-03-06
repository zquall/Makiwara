using System;
using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class ProjectStateService
    {

        /// <summary>
        /// Get one specific Project State
        /// </summary>
        /// <param name="request">The project state request</param>
        /// <returns>The project state response</returns>
        public ProjectStateResponse GetProjectState(ProjectStateRequest request)
        {
            var response = new ProjectStateResponse();
            if (request.ProjectStateId > 0)
            {
                var projectStateFound = Olympus._Enterprise.ProjectStates.Where(x => x.Id == request.ProjectStateId).SingleOrDefault();
                if (projectStateFound != null)
                {
                    response.ProjectState = Mapper.Map<ProjectStateDto>(projectStateFound);
                }
            }
            return response;
        }

        /// <summary>
        /// Searches all projects state in the database
        /// </summary>
        /// <param name="request">Project State request with search parameters</param>
        /// <returns>Project State response with list of projects state</returns>
        public ProjectStateResponse SearchProjectState(ProjectStateRequest request)
        {
            var response = new ProjectStateResponse { ProjectStateList = new List<ProjectStateDto>() };

            var projectsStateFound = Olympus._Enterprise.ProjectStates
                                            .Where(x => x.Name.Contains(request.SearchProjectStateQuery))
                                            .OrderBy(y => y.Name)
                                            .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                                            .ToList();

            foreach (var projectState in projectsStateFound)
            {
                var tmpProjectState = Mapper.Map<ProjectStateDto>(projectState);
                response.ProjectStateList.Add(tmpProjectState);
            }
            return response;
        }
    }
}
