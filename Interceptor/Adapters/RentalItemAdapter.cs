using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Interceptor.Properties;
using ReplicantRepository.Response;
using Interceptor.DataBase;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class RentalItemAdapter
    {
        public RentalItemAdapter()
        {

        }

        // Add aditional results to the search
        public void SearchRentalItem(RentalItemRequest request, RentalItemResponse response)
        {
            var maximunResultRows = Convert.ToInt32(Resources.MaximunSearchResults);

            // Apply the search with the pattern given
            var searchResults = Asgard._Foreing.ALQ_INVENTARIO
                .Where(x => x.INV_Nombre.ToUpper().Contains(request.SearchRentalItemQuery.ToUpper()) ||
                            x.INV_Codigo.ToUpper().Contains(request.SearchRentalItemQuery.ToUpper()))
                            .OrderBy(y => y.INV_Nombre)
                            .Take(maximunResultRows).ToList();
            
            // Fill the response with the result found
            foreach (var rentalItem in searchResults)
            {
                // Check if the rentalItem is already binded
                var bindedRentalItem = response.RentalItemList.Where(x => x.Code == rentalItem.INV_Codigo).FirstOrDefault();
                if (bindedRentalItem == null)
                {
                    var rentealItemDto = new RentalItemDto
                    {
                        Code = rentalItem.INV_Codigo.Trim(),
                        Name = rentalItem.INV_Nombre.Trim(),
                        Cost = Convert.ToDecimal(rentalItem.INV_Costo),
                        Price = Convert.ToDecimal(rentalItem.INV_Precio),
                        MonthlyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Mes),
                        FortnightPrice = Convert.ToDecimal(rentalItem.INV_Precio_Quincena),
                        WeeklyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Semana),
                        DailyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Dia),
                        MaximunDiscount = 0,
                        FamilyId = 0,
                        Storages = new Collection<StorageDto>()
                    };
                    rentealItemDto.Storages.Add(new StorageDto
                    {
                        Available = Convert.ToDecimal(rentalItem.INV_Disponible),
                        Quantity = Convert.ToDecimal(rentalItem.INV_Existencia),
                    });
                    response.RentalItemList.Add(rentealItemDto);
                }
                else
                {
                    bindedRentalItem.Name = rentalItem.INV_Nombre.Trim();
                    bindedRentalItem.Cost = Convert.ToDecimal(rentalItem.INV_Costo);
                    bindedRentalItem.Price = Convert.ToDecimal(rentalItem.INV_Precio);
                    bindedRentalItem.MonthlyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Mes);
                    bindedRentalItem.FortnightPrice = Convert.ToDecimal(rentalItem.INV_Precio_Quincena);
                    bindedRentalItem.WeeklyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Semana);
                    bindedRentalItem.DailyPrice = Convert.ToDecimal(rentalItem.INV_Precio_Dia);
                    bindedRentalItem.MaximunDiscount = 0;
                    bindedRentalItem.FamilyId = 0;
                    bindedRentalItem.Storages = new Collection<StorageDto>();
                }
              
            }
        }

        // Get Item from Alien DB
        public RentalItemResponse GetRentalItem(RentalItemRequest request)
        {
            var response = new RentalItemResponse();
            if (request.RentalItem != null)
            {
                // Check for update an item
                if (request.RentalItemId > 0)
                {
                    #region Update Data
                    // Search the item to update data
                    var bindedItemFound = Asgard._Foreing.ALQ_INVENTARIO
                        .Where(x => x.INV_Codigo.ToUpper() == request.RentalItem.Code.ToUpper())
                        .FirstOrDefault();

                    if (bindedItemFound != null)
                    {
                        // Create an object to be mapped later
                        response.RentalItem = new RentalItemDto
                                                  {
                                                      Id = request.RentalItemId,
                                                      Code = bindedItemFound.INV_Codigo.Trim(),
                                                      Name = bindedItemFound.INV_Nombre.Trim(),
                                                      Cost = Convert.ToDecimal(bindedItemFound.INV_Costo),
                                                      Price = Convert.ToDecimal(bindedItemFound.INV_Precio),
                                                      MonthlyPrice = Convert.ToDecimal(bindedItemFound.INV_Precio_Mes),
                                                      FortnightPrice = Convert.ToDecimal(bindedItemFound.INV_Precio_Quincena),
                                                      WeeklyPrice = Convert.ToDecimal(bindedItemFound.INV_Precio_Semana),
                                                      DailyPrice = Convert.ToDecimal(bindedItemFound.INV_Precio_Dia),
                                                      MaximunDiscount = 0,
                                                      FamilyId = 0,
                                                      IsTaxed = Convert.ToBoolean(bindedItemFound.INV_Con_Imp_Ventas),
                                                      DateModified = DateTime.Now,
                                                      WasDeleted = false
                                                  };
                        // get the stocks by Warehouse missing
                    } 
                    #endregion
                }
                else
                {
                    #region Get Item
                    // Search the item
                    var itemFound = Asgard._Foreing.ALQ_INVENTARIO.Where(x => x.INV_Codigo.ToUpper() == request.RentalItem.Code.ToUpper()).
                            FirstOrDefault();
                    if (itemFound != null)
                    {
                        response.RentalItem = new RentalItemDto
                                            {
                                                Code = itemFound.INV_Codigo.Trim(),
                                                Name = itemFound.INV_Nombre.Trim(),
                                                Cost = Convert.ToDecimal(itemFound.INV_Costo),
                                                Price = Convert.ToDecimal(itemFound.INV_Precio),
                                                MonthlyPrice = Convert.ToDecimal(itemFound.INV_Precio_Mes),
                                                FortnightPrice = Convert.ToDecimal(itemFound.INV_Precio_Quincena),
                                                WeeklyPrice = Convert.ToDecimal(itemFound.INV_Precio_Semana),
                                                DailyPrice = Convert.ToDecimal(itemFound.INV_Precio_Dia),
                                                MaximunDiscount = 0,
                                                FamilyId = 0,
                                                IsTaxed = Convert.ToBoolean(itemFound.INV_Con_Imp_Ventas),
                                                DateCreated = DateTime.Now,
                                                DateModified = DateTime.Now,
                                                WasDeleted = false
                                            };
                        // get the storage by Warehouse missing
                    } 
                    #endregion
                } 
            }
            return response;
        }
    }
}
