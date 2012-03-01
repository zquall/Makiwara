using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class ItemResponse
    {
        public int ItemId { get; set; }
        public ItemDto Item { get; set; }
        public List<ItemDto> ItemList { get; set; }
    } 
}
