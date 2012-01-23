using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class BudgetRequestResponse
    {
        public BudgetRequestDto BudgetRequest { get; set; }
        public List<BudgetRequestDto> BudgetRequestList { get; set; }
    }

}
