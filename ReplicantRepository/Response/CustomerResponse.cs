using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class CustomerResponse
    {
        public int CustomerId { get; set; }
        public int CustomerContactId { get; set; }
        public CustomerDto Customer { get; set; }
        public CustomerContactDto CustomerContact { get; set; }
        public List<CustomerContactDto> CustomerContacts { get; set; }
        public List<CustomerDto> CustomerList { get; set; }
    } 
}
