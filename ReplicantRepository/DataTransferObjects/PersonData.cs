using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class PersonData
    {
        public PersonData()
        {
            PhoneList = new List<PhoneData>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return Name + " " + LastName; } }
        public List<PhoneData> PhoneList { get; set; }
    } 
}
