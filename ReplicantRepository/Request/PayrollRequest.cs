using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class PayrollRequest
    {
        public int PayrollId { get; set; }
        public string PayrollCode { get; set; }
        public string SearchPayrollQuery { get; set; }
        //public PayrollDto Payroll { get; set; }
    }
}
