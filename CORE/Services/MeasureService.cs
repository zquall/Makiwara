using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;
using AutoMapper;
using Nexus;

namespace CORE.Services
{
    public class MeasureService
    {
        public MeasureResponse SearchMeasure(MeasureRequest request)
        {
            var response = new MeasureResponse();

            response.MeasureList = new List<MeasureDto>();
            var measureFound = Olympus._Enterprise.Measures.ToList();

            if (measureFound != null)
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