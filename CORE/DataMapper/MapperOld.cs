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
        internal static PhoneData Map(Nexus.PersonPhone phone)
        {
            PhoneData tmpPhoneData = null;
            if (phone != null)
            {
                tmpPhoneData = new PhoneData();
                tmpPhoneData.Id = phone.Id;
                tmpPhoneData.PhoneNumber = phone.Phone;
                tmpPhoneData.PhoneType = Map(phone.PhoneType); 
            }
            return tmpPhoneData;
        }

        internal static List<PhoneData> Map(EntityCollection<Nexus.PersonPhone> collection)
        {
            List<PhoneData> list = new List<PhoneData>();
            foreach (var item in collection)
            {
                var mappedData = Map(item);
                list.Add(mappedData);
            }
            return list;
        }

        internal static PhoneTypeData Map(Nexus.PhoneType phoneType)
        {
            PhoneTypeData tmpPhoneTypeData = null;
            if (phoneType != null)
            {
                tmpPhoneTypeData = new PhoneTypeData();
                tmpPhoneTypeData.Id = phoneType.Id;
                tmpPhoneTypeData.Name = phoneType.Name; 
            }
            return tmpPhoneTypeData;
        }

        internal static PersonData Map(Nexus.Person person)
        {
            PersonData tmpPersonData = null;
            if (person != null) { 
                tmpPersonData = new PersonData();
                tmpPersonData.Id = person.Id;
                tmpPersonData.Name = person.Name;
                tmpPersonData.LastName = person.LastName;
                tmpPersonData.PhoneList = Map(person.PersonPhones);
            }
            return tmpPersonData;
        }

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



        #region Object Mapping Methods

        internal static void mapper(ResourceTypeData source, Nexus.ResourceType destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }

        internal static void mapper(Nexus.ResourceType source, ResourceTypeData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }

        internal static void mapper(Nexus.ResourceType source, Nexus.ResourceType destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.IsTaxed = source.IsTaxed;
        }


        internal static void mapper(MeasureData source, Nexus.Measure destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }

        internal static void mapper(Nexus.Measure source, MeasureData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }

        internal static void mapper(Nexus.Measure source, Nexus.Measure destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Symbol = source.Symbol;
        }


        internal static void mapper(ResourceData source, Nexus.Resource destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            //Nexus.Measure nm = new Nexus.Measure();
            //mapper(source.Measure, nm);
            //destination.Measure = nm;
            destination.MeasureId = source.Measure.Id;

            //Nexus.ResourceType nrt = new Nexus.ResourceType();
            //mapper(source.ResourceType, nrt);
            //destination.ResourceType = nrt;
            destination.ResourceTypeId = source.ResourceType.Id;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }

        internal static void mapper(Nexus.Resource source, ResourceData destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            MeasureData md = new MeasureData();
            mapper(source.Measure, md);
            destination.Measure = md;

            ResourceTypeData rtd = new ResourceTypeData();
            mapper(source.ResourceType, rtd);
            destination.ResourceType = rtd;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }

        internal static void mapper(Nexus.Resource source, Nexus.Resource destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.TaskId = source.TaskId;

            Nexus.Measure nm = new Nexus.Measure();
            mapper(source.Measure, nm);
            destination.Measure = nm;

            Nexus.ResourceType nrt = new Nexus.ResourceType();
            mapper(source.ResourceType, nrt);
            destination.ResourceType = nrt;

            destination.Code = source.Code;
            destination.Name = source.Name;
            destination.Amount = source.Amount;
            destination.Cost = source.Cost;
            destination.TotalCost = source.TotalCost;
            destination.RealUsed = source.RealUsed;
        }


        internal static void mapper(TaskData source, Nexus.Task destination)
        {
            destination.ProjectId = source.ProjectId;
            destination.Id = source.Id;

            destination.Name = source.Name;
            destination.Duration = source.Duration.ToString();
            destination.PercentComplete = (float)source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.DeadLine = source.DeadLine;
            destination.Expanded = source.Expanded;
            destination.Milestone = source.Milestone;
            destination.RowNumber = source.RowNumber;
            destination.TaskLevel = source.TaskLevel;

            #region Properties that are not necessary
            destination.IsRoot = source.IsRoot;
            destination.IsSumary = source.IsSummary;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DurationResolved = source.DurationResolved.ToString();
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.MilestoneResolved = source.MilestoneResolved;
            #endregion
        }

        internal static void mapper(Nexus.Task source, TaskData destination)
        {
            destination.Id = source.Id;
            destination.ProjectId = source.ProjectId;
            destination.ParentId = source.ParentId;
            destination.Name = source.Name;
            destination.Duration = TimeSpan.Parse(source.Duration);
            destination.PercentComplete = source.PercentComplete;
            destination.StartDateTime = source.StartDateTime;
            destination.EndDateTime = source.EndDateTime;
            destination.Notes = source.Notes;
            destination.RowNumber = source.RowNumber;
            destination.BindingListIndex = source.BindingListIndex;
            destination.CompleteThrough = source.CompleteThrough;
            destination.DeadLine = source.DeadLine;
            destination.DurationResolved = TimeSpan.Parse(source.DurationResolved);
            destination.EndDateTimeResolved = source.EndDateTimeResolved;
            destination.Expanded = source.Expanded;
            destination.IsRoot = source.IsRoot;
            destination.IsSummary = source.IsSumary;
            destination.TaskLevel = source.TaskLevel;
            destination.Milestone = source.Milestone;
            destination.MilestoneResolved = source.MilestoneResolved;

            destination.Dependencies = loadDependencies(source);
            destination.resourceList = loadResources(source);
        }

        /// <summary>
        /// Este método se encarga de cargar las dependecias de las tareas que se van cargando, es recursivo junto al 
        /// mapper de esta clase para mapear las mismas dependencias.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static List<TaskData> loadDependencies(Nexus.Task t)
        {
            List<TaskData> dependencies = new List<TaskData>();

            dependencies = loadTasks(t.Task1);

            return dependencies;
        }


        /// <summary>
        /// Este método se encarga de cargar las tareas desde Nexus a una lista de TaskData
        /// </summary>
        /// <param name="tasks">Lista de tareas de Nexus de tipo Task</param>
        /// <returns>Lista de tareas de tipo TaskData</returns>
        private static List<TaskData> loadTasks(System.Data.Objects.DataClasses.EntityCollection<Nexus.Task> tasks)
        {
            List<TaskData> listTask = new List<TaskData>();

            if (tasks != null)
            {
                foreach (Nexus.Task task in tasks)
                {
                    TaskData tmpTask = new TaskData();
                    mapper(task, tmpTask);
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
        private static List<ResourceData> loadResources(Nexus.Task t)
        {
            List<ResourceData> resources = new List<ResourceData>();

            foreach (Nexus.Resource r in t.Resources)
            {
                ResourceData rd = new ResourceData();
                mapper(r, rd);
                resources.Add(rd);
            }

            return resources;
        }

        internal static void mapper(Nexus.Project source, ProjectData destination)
        {
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.BudgetRequestId = source.BudgetRequestId;
            destination.CustumerId = source.CustumerId;
            destination.CustumerName = source.Customer.Name;
            destination.EmployeeId = source.EmployeeId;
            destination.ManagementApproval = source.ManagementApproval;
            destination.CxcApproval = source.CxcApproval;
            destination.CreateDate = source.CreateDate;
            destination.ContingenciesRate = source.ContingenciesRate;
            destination.GuaranteeRate = source.GuaranteeRate;
            destination.TotalUtilityRate = source.TotalUtilityRate;
            destination.DiscountRate = source.DiscountRate;
            destination.SalesTax = source.SalesTax;
            destination.OthersRate = source.OthersRate;
            destination.Comments = source.Comments;

            destination.taskList = loadTasks(source.Tasks);
        }

        internal static void mapper(ProjectData source, Nexus.Project destination)
        {
            destination.Id = source.Id;
            destination.BudgetRequestId = source.BudgetRequestId;
            destination.CustumerId = source.CustumerId;
            destination.EmployeeId = source.EmployeeId;
            destination.Name = source.Name;
            destination.ManagementApproval = source.ManagementApproval;
            destination.CxcApproval = source.CxcApproval;
            destination.CreateDate = source.CreateDate;
            destination.ContingenciesRate = source.ContingenciesRate;
            destination.GuaranteeRate = source.GuaranteeRate;
            destination.TotalUtilityRate = source.TotalUtilityRate;
            destination.DiscountRate = source.DiscountRate;
            destination.SalesTax = source.SalesTax;
            destination.OthersRate = source.OthersRate;
            destination.Comments = source.Comments;
        }

        #endregion

    }
}
