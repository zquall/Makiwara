using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class CustomerResponse
    {
        public CustomerData Customer { get; set; }
        public List<CustomerData> CustomerList { get; set; }        
    } 
}
