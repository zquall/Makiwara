using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class EmployeeResponse
    {
        public EmployeeDto Employee { get; set; }
        public List<EmployeeDto> EmployeeList { get; set; }        
    }


}
