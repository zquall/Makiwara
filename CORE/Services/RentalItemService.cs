using System;
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
        private readonly RentalItemAdapter _rentalItemAdapter;

        public RentalItemService()
        {
            _rentalItemAdapter = new RentalItemAdapter();
        }

        // Search Item
        public RentalItemResponse SearchRentalItem(RentalItemRequest request)
        {
            var response = new RentalItemResponse { RentalItemList = new List<RentalItemDto>() };

            #region Search function not used by now
            // Search item
            var itemsFound = Olympus._Enterprise.Items.Where(x => x.Name.Contains(request.SearchRentalItemQuery) ||
                             x.Code.Contains(request.SearchRentalItemQuery))
                             .OrderBy(y => y.Name)
                             .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                             .Distinct()
                             .ToList();

            if (itemsFound.Count > 0)
            {
                response.RentalItemList = Mapper.Map<List<RentalItemDto>>(itemsFound);
            } 
            #endregion

            // Intercepted Method
            _rentalItemAdapter.SearchRentalItem(request, response);

            // Sorted again the list
            response.RentalItemList = response.RentalItemList.OrderBy(x => x.Name).ToList();
            
            return response;
        }

        // Get Item
        public RentalItemResponse GetRentalItem(RentalItemRequest request)
        {
            var response = new RentalItemResponse();
           
            #region *** Intercepted Method ***
            // Try to add item from AlienDB to Nexus if the item already exist then try to refresh the information
            if (request.RentalItemId == 0)
            {
                request.RentalItemId = SaveItem(new RentalItemRequest { RentalItem = _rentalItemAdapter.GetItem(request).RentalItem }).RentalItemId;
            }            
            #endregion

            // Validate if the item is from Nexus
            if (request.RentalItemId > 0) 
            {
                var itemFound = Olympus._Enterprise.RentalItems.Where(x => x.Id == request.RentalItemId).SingleOrDefault();
                response.RentalItem = Mapper.Map<RentalItemDto>(itemFound);
            }
            return response;
        }

        // Save Item
        public RentalItemResponse SaveRentalItem(RentalItemRequest request)
        {
            var response = new RentalItemResponse();

            if (request.RentalItem != null)
            {
                RentalItem rentalItem = null;
                // Check if Edit or Add
                if (request.RentalItem.Id > 0)
                {
                    // Edit
                    rentalItem = Olympus._Enterprise.RentalItems.Where(x => x.Id == request.RentalItem.Id).SingleOrDefault();
                    Mapper.Map(request.RentalItem, rentalItem);
                }
                else
                {
                    // Add
                    if (request.RentalItem.Code != null)
                    {
                        // Check some info from AlienDB
                        rentalItem = new RentalItem();
                        Mapper.Map(request.RentalItem, rentalItem);
                        Olympus._Enterprise.RentalItems.AddObject(rentalItem);
                    }
                }
                Olympus._Enterprise.SaveChanges();
                if (rentalItem != null) response.RentalItemId = rentalItem.Id; 
            }
            return response;
        }
    }
}
