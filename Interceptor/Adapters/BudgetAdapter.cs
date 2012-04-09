using System;
using System.Linq;
using Interceptor.Properties;
using Interceptor.DataBase;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    class BudgetAdapter
    {
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
        private static string GetBudgetSheet(string resourceType)
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

        private static void Map(ResourceDto source, PRE_DETALLE destination)
        {
            destination.PRD_ID = 1; // No tengo ni idea de que es este id o como se llena
            destination.CIA_CODIGO = "01";
            //destination.PRE_NUMERO = 0; {Se llena debido a que es hijo del presupuesto en en Entity}
            destination.HOP_CODIGO = GetBudgetSheet(source.ResourceType.Name);
            destination.INV_CODIGO = source.Code;
            destination.PRD_DESCRIPCION = source.Name;
            destination.PRD_COSTOUNITARIO = Convert.ToDouble(source.Cost);
            destination.PRD_CANTIDAD = source.Amount;
            destination.PRD_COSTOTOTAL = Convert.ToDouble(source.TotalCost);
            destination.PRD_APLICARIMPVTAS = 0;
        }

        private static void Map(ProjectDto source, PRE_PRESUPUESTOS destination)
        {
            destination.CIA_CODIGO = "01";
            destination.PRE_NUMERO = Convert.ToInt32(source.Code);
            destination.CLI_CLIENTE = "";           //{Pendiente}
            destination.SVR_CODIGO = "";            //{Pendiente}
            destination.PRE_FECHA = DateTime.Today;
            destination.VEN_VENDEDOR = "";          //{Pendiente}
            destination.PRE_NOMBREPROYECTO = source.Name;
            destination.PRE_OBSERVACIONES = source.Comments;
            destination.PRE_ACTIVIDADES = "GENERADO MEDIANTE SGP";
            destination.PRE_SUBTOTAL_H = 0.0;       //{Pendiente}
            destination.PRE_IMPREVISTOS = 0.0;      //{Pendiente}
            destination.PRE_UTILIDAD = 0.0;         //{Pendiente}
            destination.PRE_GARANTIA = 0.0;         //{Pendiente}
            destination.PRE_TOTALMETROS = 0.0;      //{Pendiente}
            destination.PRE_TOTALSERVICIO = 0.0;    //{Pendiente}
            destination.PRE_COSTOXMETRO = 0.0;      //{Pendiente}
            destination.PRE_APLICADO = 0;           //{Pendiente}
            destination.PRE_NUMERO = 0;             //{Pendiente}
            destination.PRE_PORC_IMPREVISTOS = 0.0; //{Pendiente}
            destination.PRE_PORC_UTILIDAD = source.TotalUtilityRate;
            destination.PRE_PORC_GARANTIA = source.GuaranteeRate;
            destination.PRE_SUBTOTAL_I = 0.0;       //{Pendiente}
            destination.PRE_SUBTOTAL_J = 0.0;       //{Pendiente}
            destination.PRE_SUBTOTAL_K = 0.0;       //{Pendiente}
            destination.PRE_PORC_MUP = 0.0;         //{Pendiente}
            destination.PRE_PORC_UTIL_GNRL = 0.0;   //{Pendiente}
            destination.PRE_UTILIDAD_GNRL = 0.0;    //{Pendiente}
            destination.PRE_TOTAL_GNRL = 0.0;       //{Pendiente}
            destination.FAM_Codigo = 0;             //{Pendiente}
            destination.TIP_Codigo = 0;             //{Pendiente}
            destination.SUB_Codigo = 0;             //{Pendiente}
            destination.USR_Usuario_Inclusion = "SGP";
            destination.USR_Fecha_Inclusion = DateTime.Today;
            destination.USR_Usuario_Modificacion = "SGP";
            destination.USR_Fecha_Modificacion = DateTime.Today;

            foreach(var tmpTaskDto in source.Tasks)
            {
                foreach(var tmpResourceDto in tmpTaskDto.Resources)
                {
                    var preDetalle = new PRE_DETALLE();
                    Map(tmpResourceDto, preDetalle);
                    destination.PRE_DETALLE.Add(preDetalle);
                }
            }
        }

        // Save Budget
        public void SaveEmployee(ProjectRequest request)
        {
            //var response = new ProjectResponse();

            if (request.Project != null)
            {
                PRE_PRESUPUESTOS prePresupuestos;

                // Check if Edit or Add
                if (request.Project.Id > 0)
                {
                    // Edit
                    prePresupuestos = Asgard._Foreing.PRE_PRESUPUESTOS.Where(x => x.PRE_NUMERO.Equals(request.Project.Id)).SingleOrDefault();

                    if (prePresupuestos != null)
                    {
                        // Overrides the Salary By Hour
                        //request.Employee.SalaryByHour = employee.SalaryByHour;
                        Map(request.Project, prePresupuestos);
                    }
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
                //if (prePresupuestos != null) response.ProjectId = prePresupuestos.Id;
            }
            //return response;
        }
    }
}
