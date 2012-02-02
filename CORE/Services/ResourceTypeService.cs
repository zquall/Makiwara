using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;
using AutoMapper;

namespace CORE.Services
{
    public class ResourceTypeService
    {
        //private void mapper(Nexus.ResourceType source, ResourceTypeData destination)
        //{
        //    destination.Id = source.Id;
        //    destination.Name = source.Name;
        //    destination.IsTaxed = source.IsTaxed;
        //}

        public ResourceTypeResponse searchResourceType(ResourceTypeRequest request)
        {
            var response = new ResourceTypeResponse();

            response.ResourceTypeList = new List<ResourceTypeDto>();
            var resourceTypeFound = Olympus._Enterprise.ResourceTypes.ToList();

            if (resourceTypeFound != null)
            {
                foreach (var resourceType in resourceTypeFound)
                {
                    Olympus._Enterprise.Detach(resourceType);
                    ResourceTypeDto tmpResourceType = Mapper.Map<ResourceTypeDto>(resourceType);
                    response.ResourceTypeList.Add(tmpResourceType);
                }
            }
            return response;
        }
    }
}
