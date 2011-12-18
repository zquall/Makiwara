using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class BudgetRequestData
    {
        public BudgetRequestData()
        {
            Employee = new EmployeeData();
            Customer = new CustomerData();
        }
        public int? Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateModified { get; set; }
        public EmployeeData Employee { get; set; }
        public CustomerData Customer { get; set; }
    }
}
