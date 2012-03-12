using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;
using Nerv;
using ReplicantRepository.DataTransferObjects.NervObjects;
using Nexus;
using CORE.Services;

namespace CORE.DataMapper
{
    internal static class MapperPaths
    {

        private static bool _mapperStoped = true;

        internal static void InitializeMapper()
        {
            if (_mapperStoped)
            {
                // UserAccount
                Mapper.CreateMap<UserAccount, UserAccountDto>();
                Mapper.CreateMap<UserAccountDto, UserAccount>();

                // Employee
                Mapper.CreateMap<Employee, EmployeeDto>()
                    .ForMember(dest => dest.BudgetRequests, opt => opt.Ignore())                     
                    .ForMember(dest => dest.Customers, opt => opt.Ignore());
                Mapper.CreateMap<EmployeeDto, Employee>();

                // Person
                Mapper.CreateMap<Person, PersonDto>()                    
                    .ForMember(dest => dest.Employees, opt => opt.Ignore())
                    .ForMember(dest => dest.CustomerContacts, opt => opt.Ignore());
                Mapper.CreateMap<PersonDto, Person>()
                    .ForMember(dest => dest.CustomerContacts, opt => opt.Ignore())
                    .ForMember(dest => dest.Employees, opt => opt.Ignore());

                // PersonPhone
                Mapper.CreateMap<PersonPhone, PersonPhoneDto>()                    
                    .ForMember(dest => dest.Person, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequests, opt => opt.Ignore());
                Mapper.CreateMap<PersonPhoneDto, PersonPhone>()
                    .ForMember(dest => dest.Person, opt => opt.Ignore());

                // PersonType
                Mapper.CreateMap<PhoneType, PhoneTypeDto>()
                    .ForMember(dest => dest.PersonPhones, opt => opt.Ignore());
                Mapper.CreateMap<PhoneTypeDto, PhoneType>();

                Mapper.CreateMap<Customer, CustomerDto>()
                    .ForMember(dest => dest.BudgetRequests, opt => opt.Ignore())
                    .ForMember(dest => dest.Projects, opt => opt.Ignore())
                    .ForMember(dest => dest.Employees, opt => opt.Ignore());
                Mapper.CreateMap<CustomerDto, Customer>();

                Mapper.CreateMap<CustomerContact, CustomerContactDto>()
                    .ForMember(dest => dest.Customer, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequests, opt => opt.Ignore());
                Mapper.CreateMap<CustomerContactDto, CustomerContact>()
                    .ForMember(dest => dest.Customer, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequests, opt => opt.Ignore());

                Mapper.CreateMap<PhoneType, PhoneTypeDto>()
                     .ForMember(dest => dest.PersonPhones, opt => opt.Ignore());
                Mapper.CreateMap<PhoneTypeDto, PhoneType>();

                // BudgetRequest
                Mapper.CreateMap<BudgetRequest, BudgetRequestDto>()
                    .ForMember(dest => dest.Projects, opt => opt.Ignore())
                    .ForMember(dest => dest.CustomerContact, opt => opt.Ignore())
                    .ForMember(dest => dest.PersonPhone, opt => opt.Ignore());
                Mapper.CreateMap<BudgetRequestDto, BudgetRequest>()
                    .ForMember(dest => dest.BudgetRequestDetails, opt => opt.UseDestinationValue())
                    .ForMember(dest => dest.BudgetRequestCondition, opt => opt.UseDestinationValue())
                    .ForMember(dest => dest.Projects, opt => opt.Ignore())
                    .ForMember(dest => dest.Employee, opt => opt.Ignore())
                    .ForMember(dest => dest.Customer, opt => opt.Ignore())
                    .ForMember(dest => dest.CustomerContact, opt => opt.Ignore())
                    .ForMember(dest => dest.PersonPhone, opt => opt.Ignore());

                Mapper.CreateMap<BudgetRequestCondition, BudgetRequestConditionDto>()
                    .ForMember(dest => dest.BudgetRequest, opt => opt.Ignore());
                Mapper.CreateMap<BudgetRequestConditionDto, BudgetRequestCondition>()
                    .ForMember(dest => dest.BudgetRequestId, opt => opt.UseDestinationValue());
                   

                Mapper.CreateMap<BudgetRequestDetail, BudgetRequestDetailDto>()
                    .ForMember(dest => dest.BudgetRequest, opt => opt.Ignore())
                    .ForMember(dest => dest.Item, opt => opt.Ignore());
                Mapper.CreateMap<BudgetRequestDetailDto, BudgetRequestDetail>()
                    .ForMember(dest => dest.BudgetRequest, opt => opt.Ignore())
                    .ForMember(dest => dest.Item, opt => opt.Ignore());

                Mapper.CreateMap<BindCustomer, BindCustomerDto>()
                    .ForMember(dest => dest.Customer, opt => opt.Ignore());
                Mapper.CreateMap<BindCustomerDto, BindCustomer>();

                // Item
                Mapper.CreateMap<Item, ItemDto>();
                Mapper.CreateMap<ItemDto, Item>();

                // Stock
                Mapper.CreateMap<Stock, StockDto>()
                    .ForMember(dest => dest.Warehouse, opt => opt.Ignore());
                Mapper.CreateMap<StockDto, Stock>();

                //**************************************************************************************
                Mapper.CreateMap<ProjectDto, Project>()
                    .ForMember(dest => dest.Customer, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequest, opt => opt.Ignore())
                    .ForMember(dest => dest.ProjectState, opt => opt.Ignore())
                    .ForMember(dest => dest.Tasks, opt => opt.Ignore());
                Mapper.CreateMap<Project, ProjectDto>();

                Mapper.CreateMap<Task, TaskDto>()
                      .ForMember(dest => dest.Project, opt => opt.Ignore());
                Mapper.CreateMap<TaskDto, Task>()
                    .ForMember(dest => dest.Project, opt => opt.Ignore())
                    .ForMember(dest => dest.Resources, opt => opt.UseDestinationValue());

                Mapper.CreateMap<Resource, ResourceDto>()
                    .ForMember(dest => dest.Task, opt => opt.Ignore());
                Mapper.CreateMap<ResourceDto, Resource>()
                    .ForMember(dest => dest.Task, opt => opt.Ignore())
                    .ForMember(dest => dest.ResourceType, opt => opt.Ignore())
                    .ForMember(dest => dest.Measure, opt => opt.Ignore());
                
                Mapper.CreateMap<ResourceTypeDto, ResourceType>()
                    .ForMember(dest => dest.Resources, opt => opt.Ignore());
                Mapper.CreateMap<ResourceType, ResourceTypeDto>()
                    .ForMember(dest => dest.Resources, opt => opt.Ignore());
                
                Mapper.CreateMap<MeasureDto, Measure>()
                    .ForMember(dest => dest.Resources, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequestDetails, opt => opt.Ignore());
                Mapper.CreateMap<Measure, MeasureDto>()
                    .ForMember(dest => dest.Resources, opt => opt.Ignore())
                    .ForMember(dest => dest.BudgetRequestDetails, opt => opt.Ignore());

                Mapper.CreateMap<ProjectState, ProjectStateDto>()
                    .ForMember(dest => dest.Projects, opt => opt.Ignore());
                Mapper.CreateMap<ProjectStateDto, ProjectState>()
                    .ForMember(dest => dest.Projects, opt => opt.Ignore());

                // Just start the mapper once
                _mapperStoped = false;
            }
        }

