using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class MeasureService
    {
        public MeasureResponse SearchMeasure(MeasureRequest request)
        {
            var response = new MeasureResponse {MeasureList = new List<MeasureDto>()};

            var measureFound = Olympus._Enterprise.Measures.ToList();

            //if (measureFound != null)
            if (measureFound.Count() > 0)
            {
                foreach (var measure in measureFound)
                {
                    Olympus._Enterprise.Detach(measure);
                    var tmpMeasure = Mapper.Map<MeasureDto>(measure);
                    response.MeasureList.Add(tmpMeasure);
                }
            }
            return response;
        }
    }
}