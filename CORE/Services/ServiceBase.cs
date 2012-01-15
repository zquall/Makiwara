using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Nerv;
using ReplicantRepository.DataTransferObjects.NervObjects;
using Nexus;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class ServiceBase
    {
        private static bool _MapperStoped = true;
        public ServiceBase()
        {
            InitializeMapper();
        }

        private static void InitializeMapper()
        {
            if (_MapperStoped)
            {
                // Nerv Mapping
                Mapper.CreateMap<UserAccount, UserAccountDto>();

                // Company Mapping
                Mapper.CreateMap<Employee, EmployeeDto>();
                Mapper.CreateMap<Person, PersonDto>();

                // Just start the mapper once
                _MapperStoped = false;
            }
        }

    }
}