        #region Custom Mapping Extensions

        //internal static CustomerContactDto Map(CustomerContact customerContact)
        //{
        //    // Extract
        //    var contactPerson = customerContact.Person;
        //    var personPhones = new List<PersonPhone>();
        //    foreach (var tmpPersonPhone in contactPerson.PersonPhones.ToList())
        //    {
        //        Olympus._Enterprise.Detach(tmpPersonPhone);
        //        personPhones.Add(tmpPersonPhone);
        //    }

        //    // Detach
        //    Olympus._Enterprise.Detach(contactPerson);
        //    Olympus._Enterprise.Detach(customerContact);

        //    // Map
        //    var contactDto = Mapper.Map<CustomerContactDto>(customerContact);
        //    contactDto.Person = Mapper.Map<PersonDto>(contactPerson);
        //    contactDto.Person.PersonPhones = Mapper.Map<List<PersonPhoneDto>>(personPhones);
        //    return contactDto;
        //}

        //internal static CustomerDto Map(Customer customer)
        //{
        //    CustomerDto customerDto = null;
        //    if (customer != null) {

        //        var customerContacts = new List<CustomerContactDto>();
        //        foreach (CustomerContact tmpCustomerContact in customer.CustomerContacts.ToList())
        //        {
        //            customerContacts.Add(Mapper.Map<CustomerContactDto>(tmpCustomerContact));
        //        }

        //        Olympus._Enterprise.Detach(customer);
        //        customerDto = Mapper.Map<CustomerDto>(customer);
        //        customerDto.CustomerContacts = customerContacts;
        //    }

