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
