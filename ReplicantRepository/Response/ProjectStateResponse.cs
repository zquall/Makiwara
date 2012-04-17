using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class ProjectStateResponse
    {
        public int ProjectStateId { get; set; }
        public StateDto ProjectState { get; set; }
        public List<StateDto> ProjectStateList { get; set; }
    }
}
