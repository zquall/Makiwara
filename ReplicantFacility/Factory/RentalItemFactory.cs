using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class RentalItemFactory
    {
        private static RentalItemService _rentalItemService;

        public RentalItemFactory()
        {
            _rentalItemService = _rentalItemService ?? new RentalItemService();
        }

        // Search
        public RentalItemResponse SearchRentalItem(RentalItemRequest request)
        {
            return _rentalItemService.SearchRentalItem(request);
        }

        // Get
        public RentalItemResponse GetRentalItem(RentalItemRequest request)
        {
            return _rentalItemService.GetRentalItem(request);
        }

        // Save
        public RentalItemResponse SaveRentalItem(RentalItemRequest request)
        {
            return _rentalItemService.SaveRentalItem(request);
        }
    }
}
