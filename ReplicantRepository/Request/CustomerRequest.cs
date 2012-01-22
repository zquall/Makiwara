﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class CustomerRequest
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public string SearchCustomerQuery { get; set; }
        public CustomerDto Customer { get; set; }
        public CustomerContactDto CustomerContact { get; set; }
    }

}
