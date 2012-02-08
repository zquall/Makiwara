using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using System.Data.Objects.DataClasses;
using AutoMapper;
using Nerv;
using ReplicantRepository.DataTransferObjects.NervObjects;
using Nexus;
using CORE.Services;

namespace CORE.DataMapper
{
    internal static class MapperPaths
    {

        private static bool _MapperStoped = true;

        internal static void InitializeMapper()
        {
            if (_MapperStoped)
            {
                // Nerv Mapping
                Mapper.CreateMap<UserAccount, UserAccountDto>();
                Mapper.CreateMap<UserAccountDto, UserAccount>();

                // Nerv Reverse Mapping

                // Company Mapping
                Mapper.CreateMap<Employee, EmployeeDto>();
                Mapper.CreateMap<EmployeeDto, Employee>();
                Mapper.CreateMap<Person, PersonDto>();
                Mapper.CreateMap<PersonDto, Person>();
                Mapper.CreateMap<PersonPhone, PersonPhoneDto>();
                Mapper.CreateMap<PersonPhoneDto, PersonPhone>();
                Mapper.CreateMap<PhoneType, PhoneTypeDto>();
                Mapper.CreateMap<PhoneTypeDto, PhoneType>();
                Mapper.CreateMap<Customer, CustomerDto>();
                Mapper.CreateMap<CustomerDto, Customer>();
                Mapper.CreateMap<CustomerContact, CustomerContactDto>();
                Mapper.CreateMap<CustomerContactDto, CustomerContact>();
                Mapper.CreateMap<PhoneType, PhoneTypeDto>();
                Mapper.CreateMap<PhoneTypeDto, PhoneType>();
                Mapper.CreateMap<BudgetRequest, BudgetRequestDto>();
                Mapper.CreateMap<BudgetRequestDto, BudgetRequest>();
                Mapper.CreateMap<BudgetRequestCondition, BudgetRequestConditionDto>();
                Mapper.CreateMap<BudgetRequestConditionDto, BudgetRequestCondition>();
                Mapper.CreateMap<BudgetRequestDetail, BudgetRequestDetailDto>();
                Mapper.CreateMap<BudgetRequestDetailDto, BudgetRequestDetail>();
                Mapper.CreateMap<BindCustomer, BindCustomerDto>();
                Mapper.CreateMap<BindCustomerDto, BindCustomer>();
                //**********************************************************
                Mapper.CreateMap<ProjectDto, Project>();
                Mapper.CreateMap<Project, ProjectDto>();
                Mapper.CreateMap<Task, TaskDto>();
                Mapper.CreateMap<TaskDto, Task>()
                    .ForMember(dest => dest.Task1, opt => opt.Ignore())
                    .ForMember(dest => dest.Project, opt => opt.Ignore());
                Mapper.CreateMap<List<TaskDto>, List<Task>>();
                Mapper.CreateMap<List<Task>, List<TaskDto>>();
                Mapper.CreateMap<Resource, ResourceDto>();
                Mapper.CreateMap<ResourceDto, Resource>();
                Mapper.CreateMap<ResourceTypeDto, ResourceType>();
                Mapper.CreateMap<ResourceType, ResourceTypeDto>();
                Mapper.CreateMap<MeasureDto, Measure>();
                Mapper.CreateMap<Measure, MeasureDto>();
                Mapper.CreateMap<ProjectStateDto, ProjectState>();
                Mapper.CreateMap<ProjectState, ProjectStateDto>();


                // Just start the mapper once
                _MapperStoped = false;
            }
        }

        #region Custom Mapping Extensions

        internal static CustomerContactDto Map(CustomerContact customerContact)
        {
            // Extract
            var contactPerson = customerContact.Person;
            var personPhones = new List<PersonPhone>();
            foreach (var tmpPersonPhone in contactPerson.PersonPhones.ToList())
            {
                Olympus._Enterprise.Detach(tmpPersonPhone);
                personPhones.Add(tmpPersonPhone);
            }

            // Detach
            Olympus._Enterprise.Detach(contactPerson);
            Olympus._Enterprise.Detach(customerContact);

            // Map
            var contactDto = Mapper.Map<CustomerContactDto>(customerContact);
            contactDto.Person = Mapper.Map<PersonDto>(contactPerson);
            contactDto.Person.PersonPhones = Mapper.Map<List<PersonPhoneDto>>(personPhones);
            return contactDto;
        }

        internal static BudgetRequestDto Map(BudgetRequest budgetRequest)
        {
            BudgetRequestDto budgetRequestDto = null;
            if (budgetRequest != null)
            {
                // Customer
                var customerEntity = budgetRequest.Customer;
                Olympus._Enterprise.Detach(customerEntity);
                var customer = Mapper.Map<CustomerDto>(customerEntity);

                // Person
                var personEntity = budgetRequest.Employee.Person;
                Olympus._Enterprise.Detach(personEntity);
                var person = Mapper.Map<PersonDto>(personEntity);

                // Employee
                var employeeEntity = budgetRequest.Employee;
                Olympus._Enterprise.Detach(employeeEntity);
                var employee = Mapper.Map<EmployeeDto>(employeeEntity);

                // BudgetRequestCondition
                var budgetRequestConditionEntity = budgetRequest.BudgetRequestCondition;
                Olympus._Enterprise.Detach(budgetRequestConditionEntity);
                var budgetRequestCondition = Mapper.Map<BudgetRequestConditionDto>(budgetRequestConditionEntity);

                // BubgetRequest
                Olympus._Enterprise.Detach(budgetRequest);
                budgetRequestDto = Mapper.Map<BudgetRequestDto>(budgetRequest);

                budgetRequestDto.Customer = customer;
                budgetRequestDto.Employee = employee;
                budgetRequestDto.Employee.Person = person;
                budgetRequestDto.BudgetRequestCondition = budgetRequestCondition;
            }
            return budgetRequestDto;
        }


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
                List<ResourceDto> resourceList = new List<ResourceDto>();
                foreach (Resource r in task.Resources.ToList())
                {
                    ResourceDto newResource = Map(r);
                    resourceList.Add(newResource);
                }

                List<TaskDto> dependencies = new List<TaskDto>();
                foreach (Task t in task.Tasks.ToList())
                {
                    //t.Tasks.Clear();
                    TaskDto newTask = Map(t);
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
                List<TaskDto> taskList = new List<TaskDto>();
                foreach (Task tmpTask in project.Tasks.ToList())
                {
                    TaskDto newTask = Map(tmpTask);
                    taskList.Add(newTask);
                }
                #endregion

                #region Customer Charge
                var customerTypeEntity = project.Customer;
                Olympus._Enterprise.Detach(customerTypeEntity);
                var customer = Mapper.Map<CustomerDto>(customerTypeEntity);
                #endregion

                #region BudgetRequest Charge
                //var budgetRequestTypeEntity = project.BudgetRequest;
                //Olympus._Enterprise.Detach(budgetRequestTypeEntity);
                var budgetRequest = Map(project.BudgetRequest);
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
