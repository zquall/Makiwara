using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;
using Interceptor.Adapters;

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
            const int maximunResultRows = 10;
            var response = new CustomerResponse();
            // Inicitialize the list of customers
            response.CustomerList = new List<CustomerData>();

            // *** Removed functionality ***
            // Get customers from respective employee
            // var tmpEmployee = Olympus._Enterprise.Employees.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();
            // Apply the search with the pattern given
            //var customersFounded = tmpEmployee.Customers.Where(x => x.Name.ToUpperInvariant().Contains(request.SearchCustomerQuery.ToUpperInvariant())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();

            // Search customers without employee restriction
            var customersFound = Olympus._Enterprise.Customers.Where(x => x.Name.Contains(request.SearchCustomerQuery)).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            
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
            // Validate if the customer is from Nexus
            if (request.CustomerId > 0) 
            {
                var customerFound = Olympus._Enterprise.Customers.Where(x => x.Id == request.CustomerId ).SingleOrDefault();
                // Instance the customer reference, empty for any other data
                response.Customer = new CustomerData();
                // Mapping the Data
                response.Customer.Id = customerFound.Id;
                response.Customer.Name = customerFound.Name;
                response.Customer.Address = customerFound.Address;                
            }
            // Intercepted Method
            _CustomerAdapter.getCustomer(request, response);
            return response;
        }
    }
}
