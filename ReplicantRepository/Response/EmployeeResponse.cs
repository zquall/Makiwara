using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class EmployeeResponse
    {
        public EmployeeData Employee { get; set; }
        public List<EmployeeData> EmployeeList { get; set; }        
    }

    public class EmployeeData
    {
        public int Id { get; set; }
        public PersonData Person { get; set; }
    }   
}
