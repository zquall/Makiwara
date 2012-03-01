using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interceptor.DataBase;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class ResourceSourceAdapter
    {
        private void mapper(Interceptor.DataBase.INV_INVENTARIO source, ResourceSourceData destination)
        {
            //destination.Code = source.Code;
            //destination.Name = source.Name;
            //destination.Balance = source.Balance;
            //destination.RType = source.RType;
            //destination.Cost = source.Cost;

            //if (source.Taxed == 0)
            //    destination.Taxed = false;
            //else
            //    destination.Taxed = true;
        }

        private void loadResourceSource(IEnumerable<INV_INVENTARIO> source, List<ResourceSourceData> destination)
        {
            if (source != null)
            {
                foreach (var resourceSource in source)
                {
                    ResourceSourceData tmpResourceSourceData = new ResourceSourceData();
                    mapper(resourceSource, tmpResourceSourceData);

                    //Se aplica filtro para agregar unicamente elementos que no han sido agregados
                    if (destination.Count(x => x.Code == tmpResourceSourceData.Code) <= 0)
                        destination.Add(tmpResourceSourceData);
                }
            }
        }

        public ResourceSourceResponse searchResourceSource(ResourceSourceRequest request)
        {
            const int maximunResultRows = 50;

            var response = new ResourceSourceResponse();
            List<ResourceSourceData> ResourceSourceFound = new List<ResourceSourceData>();

            // Inicitialize the list of resources
            response.ResourceSourceList = new List<ResourceSourceData>();

            var ResourceSourceFoundByCode = Asgard._Foreing.INV_INVENTARIO.Where(x => x.INV_Codigo.ToUpper().Contains(request.SearchResourceSourceQuery.ToUpper())).OrderBy(y => y.INV_Codigo).Take(maximunResultRows).ToList();
            var ResourceSourceFoundByName = Asgard._Foreing.INV_INVENTARIO.Where(x => x.INV_Nombre.ToUpper().Contains(request.SearchResourceSourceQuery.ToUpper())).OrderBy(y => y.INV_Codigo).Take(maximunResultRows).ToList();
            
            loadResourceSource(ResourceSourceFoundByCode, ResourceSourceFound);
            loadResourceSource(ResourceSourceFoundByName, ResourceSourceFound);

            response.ResourceSourceList.AddRange(ResourceSourceFound);

            return response;
        }
    }
}
