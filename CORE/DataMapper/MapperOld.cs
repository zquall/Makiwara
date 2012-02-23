using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using System.Data.Objects.DataClasses;
using CORE.Services;

namespace CORE.DataMapper
{
    internal static class MapperOld
    {
        internal static CustomerDto Map(Nexus.Customer customer)
        {
            CustomerDto tmpCustomerData = null;
            if (customer != null)
            {
                tmpCustomerData = new CustomerDto();
                tmpCustomerData.Id = customer.Id;
                tmpCustomerData.Name = customer.Name;
                tmpCustomerData.Address = customer.Address;
            }
            return tmpCustomerData;
        }

        //internal static Nexus.Customer Map(CustomerData customerData)
        //{
        //    Nexus.Customer tmpCustomer = null;
        //    if (customerData != null)
        //    {
        //        tmpCustomer = new Nexus.Customer();
        //        tmpCustomer.Id = customerData.Id;
        //        tmpCustomer.Name = customerData.Name;
        //        tmpCustomer.Address = customerData.Address;
        //        tmpCustomer.AddressOptional = customerData.AddressOptional;
        //        tmpCustomer.Phone = customerData.Phone;
        //        tmpCustomer.Fax = customerData.Fax;
        //        //tmpCustomer.CustomerContacts = Map(customerData.ContactList);
        //    }
        //    return tmpCustomer;
        //}

        //internal static EmployeeDto Map(Nexus.Employee employee)
        //{
        //    EmployeeData tmpEmployeeData = null;
        //    if (employee != null)
        //    {
        //        tmpEmployeeData = new EmployeeData();
        //        tmpEmployeeData.Id = employee.Id;
        //        tmpEmployeeData.Person = Map(employee.Person); 
        //    }
        //    return tmpEmployeeData;
        //}





        #region Vortex Zone

        /// <summary>
        /// Este método se encarga de cargar las dependecias de las tareas que se van cargando, es recursivo junto al 
        /// mapper de esta clase para mapear las mismas dependencias.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static List<TaskDto> loadDependencies(Nexus.Task t)
        {
            List<TaskDto> dependencies = new List<TaskDto>();

            dependencies = loadTasks(t.Task1);

            return dependencies;
        }

        /// <summary>
        /// Este método se encarga de cargar las tareas desde Nexus a una lista de TaskData
        /// </summary>
        /// <param name="tasks">Lista de tareas de Nexus de tipo Task</param>
        /// <returns>Lista de tareas de tipo TaskData</returns>
        private static List<TaskDto> loadTasks(System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks)
        {
            List<TaskDto> listTask = new List<TaskDto>();

            if (tasks != null)
            {
                foreach (Nexus.Task task in tasks)
                {
                    TaskDto tmpTask = new TaskDto();
                    //mapper(task, tmpTask);
                    listTask.Add(tmpTask);
                }
            }

            return listTask;
        }

        /// <summary>
        /// Este método se encarga de obtener la lista de recursos de una tarea
        /// </summary>
        /// <param name="t">Tarea de la cual se va a extraer la lista de recursos</param>
        /// <returns>La lista de recursos de la tarea</returns>
        private static List<ResourceDto> loadResources(Nexus.Task t)
        {
            List<ResourceDto> resources = new List<ResourceDto>();

            foreach (Nexus.Resource r in t.Resources)
            {
                ResourceDto rd = new ResourceDto();
                //mapper(r, rd);
                resources.Add(rd);
            }

            return resources;
        }

        #endregion

    }
}
