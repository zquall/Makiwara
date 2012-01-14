using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;

namespace CORE.Services
{
    public class CustomerService
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
                // Instance the customer reference, empty for any other data
                response.Customer = Mapper.Map(customerFound);               
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
                foreach (var phone in request.Contact.Person.PhoneList)
                {
                    if (phone.Id != 0)
                    {
                        var tmpPhone = contactFound.Person.PersonPhones.Where(x => x.Id == phone.Id).SingleOrDefault();
                        tmpPhone.Phone = phone.PhoneNumber;
                        tmpPhone.PhoneTypeId = phone.PhoneType.Id;
                    }
                    else
                    {
                        var tmpPhone = new PersonPhone();
                        tmpPhone.Phone = phone.PhoneNumber;
                        tmpPhone.PhoneTypeId = phone.PhoneType.Id;
                        contactFound.Person.PersonPhones.Add(tmpPhone);
                    }
                }
                Olympus._Enterprise.SaveChanges();
            }
        }

        public void saveCustomer(CustomerRequest request)
        {
            // Validate if saves a new customer
            if (request.Customer.Id == 0)
            {
                Customer customer = new Customer();
                customer.Name = request.Customer.Name;
                customer.Address = request.Customer.Address;
                customer.AddressOptional = request.Customer.AddressOptional;
                customer.Phone = request.Customer.Phone;
                customer.Fax = request.Customer.Fax;


                var contactFound = Olympus._Enterprise.CustomerContacts.Where(x => x.Id == request.Contact.Id).SingleOrDefault();
                contactFound.Person.Name = request.Contact.Person.Name;
                contactFound.Person.LastName = request.Contact.Person.LastName;
                contactFound.Job = request.Contact.Job;
                foreach (var phone in request.Contact.Person.PhoneList)
                {
                    if (phone.Id != 0)
                    {
                        var tmpPhone = contactFound.Person.PersonPhones.Where(x => x.Id == phone.Id).SingleOrDefault();
                        tmpPhone.Phone = phone.PhoneNumber;
                        tmpPhone.PhoneTypeId = phone.PhoneType.Id;
                    }
                    else
                    {
                        var tmpPhone = new PersonPhone();
                        tmpPhone.Phone = phone.PhoneNumber;
                        tmpPhone.PhoneTypeId = phone.PhoneType.Id;
                        contactFound.Person.PersonPhones.Add(tmpPhone);
                    }
                }
                Olympus._Enterprise.SaveChanges();
            }
        }

    }
}
