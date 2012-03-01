using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class MeasureRequest
    {
        public string SearchMeasureQuery { get; set; }
        public MeasureDto Measure { get; set; }
    }
}
