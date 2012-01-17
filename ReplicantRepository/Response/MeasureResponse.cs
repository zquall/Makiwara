using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class MeasureResponse
    {
        public List<MeasureData> MeasureList { get; set; }
    }

    public class MeasureData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
