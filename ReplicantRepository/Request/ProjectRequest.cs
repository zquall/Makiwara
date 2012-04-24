using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class ProjectRequest
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string SearchProjectQuery { get; set; }
        public ProjectDto Project { get; set; }
    }
}
