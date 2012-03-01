using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
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
