using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;

namespace ReplicantFacility.Factory
{
    public class ResourceSourceFactory
    {
        private static ResourceSourceAdapter _ResourceSourceAdapter;

        public ResourceSourceFactory()
        {
            _ResourceSourceAdapter = _ResourceSourceAdapter ?? new ResourceSourceAdapter();
        }

        public ResourceSourceResponse searchResourceSource(ResourceSourceRequest request)
        {
            return _ResourceSourceAdapter.searchResourceSource(request);
        }
    }
}
