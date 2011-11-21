using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class CommonFactory
    {
        private static CommonService _CommonService;

        public CommonFactory()
        {
            _CommonService = _CommonService ?? new CommonService();
        }

        public CommonObjectsResponse getPhoneTypeList()
        {
            CommonObjectsResponse commonObjectsResponse = new CommonObjectsResponse();
            commonObjectsResponse.PhoneTypeList = _CommonService.getPhoneTypeList();
            return commonObjectsResponse;
        }
    }
}
