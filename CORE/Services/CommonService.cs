using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class CommonService
    {
        public CommonService()
        {
        }

        public List<PhoneTypeDto> getPhoneTypeList()
        {
            List<PhoneTypeDto> phoneTypeList = new List<PhoneTypeDto>();
            foreach (var tmpPhoneType in Olympus._Enterprise.PhoneTypes.ToList())
	        {
                PhoneTypeDto phoneType = new PhoneTypeDto();
                phoneType.Id = tmpPhoneType.Id;
                phoneType.Name = tmpPhoneType.Name;
                phoneTypeList.Add(phoneType);
	        }            
            return phoneTypeList;
        }
    }
}
