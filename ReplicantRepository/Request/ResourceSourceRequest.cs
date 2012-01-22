using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class ResourceSourceRequest
    {
        public string SearchResourceSourceQuery { get; set; }
        public string SearchResourceSourceType { get; set; }
        public ResourceSourceData ResourceSource { get; set; }
    }
}
