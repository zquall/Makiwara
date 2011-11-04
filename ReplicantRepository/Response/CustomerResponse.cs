using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class CustomerResponse
    {
        public CustomerData Customer { get; set; }
        public List<CustomerData> CustomerList { get; set; }        
    }

    public class CustomerData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
