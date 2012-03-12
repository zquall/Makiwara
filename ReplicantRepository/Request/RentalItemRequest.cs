using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class RentalItemRequest
    {
        public int RentalItemId { get; set; }
        public string SearchRentalItemQuery { get; set; }
        public RentalItemDto RentalItem{ get; set; }
    }
}
