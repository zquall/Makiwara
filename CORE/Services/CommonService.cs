using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;
using Nexus;

namespace CORE.Services
{
    public class CommonService : ServiceBase
    {
        public CommonService()
        {
        }

        public List<PhoneTypeDto> getPhoneTypeList()
        {
            List<PhoneTypeDto> phoneTypeList = new List<PhoneTypeDto>();
            foreach (var tmpPhoneType in Olympus._Enterprise.PhoneTypes.ToList())
	        {
                Olympus._Enterprise.Detach(tmpPhoneType);
                phoneTypeList.Add( Mapper.Map<PhoneType, PhoneTypeDto>(tmpPhoneType));
	        }            
            return phoneTypeList;
        }

        public List<MeasureDto> getMeasureList()
        {
            List<MeasureDto> measureList = new List<MeasureDto>();
            foreach (var tmpMeasure in Olympus._Enterprise.Measures.ToList())
            {
                Olympus._Enterprise.Detach(tmpMeasure);
                measureList.Add(Mapper.Map<MeasureDto>(tmpMeasure));
            }
            return measureList;
        }
    }
}
