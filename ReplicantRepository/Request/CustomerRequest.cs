using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class CustomerRequest
    {
        public CustomerData Customer { get; set; }
        public string SearchCustomerQuery { get; set; }
        public ContactData Contact { get; set; }
    }

}
