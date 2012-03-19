using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class RentalItemResponse
    {
        public int RentalItemId { get; set; }
        public RentalItemDto RentalItem { get; set; }
        public List<RentalItemDto> RentalItemList { get; set; }
    }
}
