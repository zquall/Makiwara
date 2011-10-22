﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class CustomerFactory
    {
        private static CustomerService _CustomerService;
        public CustomerFactory()
        {
            _CustomerService = _CustomerService ?? new CustomerService();
        }

        public CustomerResponse searchCustomer(CustomerRequest request)
        {
            return _CustomerService.searchCustomer(request);
        }

    }
}