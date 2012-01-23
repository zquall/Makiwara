using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;
using CORE.DataMapper;

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
           
            #region *** Intercepted Method ***
            // Try to bind a customer from Dialcom to Nexus
            if (request.CustomerId == 0)
            {
                request.CustomerId = saveCustomer(new CustomerRequest() { Customer = _CustomerAdapter.getCustomer(request).Customer }).CustomerId;
            }            
            #endregion

            // Validate if the customer is from Nexus
            if (request.CustomerId > 0) 
            {
                var customerFound = Olympus._Enterprise.Customers.Where(x => x.Id == request.CustomerId).SingleOrDefault();
                Olympus._Enterprise.Detach(customerFound);
                response.Customer = Mapper.Map<CustomerDto>(customerFound);
                response.Customer.CustomerContacts = getCustomerContacts(request).CustomerContacts;
            }
            return response;
        }

        public CustomerResponse getCustomerContact(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Validate request
            if (request.ContactId > 0)
            {
                var customerContactFound = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.ContactId).SingleOrDefault();
                Olympus._Enterprise.Detach(customerContactFound);
                response.CustomerContact = MapperPaths.Map(customerContactFound);
            }
            return response;
        }

        public CustomerResponse getCustomerContacts(CustomerRequest request)
        {
            var response = new CustomerResponse();
            if (request.CustomerId > 0)
            {
                response.CustomerContacts = new List<CustomerContactDto>();
                var customerContactList = Olympus._Enterprise.CustomerContacts.Where(x => x.CustomerId == request.CustomerId);
                foreach (CustomerContact customerContact in customerContactList)
                {
                    response.CustomerContacts.Add(MapperPaths.Map(customerContact));
                }
            }
            return response;
        }

        public CustomerResponse saveContact(CustomerRequest request)
        {
            var response = new CustomerResponse();
            // Validate if the contact has to be saved
            if (request.CustomerContact.CustomerId > 0)
            {
                CustomerContact contact;

                // Check if Edit or Add
                if (request.CustomerContact.Id > 0)
                {
                    // Edit
                    contact = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.CustomerContact.Id).SingleOrDefault();
                    Mapper.Map<CustomerContactDto, CustomerContact>(request.CustomerContact, contact);
                }else{
                    // Add
                    contact = new CustomerContact();
                    contact = Mapper.Map<CustomerContact>(request.CustomerContact);
                    Olympus._Enterprise.CustomerContacts.AddObject(contact);
                }
                Olympus._Enterprise.SaveChanges();
                response.ContactId = contact.Id;

                #region Old Code
                //contact.Person.Name = request.Contact.Person.Name;
                //contact.Person.LastName = request.Contact.Person.LastName;
                //contact.Job = request.Contact.Job;
                //foreach (var tmpPersonPhone in request.Contact.Person.PersonPhones)
                //{
                //    if (tmpPersonPhone.Id == 0)
                //    {
                //        var tmpPhone = new PersonPhone();
                //        tmpPhone.Phone = tmpPersonPhone.Phone;
                //        tmpPhone.PhoneTypeId = tmpPersonPhone.PhoneType.Id;
                //        contact.Person.PersonPhones.Add(tmpPhone);
                //    }
                //    else
                //    {
                //        var tmpPhone = contact.Person.PersonPhones.Where(x => x.Id == tmpPersonPhone.Id).SingleOrDefault();
                //        tmpPhone.Phone = tmpPersonPhone.Phone;
                //        tmpPhone.PhoneTypeId = tmpPersonPhone.PhoneType.Id;
                //    }
                //} 
                #endregion
            }
            return response;
        }

        public CustomerResponse saveCustomer(CustomerRequest request)
        {
            CustomerResponse response = new CustomerResponse();
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
