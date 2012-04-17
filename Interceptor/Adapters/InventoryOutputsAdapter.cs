using System.Linq;
using System.Collections.Generic;
using ReplicantRepository.Request;
using ReplicantRepository.Response;
using Interceptor.DataBase;

namespace Interceptor.Adapters
{
    class InventoryOutputsAdapter
    {
        public List<SAL_SALIDAS> GetInventoryOutputs(string code)
        {
            var inventoryOutputs = new List<SAL_SALIDAS>();

            if (code != "")
            {
                inventoryOutputs = Asgard._Foreing.SAL_SALIDAS.Where(x => x.SAL_Factura.Equals(code)).ToList();
            }

            return inventoryOutputs;
        }

        public ProjectResponse UpdateInventoyOutputs(ProjectRequest request)
        {
            var inventoryOutputs = GetInventoryOutputs(request.Project.Code);
            var response = new ProjectResponse();

            foreach(var tmpTask in request.Project.Tasks)
            {
                var taskOutputs = inventoryOutputs.Where(x => x.idTask.Equals(tmpTask)).ToList(); //Salidas de la tarea que se analiza
                
                //Se sacan los recursos de las salidas que pertenecen a una tarea especifica
                var resources = new List<SAL_DETALLE>();
                foreach(var tmpOutput in taskOutputs)
                    resources.AddRange(tmpOutput.SAL_DETALLE);

                //Se suman las salidas de cada recurso y se le asigna a lo real usado
                foreach(var tmpResource in tmpTask.Resources)
                {
                    tmpResource.RealUsed = resources.Where(x => x.INV_Codigo.Equals(tmpResource.Code)).Sum(y => y.SAL_Cantidad);
                }
            }
            response.Project = request.Project;
            return response;
        }
    }
}
