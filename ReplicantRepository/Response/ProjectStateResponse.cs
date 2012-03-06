using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class ProjectStateResponse
    {
        public int ProjectStateId { get; set; }
        public ProjectStateDto ProjectState { get; set; }
        public List<ProjectStateDto> ProjectStateList { get; set; }
    }
}
