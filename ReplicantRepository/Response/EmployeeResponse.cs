using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class EmployeeResponse
    {
        public EmployeeDto Employee { get; set; }
        public List<EmployeeDto> EmployeeList { get; set; }        
    }


}
