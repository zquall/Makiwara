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
            var customersFound = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper().Contains(request.SearchCustomerQuery.ToUpper()) & x.CLI_Activo == 1).OrderBy(y => y.CLI_Nombre).Take(maximunResultRows).ToList();
            
            // Add customers to the list
            if (customersFound != null)
            {
                // Fill the response with the customers found
                foreach (var customer in customersFound)
                {
                    // Check if the customer is already binded
                    var bindedCustomer = response.CustomerList.Where(x => x.BindCustomer.AlienId == customer.CLI_Cliente).FirstOrDefault();
                    if(bindedCustomer == null)
                    {
                        // Add customer to list
                        var tmpCustomerData = new CustomerDto();
                        tmpCustomerData.Name = customer.CLI_Nombre.Trim();
                        tmpCustomerData.Address = customer.CLI_Direccion;
                        response.CustomerList.Add(tmpCustomerData);
                    }
                    else
                    {
                        // Update customer in list
                        bindedCustomer.Name = customer.CLI_Nombre.Trim();
                        bindedCustomer.Address = customer.CLI_Direccion;
                    }

                }
            }

        }

        // Get Customer
        public CustomerResponse getCustomer(CustomerRequest request)
        {
            CustomerResponse response = new CustomerResponse();
            // Check if customers needs a binding
            if (request.CustomerId == 0 && request.Customer.Name != "")
            {                
                // Apply the search the customer
                var customerFound = Asgard._Foreing.CLI_CLIENTES.Where(x => x.CLI_Nombre.ToUpper() == request.Customer.Name.ToUpper()).FirstOrDefault();
                
                if (customerFound != null)
                {
                    // Add the Customer to Nexus
                    var newCustomer = new CustomerDto()
                    {
                        Name = customerFound.CLI_Nombre,
                        Address = customerFound.CLI_Direccion                      
                    };

                    newCustomer.BindCustomer = new BindCustomerDto { AlienId = customerFound.CLI_Cliente };

                    // Check if the Customer has a contact defined
                    if (customerFound.CLI_Contacto != null)
                    {
                        // Add Person to Contact
                        var newPerson = new PersonDto()
                        {
                            Name = customerFound.CLI_Contacto,
                            LastName = ""
                        };
                        // Add Contact to Customer
                        var newCustomerContact = new CustomerContactDto()
                        {
                            Job = "Funcionario",
                            Person = newPerson,
                            Email = "email@no.disponible"
                        };
                        newCustomer.CustomerContacts.Add(newCustomerContact);
                    }
                    response.Customer = newCustomer;
                }
            }
            return response;
        }
    }
}
