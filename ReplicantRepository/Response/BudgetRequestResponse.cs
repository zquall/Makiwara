using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class BudgetRequestResponse
    {
        public BudgetRequestData BudgetRequest { get; set; }
        public List<BudgetRequestData> BudgetRequestList { get; set; }
    }
    public class BudgetRequestData
    {
        public int? Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateModified { get; set; }
        public EmployeeData Employee { get; set; }
        public CustomerData Customer { get; set; }
    }
}
