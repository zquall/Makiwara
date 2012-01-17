using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using System.Data.Objects.DataClasses;

namespace CORE.DataMapper
{
    internal static class MapperOld
    {
        internal static PhoneData Map(Nexus.PersonPhone phone)
        {
            PhoneData tmpPhoneData = null;
            if (phone != null)
            {
                tmpPhoneData = new PhoneData();
                tmpPhoneData.Id = phone.Id;
                tmpPhoneData.PhoneNumber = phone.Phone;
                tmpPhoneData.PhoneType = Map(phone.PhoneType); 
            }
            return tmpPhoneData;
        }

        internal static List<PhoneData> Map(EntityCollection<Nexus.PersonPhone> collection)
        {
            List<PhoneData> list = new List<PhoneData>();
            foreach (var item in collection)
            {
                var mappedData = Map(item);
                list.Add(mappedData);
            }
            return list;
        }

        internal static PhoneTypeData Map(Nexus.PhoneType phoneType)
        {
            PhoneTypeData tmpPhoneTypeData = null;
            if (phoneType != null)
            {
                tmpPhoneTypeData = new PhoneTypeData();
                tmpPhoneTypeData.Id = phoneType.Id;
                tmpPhoneTypeData.Name = phoneType.Name; 
            }
            return tmpPhoneTypeData;
        }

        internal static PersonData Map(Nexus.Person person)
        {
            PersonData tmpPersonData = null;
            if (person != null) { 
                tmpPersonData = new PersonData();
                tmpPersonData.Id = person.Id;
                tmpPersonData.Name = person.Name;
                tmpPersonData.LastName = person.LastName;
                tmpPersonData.PhoneList = Map(person.PersonPhones);
            }
            return tmpPersonData;
        }

        internal static CustomerData Map(Nexus.Customer customer)
        {
            CustomerData tmpCustomerData = null;
            if (customer != null)
            {
                tmpCustomerData = new CustomerData();
                tmpCustomerData.Id = customer.Id;
                tmpCustomerData.Name = customer.Name;
                tmpCustomerData.Address = customer.Address;
            }
            return tmpCustomerData;
        }

        internal static Nexus.Customer Map(CustomerData customerData)
        {
            Nexus.Customer tmpCustomer = null;
            if (customerData != null)
            {
                tmpCustomer = new Nexus.Customer();
                tmpCustomer.Id = customerData.Id;
                tmpCustomer.Name = customerData.Name;
                tmpCustomer.Address = customerData.Address;
                tmpCustomer.AddressOptional = customerData.AddressOptional;
                tmpCustomer.Phone = customerData.Phone;
                tmpCustomer.Fax = customerData.Fax;
                //tmpCustomer.CustomerContacts = Map(customerData.ContactList);
            }
            return tmpCustomer;
        }

        internal static EmployeeData Map(Nexus.Employee employee)
        {
            EmployeeData tmpEmployeeData = null;
            if (employee != null)
            {
                tmpEmployeeData = new EmployeeData();
                tmpEmployeeData.Id = employee.Id;
                tmpEmployeeData.Person = Map(employee.Person); 
            }
            return tmpEmployeeData;
        }

        internal static BudgetRequestData Map(Nexus.BudgetRequest budgetRequest)
        {
            BudgetRequestData tmpBudgetRequestData = null;
            if (budgetRequest != null)
            {
                tmpBudgetRequestData = new BudgetRequestData();
                tmpBudgetRequestData.Id = budgetRequest.Id;
                tmpBudgetRequestData.DateModified = budgetRequest.DateModified;
                tmpBudgetRequestData.Customer = AutoMapper.Mapper.Map<CustomerDto>(budgetRequest.Customer);
                tmpBudgetRequestData.Employee = Map(budgetRequest.Employee); 
            }
            return tmpBudgetRequestData;
        }
    }
}
