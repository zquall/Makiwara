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

        /// <summary>
        /// Searches all projects state in the database
        /// </summary>
        /// <param name="request">Project State request with search parameters</param>
        /// <returns>Project State response with list of projects state</returns>
        public List<StateDto> GetStateList()
        {
            List<StateDto> stateList = new List<StateDto>();

            var statesFound = Olympus._Enterprise.States
                                            .OrderBy(y => y.Name)
                                            .ToList();

            foreach (var state in statesFound)
            {
                var tmpProjectState = Mapper.Map<StateDto>(state);
                stateList.Add(tmpProjectState);
            }
            return stateList;
        }
    }
}
