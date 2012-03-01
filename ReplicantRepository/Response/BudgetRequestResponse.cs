using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class BudgetRequestResponse
    {
        public int BudgetRequestId { get; set; }
        public BudgetRequestDto BudgetRequest { get; set; }
        public List<BudgetRequestDto> BudgetRequestList { get; set; }
    }

}
