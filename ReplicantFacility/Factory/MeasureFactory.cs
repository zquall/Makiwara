using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class MeasureFactory
    {
        private static MeasureService _MeasureService;

        public MeasureFactory()
        {
            _MeasureService = _MeasureService ?? new MeasureService();
        }

        public MeasureResponse searchMeasure(MeasureRequest request)
        {
            return _MeasureService.searchMeasure(request);
        }
    }
}
