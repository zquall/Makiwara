using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class ItemRequest
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string SearchItemQuery { get; set; }
        public ItemDto Item{ get; set; }
    }
}
