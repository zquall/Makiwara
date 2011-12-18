using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using System.Data.Objects.DataClasses;

namespace CORE.DataMapper
{
    internal static class Mapper
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

        internal static ContactData Map(Nexus.CustomerContact contact)
        {
            ContactData tmpContactData = null;
            if (contact != null)
            {
                tmpContactData = new ContactData();
                tmpContactData.Id = contact.Id;
                tmpContactData.Job = contact.Job;
                tmpContactData.Email = contact.Email;
                tmpContactData.Person = Map(contact.Person); 
            }
            return tmpContactData;
        }

        internal static List<ContactData> Map(EntityCollection<Nexus.CustomerContact> collection)
        {
            List<ContactData> list = new List<ContactData>();
            foreach (var item in collection)
            {
                var mappedData = Map(item);
                list.Add(mappedData);
            }
            return list;
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
                tmpCustomerData.ContactList = Map(customer.CustomerContacts); 
            }
            return tmpCustomerData;
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
                tmpBudgetRequestData.Customer = Map(budgetRequest.Customer);
                tmpBudgetRequestData.Employee = Map(budgetRequest.Employee); 
            }
            return tmpBudgetRequestData;
        }
    }
}
