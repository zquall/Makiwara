using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    class ResourceResponse
    {
        public int? Id { get; set; }
        public int MeasureId { get; set; }
        public int ResourceTypeId { get; set; }
        public int TaskId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public double Cost { get; set; }
        public double TotalCost { get; set; }
        public float RealUsed { get; set; }
    }
}
