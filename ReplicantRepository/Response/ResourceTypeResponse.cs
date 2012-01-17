using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class ResourceTypeResponse
    {
        public List<ResourceTypeData> ResourceTypeList { get; set; }
    }

    public class ResourceTypeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTaxed { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
