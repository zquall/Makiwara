//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace ReplicantRepository.DataTransferObjects
{
    
    [DataContract(Name = "CustomerContactDto", Namespace = "http://core.renteco.com/dto/" , IsReference = true) ]
    public partial class CustomerContactDto
    {
         #region Primitive Properties
    
    	[DataMember]
        public virtual int Id
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual string Job
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual int PersonId
        {
     
    
            get { return _personId; }
            set
            {
                if (_personId != value)
                {
                    if (Person != null && Person.Id != value)
                    {
                        Person = null;
                    }
                    _personId = value;
                }
            }
        }
        private int _personId;
    
    	[DataMember]
        public virtual int CustomerId
        {
     
    
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    if (Customer != null && Customer.Id != value)
                    {
                        Customer = null;
                    }
                    _customerId = value;
                }
            }
        }
        private int _customerId;
    
    	[DataMember]
        public virtual string Email
        {
            get;
            set;
        }
    	// Custom ToString() Method using reflection
    	// Autor: Jaime Torner
    	public override string ToString() 
    	{		
    		return CustomToStringMethods.ToString(this);
    	}
    

        #endregion
        #region Navigation Properties
    
    	[DataMember]
        public virtual CustomerDto Customer
        {
            get { return _customer; }
            set
            {
                if (!ReferenceEquals(_customer, value))
                {
                    var previousValue = _customer;
                    _customer = value;
                    FixupCustomer(previousValue);
                }
            }
        }
        private CustomerDto _customer;
    
    	[DataMember]
        public virtual PersonDto Person
        {
            get { return _person; }
            set
            {
                if (!ReferenceEquals(_person, value))
                {
                    var previousValue = _person;
                    _person = value;
                    FixupPerson(previousValue);
                }
            }
        }
        private PersonDto _person;

        #endregion
        #region Association Fixup
    
        private void FixupCustomer(CustomerDto previousValue)
        {
            if (previousValue != null && previousValue.CustomerContacts.Contains(this))
            {
                previousValue.CustomerContacts.Remove(this);
            }
    
            if (Customer != null)
            {
                if (!Customer.CustomerContacts.Contains(this))
                {
                    Customer.CustomerContacts.Add(this);
                }
                if (CustomerId != Customer.Id)
                {
                    CustomerId = Customer.Id;
                }
            }
        }
    
        private void FixupPerson(PersonDto previousValue)
        {
            if (previousValue != null && previousValue.CustomerContacts.Contains(this))
            {
                previousValue.CustomerContacts.Remove(this);
            }
    
            if (Person != null)
            {
                if (!Person.CustomerContacts.Contains(this))
                {
                    Person.CustomerContacts.Add(this);
                }
                if (PersonId != Person.Id)
                {
                    PersonId = Person.Id;
                }
            }
        }

        #endregion
    }
}
