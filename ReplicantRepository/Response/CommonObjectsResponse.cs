using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    // This repository is just for list of common objects that came from DB like types of something

    public class CommonObjectsResponse
    {
        public List<PhoneTypeData> PhoneTypeList { get; set; }
    }
    

}
