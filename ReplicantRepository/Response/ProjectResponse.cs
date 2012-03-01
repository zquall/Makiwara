using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class ProjectResponse
    {
        public int ProjectId { get; set; }
        public ProjectDto Project { get; set; }
        public List<ProjectDto> ProjectList { get; set; }
    }
}
