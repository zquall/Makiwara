using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class ProjectStateRequest
    {
        public int ProjectStateId { get; set; }
        public string SearchProjectStateQuery { get; set; }
        public StateDto ProjectState { get; set; }
    }
}
