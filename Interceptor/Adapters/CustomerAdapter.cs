using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using Interceptor.DataBase;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class CustomerAdapter
    {
        
        public CustomerAdapter()
        {

        }

        // Add aditional customers to the search
        public void searchCustomer(CustomerRequest request, CustomerResponse response)
        {
            const int maximunResultRows = 10;

            // Get customers from respective employee NEEDS IMPLEMENTATION
            // var tmpEmployee = Asgard._Foreing.CLI_CLIENTES.Where(x => x.Id == SessionManager.EmployeeId).SingleOrDefault();

            // Apply the search with the pattern given
            var customersFounded = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper().Contains(request.SearchCustomerQuery.ToUpper()) & x.CLI_Activo == 1).OrderBy(y => y.CLI_Nombre).Take(maximunResultRows).ToList();
            
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
                    response.CustomerList.Add(tmpCustomerData);
                }
            }

        }

        // Get Customer
        public void getCustomer(CustomerRequest request)
        {
            // Check if customers needs a binding
            if (request.CustomerId == 0 && request.CustomerName != "" )
            {                
                // Apply the search the customer
                var customerFound = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper() == request.CustomerName.ToUpper()).FirstOrDefault();
                
                if (customerFound != null)
                {  
                    // Add the Customer to Nexus
                    var newCustomer = new Nexus.Customer()
                    {
                        Name = customerFound.CLI_Nombre,
                        Address = customerFound.CLI_Direccion,
                        BindCustomer = new Nexus.BindCustomer(){AlienId = customerFound.CLI_Cliente}
                    };

                    // Check if the Customer has a contact defined
                    if (customerFound.CLI_Contacto != null)
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
                            Person = newPerson,
                            Email = "email@no.disponible"
                        };
                        newCustomer.CustomerContacts.Add(newCustomerContact);
                    }         

                    // First save the new customer
                    Olympus._Enterprise.Customers.AddObject(newCustomer); 
                    Olympus._Enterprise.SaveChanges();
                    
                    // Add the customer Id
                    request.CustomerId = newCustomer.Id;
                }
            }           
        }
    }
}
