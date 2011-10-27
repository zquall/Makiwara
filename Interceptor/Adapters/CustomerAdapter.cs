using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace Interceptor.Adapters
{
    public class CustomerAdapter
    {
        
        public CustomerAdapter()
        {

        }

        public void searchCustomer(string SearchCustomerQuery, List<CustomerData> CustomerList)
        {
            const int maximunResultRows = 10;

            // Get customers from respective employee NEEDS IMPLEMENTATION
            // var tmpEmployee = Asgard._Foreing.CLI_CLIENTES.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();

            // Apply the search with the pattern given
            var customersFounded = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper().Contains(SearchCustomerQuery.ToUpper())).OrderBy(y => y.CLI_Nombre).Take(maximunResultRows).ToList();
            if (customersFounded != null)
            {
                // Fill the response with the customers founded
                foreach (var customer in customersFounded)
                {
                    CustomerData tmpCustomerData = new CustomerData();
                    tmpCustomerData.Name = customer.CLI_Nombre.Trim();
                    tmpCustomerData.Address = customer.CLI_Direccion;
                    CustomerList.Add(tmpCustomerData);
                }
            }
        }






    }
}
