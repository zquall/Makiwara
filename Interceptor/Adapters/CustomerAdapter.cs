using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using Interceptor.DataBase;

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

        public void getCustomer(int idCustomer, string customerName, CustomerData customer)
        {
            // Check if customers needs a binding
            if (idCustomer == 0 && customerName != "" && customer == null)
            {                
                // Apply the search the customer
                var customerFound = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper() == customerName.ToUpper()).FirstOrDefault();
                if (customerFound != null)
                {
                    // Instance the customer reference
                    customer = new CustomerData();

                    // Add the Customer to Nexus
                    var newCustomer = new Nexus.Customer() { 
                        Name = customerFound.CLI_Nombre,
                        Address = customerFound.CLI_Direccion
                    };
                    Olympus._Enterprise.Customers.AddObject(newCustomer);
                    Olympus._Enterprise.SaveChanges();                     

                    // Bind the customer
                    var binding = new Nexus.BindCustomer()
                    {
                        CustomerId = newCustomer.Id,
                        AlienId = customerFound.CLI_Nombre
                    };
                    Olympus._Enterprise.BindCustomers.AddObject(binding);
                    Olympus._Enterprise.SaveChanges();

                    // Mapping the Data
                    customer.Id = newCustomer.Id;
                    customer.Name = newCustomer.Name;
                    customer.Address = newCustomer.Address;
                }
            }
            else
            {
            }            
        }
    }
}
