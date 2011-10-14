using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;

namespace CORE.Services
{
    public class CustomerService
    {
        public CustomerService()
        {
            
        }

        public CustomerResponse searchCustomer(CustomerRequest request)
        {
            const int maximunResultRows = 10;
            var response = new CustomerResponse();
            // Inicitialize the list of customers
            response.CustomerList = new List<CustomerData>();
            // Get customers from respective employee
            var tmpEmployee = Olympus._Enterprise.Employees.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();
            // Apply the search with the pattern given
            var customersFounded = tmpEmployee.Customers.Where(x => x.Name.ToUpperInvariant().Contains(request.SearchCustomerQuery.ToUpperInvariant())).OrderBy(y => y.Name).Take(maximunResultRows).ToList();
            if (customersFounded != null)
            {                
                // Fill the response with the customers founded
                foreach (var customer in customersFounded)
                {
                    CustomerData tmpCustomerData = new CustomerData();
                    tmpCustomerData.Id = customer.Id;
                    tmpCustomerData.Name = customer.Name;
                    tmpCustomerData.Address = customer.Address;
                    response.CustomerList.Add(tmpCustomerData);
                }
            }
            return response;
        }
    }
}
