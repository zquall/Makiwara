using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class ResourceTypeService
    {
        public ResourceTypeResponse SearchResourceType(ResourceTypeRequest request)
        {
            var response = new ResourceTypeResponse {ResourceTypeList = new List<ResourceTypeDto>()};

            var resourceTypeFound = Olympus._Enterprise.ResourceTypes.ToList();

            if (resourceTypeFound != null)
            {
                foreach (var resourceType in resourceTypeFound)
                {
                    Olympus._Enterprise.Detach(resourceType);
                    var tmpResourceType = Mapper.Map<ResourceTypeDto>(resourceType);
                    response.ResourceTypeList.Add(tmpResourceType);
                }
            }
            return response;
        }
    }
}
