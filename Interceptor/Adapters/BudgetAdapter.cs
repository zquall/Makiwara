using System;
using System.Linq;
using Interceptor.DataBase;
using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class BudgetAdapter
    {
        #region Resources

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
                var totalCost = resourceCollection.Sum(x => x.TotalCost);
                item.Amount = amount;
                item.TotalCost = totalCost;
            }
            return item;
        }

        private void GetResources(IEnumerable<TaskDto> taskCollection, List<ResourceDto> resourceCollection)
        {
            if (taskCollection != null)
                foreach (var tmpTask in taskCollection)
                {
                    resourceCollection.AddRange(tmpTask.Resources);
                    //if (tmpTask.Tasks != null) GetResources(tmpTask.Tasks, resourceCollection);
                }
        }

        #endregion

        #region Detail

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
            switch (resourceType)
            {
                case "ALQUILERES":
                    return "EQUIP";
                case "PRODUCTO":
                    return "V-MAR";
                case "PLANILLA":
                    return "M-O";
                case "SUBCONTRATOS":
                    return "SUBCT";
                case "TRANSPORTES":
                    return "TRANS";
                case "IMPORTADOS":
                    return "V-MAT";
                case "OTROS":
                    return "O-MAT";
                default:
                    return "ERROR";
            }
        }

        private void Map(ResourceDto source, PRE_DETALLE destination)
        {
            destination.PRD_ID = 1; // No tengo ni idea de que es este id o como se llena
            destination.CIA_CODIGO = "01";
            destination.HOP_CODIGO = GetBudgetSheet(source.ResourceType.Name);
            destination.INV_CODIGO = source.Code;
            destination.PRD_DESCRIPCION = source.Name;
            destination.PRD_COSTOUNITARIO = Convert.ToDouble(source.Cost);
            destination.PRD_CANTIDAD = source.Amount;
            destination.PRD_COSTOTOTAL = Convert.ToDouble(source.TotalCost);
            destination.PRD_APLICARIMPVTAS = 0;
        }

        private void GetBudgetDetail(IEnumerable<TaskDto> taskCollection, ICollection<PRE_DETALLE> detail)
        {
            var resources = new List<ResourceDto>();

            detail.Clear();
            GetResources(taskCollection, resources);
            var resourcesCopy = CopyResources(resources);

            var listItems = resourcesCopy.Select(x => x.Code).Distinct();

            foreach (var tmpItem in listItems)
            {
                var preDetalle = new PRE_DETALLE();
                var item = OnlyOneFromSeveral(resourcesCopy.Where(x => x.Code.Equals(tmpItem)).ToList());
                Map(item, preDetalle);
                detail.Add(preDetalle);
            }
        }

        #endregion

        #region Attached Tables

        private void GetTotalDetail(ICollection<PRE_TOTALESDETALLE_X_HOJAPRESUPUESTO> destination, ICollection<PRE_DETALLE> detail)
        {
            var listTypes = detail.Select(x => x.HOP_CODIGO).Distinct();
            destination.Clear();

            foreach (var tmpType in listTypes)
            {
                var preDetalle = new PRE_TOTALESDETALLE_X_HOJAPRESUPUESTO
                {
                    CIA_CODIGO = "01",
                    //preDetalle.PRE_NUMERO = 0,;
                    HOP_CODIGO = tmpType,
                    PRD_IMPUESTOVTAS = 0,
                    PRD_SUBTOTAL = detail.Where(x => x.HOP_CODIGO.Equals(tmpType)).Sum(x => x.PRD_COSTOTOTAL),
                    PRD_PORC_DESC = 0,
                    PRD_MONTO_DESC = 0,
                    PRD_OTROS_PORC = 0,
                    PRD_MONTO_X_OTROS_PORC = 0,
                    PRD_MONTOTOTAL = detail.Where(x => x.HOP_CODIGO.Equals(tmpType)).Sum(x => x.PRD_COSTOTOTAL)
                };
                destination.Add(preDetalle);
            }
        }

        private void GetBudgetTask(IEnumerable<TaskDto> taskCollection, ICollection<TaskByBudget> detail)
        {
            detail.Clear();

            foreach (TaskDto tmpTask in taskCollection)
            {
                var tmpTaskByBudget = new TaskByBudget
                {
                    IdTask = tmpTask.Id,
                    Name = tmpTask.Name,
                    PRE_PRESUPUESTOS = null,
                    PRE_PRESUPUESTOSReference = null
                };
                detail.Add(tmpTaskByBudget);
            }
        }

        #endregion

        #region Main Mapper

        /// <summary>
        /// Return the sumary of the resources cost
        /// </summary>
        /// <param name="project">The Project with resources</param>
        /// <returns>The sum of the cost</returns>
        private decimal CalcSubtotal(ProjectDto project)
        {
            var resources = new List<ResourceDto>();
            GetResources(project.Tasks, resources);
            return resources.Sum(x => x.TotalCost);
        }

        private void Map(ProjectDto source, PRE_PRESUPUESTOS destination, IEnumerable<TaskDto> taskList)
        {
            #region Map
            destination.CIA_CODIGO = "01";
            destination.PRE_NUMERO = Convert.ToDouble(source.Code);
            destination.CLI_CLIENTE = source.BudgetRequest.Customer.BindCustomer.AlienId;
            destination.SVR_CODIGO = "00";                         // Necesario por ser llave foranea {No existe en SGP}{NO APLICA}
            destination.PRE_FECHA = DateTime.Today;
            destination.VEN_VENDEDOR = "SGP";                        //Se utiliza un estandar, en este caso es el sitema SGP
            destination.PRE_NOMBREPROYECTO = source.Name;
            destination.PRE_OBSERVACIONES = source.Comments;
            destination.PRE_ACTIVIDADES = "GENERADO MEDIANTE SGP";
            destination.PRE_TOTALMETROS = source.TotalMeters;

            destination.PRE_SUBTOTAL_H = 0.0;                      //{Pendiente}
            destination.PRE_SUBTOTAL_I = 0.0;                      //{Pendiente}
            destination.PRE_SUBTOTAL_J = 0.0;                      //{Pendiente}
            destination.PRE_APLICADO = 0;                        //{Pendiente}
            destination.PRE_PORC_UTILIDAD = 0.0;
            destination.PRE_UTILIDAD = 0.0;
            destination.PRE_PORC_MUP = 0.0;

            destination.PRE_SUBTOTAL_K = Convert.ToDouble(CalcSubtotal(source));
            destination.PRE_PORC_IMPREVISTOS = source.ContingenciesRate;
            destination.PRE_IMPREVISTOS = destination.PRE_SUBTOTAL_K * destination.PRE_PORC_IMPREVISTOS / 100;
            destination.PRE_PORC_GARANTIA = source.GuaranteeRate;
            destination.PRE_GARANTIA = destination.PRE_SUBTOTAL_K * destination.PRE_PORC_GARANTIA / 100;

            var other = destination.PRE_SUBTOTAL_K * source.OthersRate / 100; // + % Otros que no aparece en dialcom

            destination.PRE_TOTALSERVICIO = destination.PRE_SUBTOTAL_K + destination.PRE_IMPREVISTOS + destination.PRE_GARANTIA + other;
            destination.PRE_PORC_UTIL_GNRL = source.TotalUtilityRate;
            destination.PRE_UTILIDAD_GNRL = destination.PRE_TOTALSERVICIO * destination.PRE_PORC_UTIL_GNRL / 100;

            var discount = (destination.PRE_TOTALSERVICIO + destination.PRE_UTILIDAD_GNRL) * source.DiscountRate / 100;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /**/
            destination.PRE_TOTAL_GNRL = destination.PRE_TOTALSERVICIO + destination.PRE_UTILIDAD_GNRL - discount;/**/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (destination.PRE_TOTALMETROS <= 0)
                destination.PRE_COSTOXMETRO = 0;
            else
                destination.PRE_COSTOXMETRO = destination.PRE_TOTAL_GNRL / destination.PRE_TOTALMETROS;

            destination.FAM_Codigo = source.BudgetRequest.Family.Id;        // Necesario por ser llave foranea
            destination.TIP_Codigo = 33;                                    // Necesario por ser llave foranea {No existe en SGP}{Otros}
            destination.SUB_Codigo = 999;                                   // Necesario por ser llave foranea {No existe en SGP}{Ninguno}
            destination.USR_Usuario_Inclusion = "SGP";
            destination.USR_Fecha_Inclusion = DateTime.Today;
            destination.USR_Usuario_Modificacion = "SGP";
            destination.USR_Fecha_Modificacion = DateTime.Today;
            #endregion

            GetBudgetDetail(taskList, destination.PRE_DETALLE);
            GetBudgetTask(taskList, destination.TaskByBudgets);
            GetTotalDetail(destination.PRE_TOTALESDETALLE_X_HOJAPRESUPUESTO, destination.PRE_DETALLE);
        }

        #endregion     

        public void SaveBudget(ProjectDto project, List<TaskDto> taskList)
        {
            if (project != null)
            {
                var code = Convert.ToDouble(project.Code);
                var prePresupuestos = Asgard._Foreing.PRE_PRESUPUESTOS.Where(x => x.PRE_NUMERO.Equals(code)).SingleOrDefault();

                if (prePresupuestos != null)
                {// Edit
                    Map(project, prePresupuestos, taskList);
                }
                else
                {// Add
                    if (project.Code != null)
                    {
                        prePresupuestos = new PRE_PRESUPUESTOS();
                        Map(project, prePresupuestos, taskList);
                        Asgard._Foreing.PRE_PRESUPUESTOS.AddObject(prePresupuestos);
                    }
                }
                Asgard._Foreing.SaveChanges();
            }
        }
    }
}
