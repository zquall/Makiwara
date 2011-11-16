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
        public List<ContactData> ContactList { get; set; }
    }

    public class ContactData
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public PersonData Person { get; set; }
        public List<PhoneData> PhoneList { get; set; }
    }

    public class PersonData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<PhoneData> PhoneList { get; set; }
    }    

    public class PhoneData
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneType { get; set; }
    }

}
