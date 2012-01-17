using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class ResourceTypeRequest
    {
        public string SearchResourceTypeQuery { get; set; }
        public ResourceTypeData ResourceType { get; set; }
    }
}
