using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class MeasureRequest
    {
        public string SearchMeasureQuery { get; set; }
        public MeasureData Measure { get; set; }
    }
}
