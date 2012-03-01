using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class CustomerRequest
    {
        public int CustomerId { get; set; }
        public int CustomerContactId { get; set; }
        public string SearchCustomerQuery { get; set; }
        public CustomerDto Customer { get; set; }
        public CustomerContactDto CustomerContact { get; set; }
    }
}
