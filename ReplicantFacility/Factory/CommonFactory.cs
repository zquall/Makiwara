using CORE.Services;
using ReplicantRepository.Response;

namespace ReplicantFacility.Factory
{
    public class CommonFactory
    {
        private static CommonService _commonService;

        public CommonFactory()
        {
            _commonService = _commonService ?? new CommonService();
        }

        public CommonObjectsResponse GetPhoneTypeList()
        {
            var commonObjectsResponse = new CommonObjectsResponse {PhoneTypeList = _commonService.getPhoneTypeList()};
            return commonObjectsResponse;
        }

        public CommonObjectsResponse GetMeasureList()
        {
            var commonObjectsResponse = new CommonObjectsResponse {MeasureList = _commonService.getMeasureList()};
            return commonObjectsResponse;
        }


        public CommonObjectsResponse GetStateList()
        {
            var commonObjectsResponse = new CommonObjectsResponse { StateList = _commonService.GetStateList() };
            return commonObjectsResponse;
        }

    }
}
