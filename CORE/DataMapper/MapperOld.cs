using System;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using System.Data.Objects.DataClasses;
using CORE.Services;

namespace CORE.DataMapper
{
    internal static class MapperOld
    {
        internal static CustomerDto Map(Nexus.Customer customer)
        {
            CustomerDto tmpCustomerData = null;
            if (customer != null)
            {
                tmpCustomerData = new CustomerDto();
                tmpCustomerData.Id = customer.Id;
                tmpCustomerData.Name = customer.Name;
                tmpCustomerData.Address = customer.Address;
            }
            return tmpCustomerData;
        }

        //internal static Nexus.Customer Map(CustomerData customerData)
        //{
        //    Nexus.Customer tmpCustomer = null;
        //    if (customerData != null)
        //    {
        //        tmpCustomer = new Nexus.Customer();
        //        tmpCustomer.Id = customerData.Id;
        //        tmpCustomer.Name = customerData.Name;
        //        tmpCustomer.Address = customerData.Address;
        //        tmpCustomer.AddressOptional = customerData.AddressOptional;
        //        tmpCustomer.Phone = customerData.Phone;
        //        tmpCustomer.Fax = customerData.Fax;
        //        //tmpCustomer.CustomerContacts = Map(customerData.ContactList);
        //    }
        //    return tmpCustomer;
        //}

        //internal static EmployeeDto Map(Nexus.Employee employee)
        //{
        //    EmployeeData tmpEmployeeData = null;
        //    if (employee != null)
        //    {
        //        tmpEmployeeData = new EmployeeData();
        //        tmpEmployeeData.Id = employee.Id;
        //        tmpEmployeeData.Person = Map(employee.Person); 
        //    }
        //    return tmpEmployeeData;
        //}

    }
}
