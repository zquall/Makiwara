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
                var rentealItemDto = new RentalItemDto
                                  {
                                      Code = rentalItem.INV_Codigo.Trim(),
                                      Name = rentalItem.INV_Nombre.Trim(),
                                      Cost = new decimal(rentalItem.INV_Costo),
                                      Price = new decimal(rentalItem.INV_Precio),
                                      MonthlyPrice = new decimal(rentalItem.INV_Precio_Mes),
                                      FortnightPrice = new decimal(rentalItem.INV_Precio_Quincena),
                                      WeeklyPrice = new decimal(rentalItem.INV_Precio_Semana),
                                      DailyPrice = new decimal(rentalItem.INV_Precio_Dia),
                                      MaximunDiscount = 0,
                                      FamilyId = 0,
                                      Storages = new Collection<StorageDto>()
                                  };
                rentealItemDto.Storages.Add(new StorageDto { Available = Convert.ToDecimal(rentalItem.INV_Disponible),
                                                             Quantity = Convert.ToDecimal(rentalItem.INV_Existencia),
                });
                response.RentalItemList.Add(rentealItemDto);
            }
        }

        // Get Item from Alien DB
        public RentalItemResponse GetItem(RentalItemRequest request)
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
                        response.RentalItem.Code = bindedItemFound.INV_Codigo.Trim();
                        response.RentalItem.Name = bindedItemFound.INV_Nombre.Trim();
                        response.RentalItem.Cost = new decimal(bindedItemFound.INV_Costo);
                        response.RentalItem.Price = new decimal(bindedItemFound.INV_Precio);
                        response.RentalItem.MonthlyPrice = new decimal(bindedItemFound.INV_Precio_Mes);
                        response.RentalItem.FortnightPrice = new decimal(bindedItemFound.INV_Precio_Quincena);
                        response.RentalItem.WeeklyPrice = new decimal(bindedItemFound.INV_Precio_Semana);
                        response.RentalItem.DailyPrice = new decimal(bindedItemFound.INV_Precio_Dia);
                        response.RentalItem.MaximunDiscount = 0;
                        response.RentalItem.FamilyId = 0;
                        response.RentalItem.IsTaxed = Convert.ToBoolean(bindedItemFound.INV_Con_Imp_Ventas);
                        //response.RentalItem.DateCreated = DateTime.Now,
                        response.RentalItem.DateModified = DateTime.Now;
                        response.RentalItem.WasDeleted = false;
                        response.RentalItem.Storages = new Collection<StorageDto>();
                        // get the stocks by Warehouse
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
                                                Cost = new decimal(itemFound.INV_Costo),
                                                Price = new decimal(itemFound.INV_Precio),
                                                MonthlyPrice = new decimal(itemFound.INV_Precio_Mes),
                                                FortnightPrice = new decimal(itemFound.INV_Precio_Quincena),
                                                WeeklyPrice = new decimal(itemFound.INV_Precio_Semana),
                                                DailyPrice = new decimal(itemFound.INV_Precio_Dia),
                                                MaximunDiscount = 0,
                                                FamilyId = 0,
                                                IsTaxed = Convert.ToBoolean(itemFound.INV_Con_Imp_Ventas),
                                                DateCreated = DateTime.Now,
                                                DateModified = DateTime.Now,
                                                WasDeleted = false,
                                                Storages = new Collection<StorageDto>()
                                            };
                        // get the storage by Warehouse
                    } 
                    #endregion
                } 
            }
            return response;
        }
    }
}
