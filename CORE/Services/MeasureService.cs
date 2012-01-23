using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class MeasureService
    {
        private void mapper(Nexus.Measure source, MeasureData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }

        private List<MeasureData> loadMeasure(List<Nexus.Measure> measureFound)
        {
            List<MeasureData> MeasureList = new List<MeasureData>();

            if (measureFound != null)
            {
                foreach (Nexus.Measure measure in measureFound)
                {
                    MeasureData tmpMeasureData = new MeasureData();
                    mapper(measure, tmpMeasureData);
                    MeasureList.Add(tmpMeasureData);
                }
            }


            return MeasureList;
        }

        public MeasureResponse searchMeasure(MeasureRequest request)
        {
            var response = new MeasureResponse();

            // Inicitialize the list of measures
            response.MeasureList = new List<MeasureData>();

            var measureFound = Olympus._Enterprise.Measures.ToList();

            response.MeasureList.AddRange(loadMeasure(measureFound));

            return response;
        }
    }
}
