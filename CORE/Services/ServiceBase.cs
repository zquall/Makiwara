using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Nerv;
using ReplicantRepository.DataTransferObjects.NervObjects;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;

namespace CORE.Services
{
    public class ServiceBase
    {
        public ServiceBase()
        {
            MapperPaths.InitializeMapper();
        }
    }
}
