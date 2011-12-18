using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class PhoneData
    {
        public PhoneData()
        {
            PhoneType = new PhoneTypeData();
        }
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneTypeData PhoneType { get; set; }
    }
}
