using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class CustomerResponse
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public CustomerDto Customer { get; set; }
        public CustomerContactDto CustomerContact { get; set; }
        public List<CustomerContactDto> CustomerContacts { get; set; }
        public List<CustomerData> CustomerList { get; set; }
    } 
}
