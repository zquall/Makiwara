using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
