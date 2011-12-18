using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class EmployeeData
    {
        public EmployeeData()
        {
            Person = new PersonData();
        }
        public int Id { get; set; }
        public PersonData Person { get; set; }
    }   
}
