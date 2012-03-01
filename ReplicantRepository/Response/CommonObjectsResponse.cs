using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    // This repository is just for list of common objects that came from DB like types of something

    public class CommonObjectsResponse
    {
        public List<PhoneTypeDto> PhoneTypeList { get; set; }
        public List<MeasureDto> MeasureList { get; set; }
    }
    

}
