﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class CustomerService : ServiceBase
    {
        protected CustomerAdapter _CustomerAdapter;

        public CustomerService()
        {
            _CustomerAdapter = new CustomerAdapter();
        }

        // Search Customers
        public CustomerResponse searchCustomer(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Inicitialize the list of customers
            response.CustomerList = new List<CustomerData>();

            // *** Removed functionality ***
            // Get customers from respective employee
            // var tmpEmployee = Olympus._Enterprise.Employees.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();
            // Apply the search with the pattern given
            //var customersFounded = tmpEmployee.Customers.Where(x => x.Name.ToUpperInvariant().Contains(request.SearchCustomerQuery.ToUpperInvariant())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();

            // Search customers without employee restriction
            var customersFound = Olympus._Enterprise.Customers.Where(x => x.Name.Contains(request.SearchCustomerQuery)).OrderBy(y => y.Name).Take(Convert.ToInt32(Properties.Resources.MaximunResultRows)).ToList();
            
            if (customersFound != null)
            {                
                // Fill the response with the customers founded
                foreach (var customer in customersFound)
                {
                    CustomerData tmpCustomerData = new CustomerData();
                    tmpCustomerData.Id = customer.Id;
                    tmpCustomerData.Name = customer.Name;
                    tmpCustomerData.Address = customer.Address;
                    response.CustomerList.Add(tmpCustomerData);
                }
            }

            // Intercepted Method
            _CustomerAdapter.searchCustomer(request, response);

            // Sorted again the list
            response.CustomerList = response.CustomerList.OrderBy(x => x.Name).ToList();
            
            return response;
        }

        public CustomerResponse getCustomer(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Intercepted Method
            _CustomerAdapter.getCustomer(request);
            // Validate if the customer is from Nexus
            if (request.Customer.Id > 0) 
            {
                var customerFound = Olympus._Enterprise.Customers.Where(x => x.Id == request.Customer.Id).SingleOrDefault();
                Olympus._Enterprise.Detach(customerFound);
                response.Customer = Mapper.Map<CustomerDto>(customerFound);
                response.Customer.CustomerContacts = getCustomerContacts(request).Customer.CustomerContacts;
            }
            return response;
        }

        public CustomerResponse getCustomerContacts(CustomerRequest request)
        {
            var response = new CustomerResponse();
            if (request.Customer.Id > 0)
            {
                var customerContactList = Olympus._Enterprise.CustomerContacts.Where(x => x.CustomerId == request.Customer.Id);
                response.Customer.CustomerContacts = Mapper.Map<ICollection<CustomerContactDto>>(customerContactList);
            }
            return response;
        }

        public void saveContact(CustomerRequest request)
        {
            // Validate if the contact Exist
            if (request.Contact.Id > 0)
            {
                var contactFound = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.Contact.Id ).SingleOrDefault();
                contactFound.Person.Name = request.Contact.Person.Name;
                contactFound.Person.LastName = request.Contact.Person.LastName;
                contactFound.Job = request.Contact.Job;
                foreach (var tmpPersonPhone in request.Contact.Person.PersonPhones)
                {
                    if (tmpPersonPhone.Id == 0)
                    {
                        var tmpPhone = new PersonPhone();
                        tmpPhone.Phone = tmpPersonPhone.Phone;
                        tmpPhone.PhoneTypeId = tmpPersonPhone.PhoneType.Id;
                        contactFound.Person.PersonPhones.Add(tmpPhone);
                    }
                    else
                    {
                        var tmpPhone = contactFound.Person.PersonPhones.Where(x => x.Id == tmpPersonPhone.Id).SingleOrDefault();
                        tmpPhone.Phone = tmpPersonPhone.Phone;
                        tmpPhone.PhoneTypeId = tmpPersonPhone.PhoneType.Id;
                    }
                }
                Olympus._Enterprise.SaveChanges();
            }
        }

        public CustomerResponse saveCustomer(CustomerRequest request)
        {
            CustomerResponse response = new CustomerResponse();
            // Check if is a new customer
            if (request.Customer.Id == 0)
            {
                // Map the Customer with Contacts
                Customer customer = Mapper.Map<CustomerDto, Customer>(request.Customer);
                Olympus._Enterprise.Customers.AddObject(customer);
                Olympus._Enterprise.SaveChanges();
                response.Customer = new CustomerDto();
                response.Customer.Id = customer.Id;
            }
            return response;
        }
    }
}
