using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class BudgetRequestResponse
    {
        public BudgetRequestResponse()
        {
            BudgetRequest = new BudgetRequestData();
            BudgetRequestList = new List<BudgetRequestData>();
        }
        public BudgetRequestData BudgetRequest { get; set; }
        public List<BudgetRequestData> BudgetRequestList { get; set; }
    }

}