        //    return customerDto;
        //}

        //internal static BudgetRequestDto Map(BudgetRequest budgetRequest)
        //{
        //    BudgetRequestDto budgetRequestDto = null;
        //    if (budgetRequest != null)
        //    {

        //        // Customer
        //        var customer = Map(budgetRequest.Customer);

        //        // Person
        //        var personEntity = budgetRequest.Employee.Person;
        //        Olympus._Enterprise.Detach(personEntity);
        //        var person = Mapper.Map<PersonDto>(personEntity);

        //        // Employee
        //        var employeeEntity = budgetRequest.Employee;
        //        Olympus._Enterprise.Detach(employeeEntity);
        //        var employee = Mapper.Map<EmployeeDto>(employeeEntity);

        //        // BudgetRequestCondition
        //        var budgetRequestConditionEntity = budgetRequest.BudgetRequestCondition;
        //        Olympus._Enterprise.Detach(budgetRequestConditionEntity);
        //        var budgetRequestCondition = Mapper.Map<BudgetRequestConditionDto>(budgetRequestConditionEntity);

        //        // BubgetRequest
        //        Olympus._Enterprise.Detach(budgetRequest);
        //        budgetRequestDto = Mapper.Map<BudgetRequestDto>(budgetRequest);

        //        budgetRequestDto.Customer = customer;
        //        budgetRequestDto.Employee = employee;
        //        budgetRequestDto.Employee.Person = person;
        //        budgetRequestDto.BudgetRequestCondition = budgetRequestCondition;
        //    }
        //    return budgetRequestDto;
        //}


        internal static ResourceDto Map(Resource resource)
        {
            ResourceDto resourceDto = null;
            if (resource != null)
            {
                // Resource Type
                var resourceTypeEntity = resource.ResourceType;
                Olympus._Enterprise.Detach(resourceTypeEntity);
                var resoureceType = Mapper.Map<ResourceTypeDto>(resourceTypeEntity);

                //Measure
                var measureTypeEntity = resource.Measure;
                Olympus._Enterprise.Detach(measureTypeEntity);
                var measure = Mapper.Map<MeasureDto>(measureTypeEntity);

                Olympus._Enterprise.Detach(resource);
                resourceDto = Mapper.Map<ResourceDto>(resource);

                resourceDto.Measure = measure;
                resourceDto.ResourceType = resoureceType;
            }
            return resourceDto;
        }

        internal static TaskDto Map(Task task)
        {
            TaskDto taskDto = null;
            if (task != null)
            {
                var resourceList = new List<ResourceDto>();
                foreach (var r in task.Resources.ToList())
                {
                    var newResource = Map(r);
                    resourceList.Add(newResource);
                }

                var dependencies = new List<TaskDto>();
                foreach (var t in task.Tasks.ToList())
                {
                    //t.Tasks.Clear();
                    var newTask = Map(t);
                    dependencies.Add(newTask);
                }

                //Olympus._Enterprise.Detach(task);
                taskDto = Mapper.Map<TaskDto>(task);

                taskDto.Resources = resourceList;
                taskDto.Tasks = dependencies;
            }
            return taskDto;
        }

        internal static ProjectDto Map(Project project)
        {
            ProjectDto projectDto = null;
            if (project != null)
            {
                #region Task Charge
                var taskList = new List<TaskDto>();
                foreach (var tmpTask in project.Tasks.ToList())
                {
                    var newTask = Map(tmpTask);
                    taskList.Add(newTask);
                }
                #endregion

                #region Customer Charge
                var customerTypeEntity = project.Customer;
                Olympus._Enterprise.Detach(customerTypeEntity);
                var customer = Mapper.Map<CustomerDto>(customerTypeEntity);
                #endregion

                #region BudgetRequest Charge
                var budgetRequest = Mapper.Map<BudgetRequestDto>(project.BudgetRequest);
                #endregion

                #region Project State Charge
                var projectStateTypeEntity = project.ProjectState;
                Olympus._Enterprise.Detach(projectStateTypeEntity);
                var projectState = Mapper.Map<ProjectStateDto>(projectStateTypeEntity);
                #endregion

                Olympus._Enterprise.Detach(project);
                projectDto = Mapper.Map<ProjectDto>(project);

                projectDto.Customer = customer;
                projectDto.BudgetRequest = budgetRequest;
                projectDto.Tasks = taskList;
                projectDto.ProjectState = projectState;
            }
            return projectDto;
        }

        #endregion
    }
}
