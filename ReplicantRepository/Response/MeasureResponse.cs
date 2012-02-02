using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class MeasureResponse
    {
        public List<MeasureDto> MeasureList { get; set; }
    }
}
