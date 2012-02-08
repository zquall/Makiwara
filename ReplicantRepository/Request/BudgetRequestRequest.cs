using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class BudgetRequestRequest
    {
        public int? BudgetResquestId { get; set; }
        public int? EmployeeId { get; set; }
        public string ResquestQuery { get; set; }
        public BudgetRequestDto BudgetRequest { get; set; }
    }

}
