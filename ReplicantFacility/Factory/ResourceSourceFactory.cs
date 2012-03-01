using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;

namespace ReplicantFacility.Factory
{
    public class ResourceSourceFactory
    {
        private static ResourceSourceAdapter _resourceSourceAdapter;

        public ResourceSourceFactory()
        {
            _resourceSourceAdapter = _resourceSourceAdapter ?? new ResourceSourceAdapter();
        }

        public ResourceSourceResponse SearchResourceSource(ResourceSourceRequest request)
        {
            return _resourceSourceAdapter.searchResourceSource(request);
        }
    }
}
