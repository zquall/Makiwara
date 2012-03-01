using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ResourceTypeFactory
    {
        private static ResourceTypeService _resourceTypeService;

        public ResourceTypeFactory()
        {
            _resourceTypeService = _resourceTypeService ?? new ResourceTypeService();
        }

        public ResourceTypeResponse SearchResourceType(ResourceTypeRequest request)
        {
            return _resourceTypeService.SearchResourceType(request);
        }
    }
}
