using System;
using System.Collections.ObjectModel;
using System.Linq;
using Interceptor.Properties;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class PayrollAdapter
    {

        // Add aditional results to the search
        public void Search(PayrollRequest request, PayrollResponse response)
        {
            var maximunResultRows = Convert.ToInt32(Resources.MaximunSearchResults);

            // Apply the search with the pattern given
            //var searchResults = Asgard._Foreing.INV_INVENTARIO
            //    .Where(x => x.INV_Nombre.ToUpper().Contains(request.SearchItemQuery.ToUpper()) ||
            //                x.INV_Codigo.ToUpper().Contains(request.SearchItemQuery.ToUpper()))
            //                .OrderBy(y => y.INV_Nombre)
            //                .Take(maximunResultRows).ToList();

            var searchResults = Asgard._Foreing.PLA_EMPLEADOS
                .Where(x => x.EMP_Nombre.ToUpper().Contains(request.SearchPayrollQuery.ToUpper()))
                .OrderBy(y => y.EMP_Nombre)
                .Take(maximunResultRows).ToList();

            // Fill the response with the result found
            ////foreach (var item in searchResults)
            ////{
            ////    var itemDto = new ItemDto
            ////    {
            ////        Code = item.INV_Codigo.Trim(),
            ////        Name = item.INV_Nombre.Trim(),
            ////        Cost = item.INV_Costo,
            ////        Price = Convert.ToDecimal(item.INV_Precio),
            ////        Stocks = new Collection<StockDto>()
            ////    };
            ////    itemDto.Stocks.Add(new StockDto { Quantity = item.INV_Disponible });
            ////    response.ItemList.Add(itemDto);
            ////}
        }
    }
}
