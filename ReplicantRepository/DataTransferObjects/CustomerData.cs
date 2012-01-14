using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class CustomerData
    {
        public CustomerData()
        {
            ContactList = new List<ContactData>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressOptional { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public List<ContactData> ContactList { get; set; }
    } 
}
