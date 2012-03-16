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
    public class ItemAdapter
    {

        public ItemAdapter()
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
                // Check if the item is already binded
                var bindedItem = response.ItemList.Where(x => x.Code == item.INV_Codigo).FirstOrDefault();
                if (bindedItem == null)
                {
                    // Add item to response
                    var itemDto = new ItemDto
                    {
                        Code = item.INV_Codigo.Trim(),
                        Name = item.INV_Nombre.Trim(),
                        Cost = item.INV_Costo,
                        Price = new decimal(item.INV_Precio),
                        Stocks = new Collection<StockDto>()
                    };
                    // Todo Give a real value of the quantity in stocks
                    itemDto.Stocks.Add(new StockDto { Quantity = item.INV_Disponible });
                    response.ItemList.Add(itemDto);
                }
                else
                {
                    // Update item in response
                    bindedItem.Name = item.INV_Nombre.Trim();
                    bindedItem.Cost = item.INV_Costo;
                    bindedItem.Stocks = new Collection<StockDto>();
                    bindedItem.Stocks.Add(new StockDto { Quantity = item.INV_Disponible });
                }
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
                        response.Item = new ItemDto
                                            {
                                                Id = request.ItemId,
                                                Name = bindedItemFound.INV_Nombre.Trim(),
                                                Cost = bindedItemFound.INV_Costo,
                                                Price = Convert.ToDecimal(bindedItemFound.INV_Precio),
                                                IsTaxed = Convert.ToBoolean(bindedItemFound.INV_Con_Imp_Ventas),
                                                DateModified = DateTime.Now,
                                                WasDeleted = false,
                                                Stocks = new Collection<StockDto>()
                                            };
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
