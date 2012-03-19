using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class EmployeeRequest
    {
        public int EmployeeId { get; set; }
        public string SearchEmployeeQuery { get; set; }
        public EmployeeDto Employee { get; set; }
    }
}
