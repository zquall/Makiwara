using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class ContactData
    {
        public ContactData()
        {
            Person = new PersonData();
        }
        public int Id { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public PersonData Person { get; set; }
        public override string ToString()
        {
            return Person.Name + " " + Person.LastName;
        }
    }
}
