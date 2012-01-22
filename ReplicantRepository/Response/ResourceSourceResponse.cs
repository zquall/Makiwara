using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class ResourceSourceResponse
    {
        public List<ResourceSourceData> ResourceSourceList { get; set; }
    }

    public class ResourceSourceData
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string RType { get; set; }
        public double Cost { get; set; }
        public bool Taxed { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
