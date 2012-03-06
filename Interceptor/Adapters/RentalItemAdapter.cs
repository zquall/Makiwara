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
        public void SearchItem(ItemRequest request, ItemResponse response)
        {
            var maximunResultRows = Convert.ToInt32(Resources.MaximunSearchResults);

            // Apply the search with the pattern given
            var searchResults = Asgard._Foreing.INV_INVENTARIO
                .Where(x => x.INV_Nombre.ToUpper().Contains(request.SearchItemQuery.ToUpper()) || 
                            x.INV_Codigo.ToUpper().Contains(request.SearchItemQuery.ToUpper()))
                            .OrderBy(y => y.INV_Nombre)
                            .Take(maximunResultRows).ToList();
            
            // Fill the response with the result found
            foreach (var item in searchResults)
            {
                var itemDto = new ItemDto
                                  {
                                      Code = item.INV_Codigo.Trim(),
                                      Name = item.INV_Nombre.Trim(),
                                      Cost = item.INV_Costo,
                                      Price = Convert.ToDecimal(item.INV_Precio),
                                      Stocks = new Collection<StockDto>()
                                  };
                itemDto.Stocks.Add(new StockDto { Quantity = item.INV_Disponible });
                response.ItemList.Add(itemDto);
            }
        }

        // Get Item
        public ItemRequest GetItem(ItemRequest request)
        {
            var response = new ItemRequest();
            if (request.Item != null)
            {
                // Check for update an item
                if (request.ItemId > 0)
                {
                    // Search the item to update data
                    var bindedItemFound = Asgard._Foreing.INV_INVENTARIO
                        .Where(x => x.INV_Codigo.ToUpper() == request.Item.Code.ToUpper())
                        .FirstOrDefault();

                    if (bindedItemFound != null)
                    {
                        response.Item.Name = bindedItemFound.INV_Nombre.Trim();
                        response.Item.Cost = bindedItemFound.INV_Costo;
                        response.Item.Price = Convert.ToDecimal(bindedItemFound.INV_Precio);
                        response.Item.IsTaxed = Convert.ToBoolean(bindedItemFound.INV_Con_Imp_Ventas);
                        response.Item.DateModified = DateTime.Now;
                        response.Item.WasDeleted = false;
                        response.Item.Stocks = new Collection<StockDto>();
                        // get the stocks by Warehouse
                    }
                }
                else
                {
                     // Search the item
                    var itemFound = Asgard._Foreing.INV_INVENTARIO.Where(x => x.INV_Codigo.ToUpper() == request.Item.Code.ToUpper()).
                            FirstOrDefault();
                    if (itemFound != null)
                    {
                        response.Item = new ItemDto
                                            {
                                                Code = itemFound.INV_Codigo.Trim(),
                                                Name = itemFound.INV_Nombre.Trim(),
                                                Cost = itemFound.INV_Costo,
                                                Price = Convert.ToDecimal(itemFound.INV_Precio),
                                                IsTaxed = Convert.ToBoolean(itemFound.INV_Con_Imp_Ventas),
                                                DateCreated = DateTime.Now,
                                                DateModified = DateTime.Now,
                                                MaximunDiscount = Convert.ToInt32(itemFound.INV_Porce_Desc_Max),
                                                WasDeleted = false,
                                                Stocks = new Collection<StockDto>()
                                            };
                        // get the stocks by Warehouse
                    }
                } 
            }
            return response;
        }
    }
}
