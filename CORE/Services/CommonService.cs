using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class CommonService
    {
        public CommonService()
        {
        }

        public List<PhoneTypeData> getPhoneTypeList()
        {
            List<PhoneTypeData> phoneTypeList = new List<PhoneTypeData>();
            foreach (var phoneType in Olympus._Enterprise.PhoneTypes.ToList())
	        {
                PhoneTypeData phoneTypeData = new PhoneTypeData();
                phoneTypeData.Id = phoneType.Id;
                phoneTypeData.Name = phoneType.Name;
                phoneTypeList.Add(phoneTypeData);
	        }            
            return phoneTypeList;
        }
    }
}
