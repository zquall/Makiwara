using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class RentalItemService : ServiceBase
    {
        private readonly ItemAdapter _rentalItemAdapter;

        public RentalItemService()
        {
            _rentalItemAdapter = new ItemAdapter();
        }

        // Search Item
        public RentalItemResponse SearchItem(RentalItemRequest request)
        {
            var response = new RentalItemResponse { RentalItemList = new List<RentalItemDto>() };

            #region Search function not used by now
            // Search item
            //var itemsFound = Olympus._Enterprise.Items.Where(x => x.Name.Contains(request.SearchItemQuery) || 
            //                 x.Code.Contains(request.SearchItemQuery))
            //                 .OrderBy(y => y.Name)
            //                 .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
            //                 .Distinct()
            //                 .ToList();

            //if (itemsFound.Count > 0)
            //{
            //    response.ItemList = Mapper.Map<List<ItemDto>>(itemsFound);
            //} 
            #endregion

            // Intercepted Method
            _itemAdapter.SearchItem(request, response);

            // Sorted again the list
            response.ItemList = response.ItemList.OrderBy(x => x.Name).ToList();
            
            return response;
        }

        // Get Item
        public ItemResponse GetItem(ItemRequest request)
        {
            var response = new ItemResponse();
           
            #region *** Intercepted Method ***
            // Try to add item from AlienDB to Nexus if the item already exist then try to refresh the information
            if (request.ItemId == 0)
            {
                request.ItemId = SaveItem(new ItemRequest { Item = _itemAdapter.GetItem(request).Item }).ItemId;
            }            
            #endregion

            // Validate if the item is from Nexus
            if (request.ItemId > 0) 
            {
                var itemFound = Olympus._Enterprise.Items.Where(x => x.Id == request.ItemId).SingleOrDefault();
                response.Item = Mapper.Map<ItemDto>(itemFound);
            }
            return response;
        }

        // Save Item
        public ItemResponse SaveItem(ItemRequest request)
        {
            var response = new ItemResponse();

            if (request.Item != null)
            {
                Item item = null;
                // Check if Edit or Add
                if (request.Item.Id > 0)
                {
                    // Edit
                    item = Olympus._Enterprise.Items.Where(x => x.Id == request.Item.Id).SingleOrDefault();
                    Mapper.Map(request.Item, item);
                }
                else
                {
                    // Add
                    if (request.Item.Code != null)
                    {
                        // Check some info from AlienDB
                        item = new Item();
                        Mapper.Map(request.Item, item);
                        Olympus._Enterprise.Items.AddObject(item);
                    }
                }
                Olympus._Enterprise.SaveChanges();
                if (item!= null) response.ItemId = item.Id; 
            }
            return response;
        }
    }
}
