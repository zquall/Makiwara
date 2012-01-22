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
                Mapper.CreateMap<Project, ProjectDto>();
                Mapper.CreateMap<ProjectDto, Project>();             


                // Just start the mapper once
                _MapperStoped = false;
            }
        }

        #region Custom Mappings

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

        #endregion
    }
}
