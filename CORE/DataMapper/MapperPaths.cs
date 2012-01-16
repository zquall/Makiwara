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

                // Company Mapping
                Mapper.CreateMap<Employee, EmployeeDto>();
                Mapper.CreateMap<Person, PersonDto>();
                Mapper.CreateMap<Customer, CustomerDto>();
                Mapper.CreateMap<PhoneType, PhoneTypeDto>();

                // Just start the mapper once
                _MapperStoped = false;
            }
        }      
    }
}
