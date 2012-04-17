using System;
using System.Collections.Generic;
using System.Linq;
using Interceptor.DataBase;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class BudgetAdapter
    {
        #region Resource Mapping

        private void GetResources(IEnumerable<TaskDto> taskCollection, List<ResourceDto> resourceCollection)
        {
            if (taskCollection != null)
                foreach (var tmpTask in taskCollection)
                {
                    resourceCollection.AddRange(tmpTask.Resources);
                    if (tmpTask.Tasks != null) GetResources(tmpTask.Tasks, resourceCollection);
                }
        }

        private List<ResourceDto> CopyResources(IEnumerable<ResourceDto> resources)
        {
            var resourcesCollection = new List<ResourceDto>();

            foreach (var tmpResource in resources)
            {
                var resource = new ResourceDto
                {
                    Amount = tmpResource.Amount,
                    Code = tmpResource.Code,
                    Cost = tmpResource.Cost,
                    Id = tmpResource.Id,
                    Measure = tmpResource.Measure,
                    MeasureId = tmpResource.MeasureId,
                    Name = tmpResource.Name,
                    RealUsed = tmpResource.RealUsed,
                    ResourceType = tmpResource.ResourceType,
                    ResourceTypeId = tmpResource.ResourceTypeId,
                    TotalCost = tmpResource.TotalCost
                };
                resourcesCollection.Add(resource);

            }
            return resourcesCollection;
        }

        private ResourceDto OnlyOneFromSeveral(List<ResourceDto> resourceCollection)
        {
            var item = new ResourceDto();

            if (resourceCollection != null)
            {
                item = resourceCollection.First();
                var amount = resourceCollection.Sum(x => x.Amount);
                item.Amount = amount;
            }
            return item;
        }

        private void GetBudgetDetail(IEnumerable<TaskDto> taskCollection, ICollection<PRE_DETALLE> detail)
        {
            var resources = new List<ResourceDto>();

            detail.Clear();
            GetResources(taskCollection, resources);
            var resourcesCopy = CopyResources(resources);

            var listItems = resourcesCopy.Select(x => x.Code).Distinct();

            foreach(var tmpItem in listItems)
            {
                var preDetalle = new PRE_DETALLE();
                var item = OnlyOneFromSeveral(resourcesCopy.Where(x => x.Code.Equals(tmpItem)).ToList());
                Map(item, preDetalle);
                detail.Add(preDetalle);
            }
        }

        /// <summary>
        /// Conversion Table
        /// M-O     =   Mano de Obra
        /// TRANS   =   Transporte
        /// V-MAR   =   Insumos Locales
        /// V-MAT   =   Materiales Importados
        /// VIAT    =   Viaticos
        /// EQUIP   =   Equipo
        /// OTGAS   =   Otros Gastos............................{Queda prohibido su uso}
        /// SUBCT   =   Subcontratos
        /// O-MAT   =   Otros Materiales
        /// IMPRE   =   Imprevistos Del Projecto (Logistica)....{Queda prohibido su uso}
        /// </summary>
        /// <param name="resourceType">Resource Type</param>
        /// <returns>Budget Sheet</returns>
        private string GetBudgetSheet(string resourceType)
        {
            switch(resourceType)
            {
                case "ALQUILERES":
                    return "EQUIP";
                case "PRODUCTO":
                    return "V-MAR";
                case "PLANILLA":
                    return "M-O";
                default:
                    return "ERROR";
            }
        }

        private void Map(ResourceDto source, PRE_DETALLE destination)
        {
            destination.PRD_ID = 1; // No tengo ni idea de que es este id o como se llena
            destination.CIA_CODIGO = "01";
            //destination.PRE_NUMERO = source; //{Se llena debido a que es hijo del presupuesto en en Entity}
            destination.HOP_CODIGO = GetBudgetSheet(source.ResourceType.Name);
            destination.INV_CODIGO = source.Code;
            destination.PRD_DESCRIPCION = source.Name;
            destination.PRD_COSTOUNITARIO = Convert.ToDouble(source.Cost);
            destination.PRD_CANTIDAD = source.Amount;
            destination.PRD_COSTOTOTAL = Convert.ToDouble(source.TotalCost);
            destination.PRD_APLICARIMPVTAS = 0;
        }

        #endregion

        private void Map(ProjectDto source, PRE_PRESUPUESTOS destination)
        {
            #region Map
            destination.CIA_CODIGO = "01";
            destination.PRE_NUMERO = Convert.ToDouble(source.Code);
            destination.CLI_CLIENTE = source.BudgetRequest.Customer.BindCustomer.AlienId;
            destination.SVR_CODIGO = "00";                              // Necesario por ser llave foranea {No existe en SGP}{NO APLICA}
            destination.PRE_FECHA = DateTime.Today;
            destination.VEN_VENDEDOR = "SGP";                           //Se utiliza un estandar, en este caso es el sitema SGP
            destination.PRE_NOMBREPROYECTO = source.Name;
            destination.PRE_OBSERVACIONES = source.Comments;
            destination.PRE_ACTIVIDADES = "GENERADO MEDIANTE SGP";
            destination.PRE_SUBTOTAL_H = 0.0;                           //{Pendiente}
            destination.PRE_IMPREVISTOS = 0.0;                          //{Pendiente}
            destination.PRE_UTILIDAD = 0.0;                             //{Pendiente}
            destination.PRE_GARANTIA = 0.0;                             //{Pendiente}
            destination.PRE_TOTALMETROS = 0.0;                          //{Pendiente}
            destination.PRE_TOTALSERVICIO = 0.0;                        //{Pendiente}
            destination.PRE_COSTOXMETRO = 0.0;                          //{Pendiente}
            destination.PRE_APLICADO = 0;                               //{Pendiente}
            destination.PRE_PORC_IMPREVISTOS = source.ContingenciesRate;
            destination.PRE_PORC_UTILIDAD = source.TotalUtilityRate;
            destination.PRE_PORC_GARANTIA = source.GuaranteeRate;
            destination.PRE_SUBTOTAL_I = 0.0;                           //{Pendiente}
            destination.PRE_SUBTOTAL_J = 0.0;                           //{Pendiente}
            destination.PRE_SUBTOTAL_K = 0.0;                           //{Pendiente}
            destination.PRE_PORC_MUP = 0.0;                             //{Pendiente}
            destination.PRE_PORC_UTIL_GNRL = 0.0;                       //{Pendiente}
            destination.PRE_UTILIDAD_GNRL = 0.0;                        //{Pendiente}
            destination.PRE_TOTAL_GNRL = 0.0;                           //{Pendiente}
            destination.FAM_Codigo = source.BudgetRequest.Family.Id;    // Necesario por ser llave foranea
            destination.TIP_Codigo = 33;                                // Necesario por ser llave foranea {No existe en SGP}{Otros}
            destination.SUB_Codigo = 999;                               // Necesario por ser llave foranea {No existe en SGP}{Ninguno}
            destination.USR_Usuario_Inclusion = "SGP";
            destination.USR_Fecha_Inclusion = DateTime.Today;
            destination.USR_Usuario_Modificacion = "SGP";
            destination.USR_Fecha_Modificacion = DateTime.Today;
            #endregion

            GetBudgetDetail(source.Tasks, destination.PRE_DETALLE);
        }

        // Save Budget
        public void SaveBudget(ProjectRequest request)
        {
            if (request.Project != null)
            {
                var code = Convert.ToDouble(request.Project.Code);
                var prePresupuestos = Asgard._Foreing.PRE_PRESUPUESTOS.Where(x => x.PRE_NUMERO.Equals(code)).SingleOrDefault();

                // Check if Edit or Add
                if (prePresupuestos != null)
                {
                    // Edit
                        Map(request.Project, prePresupuestos);
                }
                else
                {
                    // Add
                    if (request.Project.Code != null)
                    {
                        // Check some info from AlienDB
                        prePresupuestos = new PRE_PRESUPUESTOS();
                        Map(request.Project, prePresupuestos);
                        Asgard._Foreing.PRE_PRESUPUESTOS.AddObject(prePresupuestos);
                    }
                }
                Asgard._Foreing.SaveChanges();
            }
        }
    }
}
