using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ResourceTypeFactory
    {
        private static ResourceTypeService _ResourceTypeService;

        public ResourceTypeFactory()
        {
            _ResourceTypeService = _ResourceTypeService ?? new ResourceTypeService();
        }

        public ResourceTypeResponse searchResourceType(ResourceTypeRequest request)
        {
            return _ResourceTypeService.searchResourceType(request);
        }
    }
}
