using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class BudgetRequestRequest
    {
        public int? BudgetResquestId { get; set; }
        public int? EmployeeId { get; set; }
        public string ResquestQuery { get; set; }
    }

}
