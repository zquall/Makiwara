using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class CustomerRequest
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string SearchCustomerQuery { get; set; }
        public ContactData Contact { get; set; }
    }

}
