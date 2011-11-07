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
            
            // Remove Customers that already exist on Nexus, using a reverse loop
            for (int i = customersFounded.Count; i > 0 ; i--)
            {
                var customerAlienId = customersFounded[i-1].CLI_Cliente;
                var customerBinded = Olympus._Enterprise.BindCustomers.Where(x => x.AlienId == customerAlienId).SingleOrDefault();
                // if the procees finds the customer then it must deleted from the results of the search
                if (customerBinded != null)
                {
                    customersFounded.RemoveAt(i-1);
                }                
            }

            // add customers to the list
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

        public void getCustomer(int idCustomer, string customerName, CustomerResponse reponse)
        {
            // Check if customers needs a binding
            if (idCustomer == 0 && customerName != "" && reponse.Customer == null)
            {                
                // Apply the search the customer
                var customerFound = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper() == customerName.ToUpper()).FirstOrDefault();
                if (customerFound != null)
                {
                    
                    // Add Person to Contact
                    var newPerson = new Nexus.Person()
                    {
                        Name = customerFound.CLI_Contacto,
                        LastName = ""                        
                    };
                    // Add Contact to Customer
                    var newCustomerContact = new Nexus.CustomerContact()
                    {
                        Job = "Funcionario",
                        Person = newPerson
                    };

                    // Bind the customer
                    var bindCustomer = new Nexus.BindCustomer()
                    {
                        AlienId = customerFound.CLI_Cliente
                    };


                    // Add the Customer to Nexus
                    var newCustomer = new Nexus.Customer()
                    {
                        Name = customerFound.CLI_Nombre,
                        Address = customerFound.CLI_Direccion,
                        BindCustomer = bindCustomer
                    };

                    newCustomer.CustomerContacts.Add(newCustomerContact);

                    // First save the client to get the respective Id
                    Olympus._Enterprise.Customers.AddObject(newCustomer); 
                    Olympus._Enterprise.SaveChanges();
                    
                    // Instance the customer reference, empty for any other data
                    reponse.Customer = new CustomerData();
                    // Mapping the Data
                    reponse.Customer.Id = newCustomer.Id;
                    reponse.Customer.Name = newCustomer.Name;
                    reponse.Customer.Address = newCustomer.Address;
                }
            }
            else
            {
            }            
        }
    }
}
