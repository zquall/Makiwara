using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class MeasureFactory
    {
        private static MeasureService _measureService;

        public MeasureFactory()
        {
            _measureService = _measureService ?? new MeasureService();
        }

        public MeasureResponse SearchMeasure(MeasureRequest request)
        {
            return _measureService.searchMeasure(request);
        }
    }
}
