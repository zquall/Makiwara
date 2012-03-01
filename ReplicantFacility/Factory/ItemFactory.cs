using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class ItemFactory
    {
        private static ItemService _itemService;

        public ItemFactory()
        {
            _itemService = _itemService ?? new ItemService();
        }

        // Search
        public ItemResponse SearchItem(ItemRequest request)
        {
            return _itemService.SearchItem(request);
        }

        // Get
        public ItemResponse GetItem(ItemRequest request)
        {
            return _itemService.GetItem(request);
        }

        // Save
        public ItemResponse SaveItem(ItemRequest request)
        {
            return _itemService.SaveItem(request);
        }
    }
}
