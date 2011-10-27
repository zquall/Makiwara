using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class BudgetRequestResponse
    {
        public int? Id { get; set; }
        public DateTime DateModified { get; set; }
        public string EmployeeName { get; set; }
        public CustomerData Customer { get; set; }
    }
}
