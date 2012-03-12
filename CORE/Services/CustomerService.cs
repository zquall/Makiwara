using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly CustomerAdapter _customerAdapter;

        public CustomerService()
        {
            _customerAdapter = new CustomerAdapter();
        }

        // Search Customers
        public CustomerResponse SearchCustomer(CustomerRequest request)
        {
            var response = new CustomerResponse {CustomerList = new List<CustomerDto>()};

            // *** Removed functionality ***
            // Get customers from respective employee
            // var tmpEmployee = Olympus._Enterprise.Employees.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();
            // Apply the search with the pattern given
            //var customersFounded = tmpEmployee.Customers.Where(x => x.Name.ToUpperInvariant().Contains(request.SearchCustomerQuery.ToUpperInvariant())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();

            // Search customers without employee restriction
            var customersFound = Olympus._Enterprise.Customers.Where(x => x.Name.Contains(request.SearchCustomerQuery)).OrderBy(y => y.Name).Take(Convert.ToInt32(Properties.Resources.MaximunResultRows)).Distinct().ToList();
            
            if (customersFound.Count > 0 )
            {                
                // Fill the response with the customers founded
                foreach (var customer in customersFound)
                {
                    var tmpCustomerData = new CustomerDto
                                                      {
                                                          Id = customer.Id,
                                                          Name = customer.Name,
                                                          Address = customer.Address
                                                      };
                    response.CustomerList.Add(tmpCustomerData);
                }
            }

            // Intercepted Method
            _customerAdapter.searchCustomer(request, response);

            // Sorted again the list
            response.CustomerList = response.CustomerList.OrderBy(x => x.Name).ToList();
            
            return response;
        }

        public CustomerResponse GetCustomer(CustomerRequest request)
        {
            var response = new CustomerResponse();
           
            #region *** Intercepted Method ***
            // Try to bind a customer from Dialcom to Nexus
            if (request.CustomerId == 0)
            {
                request.CustomerId = SaveCustomer(new CustomerRequest { Customer = _customerAdapter.getCustomer(request).Customer }).CustomerId;
            }            
            #endregion

            // Validate if the customer is from Nexus
            if (request.CustomerId > 0) 
            {
                var customerFound = Olympus._Enterprise.Customers.Where(x => x.Id == request.CustomerId).SingleOrDefault();
                Olympus._Enterprise.Detach(customerFound);
                response.Customer = Mapper.Map<CustomerDto>(customerFound);
                response.Customer.CustomerContacts = GetCustomerContacts(request).CustomerContacts;
            }
            return response;
        }

        public CustomerResponse GetCustomerContact(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Validate request
            if (request.CustomerContactId > 0)
            {
                var customerContactFound = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.CustomerContactId).SingleOrDefault();
                response.CustomerContact = Mapper.Map<CustomerContactDto>(customerContactFound);
            }
            return response;
        }

        public CustomerResponse GetCustomerContacts(CustomerRequest request)
        {
            var response = new CustomerResponse();
            if (request.CustomerId > 0)
            {
                response.CustomerContacts = new List<CustomerContactDto>();
                var customerContactList = Olympus._Enterprise.CustomerContacts.Where(x => x.CustomerId == request.CustomerId);
               
                response.CustomerContacts = Mapper.Map<List<CustomerContactDto>>(customerContactList);
               
            }
            return response;
        }

        public CustomerResponse SaveCustomerContact(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Validate contact has a customer related
            if (request.CustomerContactId > 0)
            {
                CustomerContact contact;
                // Check if Edit or Add
                if (request.CustomerContact.Id > 0)
                {
                    // Edit
                    contact = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.CustomerContact.Id).SingleOrDefault();
                    Mapper.Map(request.CustomerContact, contact);
                }else{
                    // Add
                    contact = Mapper.Map<CustomerContact>(request.CustomerContact);
                    Olympus._Enterprise.CustomerContacts.AddObject(contact);
                }
                Olympus._Enterprise.SaveChanges();
                if (contact != null) response.CustomerContactId = contact.Id;
            }
            return response;
        }

        public CustomerResponse SaveCustomer(CustomerRequest request)
        {
            var response = new CustomerResponse();
            if (request.Customer != null)
            {
                // Check if is a new customer
                if (request.Customer.Id == 0)
                {
                    // Map the Customer with Contacts
                    Customer customer = Mapper.Map<CustomerDto, Customer>(request.Customer);
                    Olympus._Enterprise.Customers.AddObject(customer);
                    Olympus._Enterprise.SaveChanges();
                    response.CustomerId = customer.Id;
                }
            }
            return response;
        }
    }
}
