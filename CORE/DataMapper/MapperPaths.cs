﻿using System;
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
                Mapper.CreateMap<TaskDto, Task>();
                Mapper.CreateMap<ResourceTypeDto, ResourceType>();
                Mapper.CreateMap<ResourceType, ResourceTypeDto>();
                Mapper.CreateMap<MeasureDto, Measure>();
                Mapper.CreateMap<Measure, MeasureDto>();


                // Just start the mapper once
                _MapperStoped = false;
            }
        }

        #region Custom Mapping Extensions

        // Customers Contact
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

        internal static List<TaskDto> Map(List<Task> tasks)
        {
            List<TaskDto> tasksReturned = new List<TaskDto>();
            foreach (Task t in tasks)
            {
                Olympus._Enterprise.Detach(t);
                var task = Mapper.Map<TaskDto>(t);
                tasksReturned.Add(task);
            }
            return tasksReturned;
        }

        internal static ProjectDto Map(Project project)
        {
            ProjectDto projectDto = null;
            if (project != null)
            {
                Olympus._Enterprise.Detach(project);
                projectDto = Mapper.Map<ProjectDto>(project);

                //projectDto.Tasks = ;
            }
            return projectDto;
        }

        #endregion
    }
}
