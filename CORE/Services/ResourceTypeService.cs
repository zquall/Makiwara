using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace CORE.Services
{
    public class ResourceTypeService
    {
        private void mapper(Nexus.ResourceType source, ResourceTypeData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }

        private List<ResourceTypeData> loadResourceTypes(List<Nexus.ResourceType> resourceTypeFound)
        {
            List<ResourceTypeData> ResourceTypeList = new List<ResourceTypeData>();

            if (resourceTypeFound != null)
            {
                foreach (Nexus.ResourceType resourceType in resourceTypeFound)
                {
                    ResourceTypeData tmpResourceTypeData = new ResourceTypeData();
                    mapper(resourceType, tmpResourceTypeData);
                    ResourceTypeList.Add(tmpResourceTypeData);
                }
            }


            return ResourceTypeList;
        }

        public ResourceTypeResponse searchResourceType(ResourceTypeRequest request)
        {
            var response = new ResourceTypeResponse();

            //// Inicitialize the list of resourse types
            response.ResourceTypeList = new List<ResourceTypeData>();

            var resourceTypeFound = Olympus._Enterprise.ResourceTypes.ToList();

            response.ResourceTypeList.AddRange(loadResourceTypes(resourceTypeFound));

            return response;
        }
    }
}
