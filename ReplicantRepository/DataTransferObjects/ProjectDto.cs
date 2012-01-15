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
    
    [DataContract(Name = "ProjectDto", Namespace = "http://core.renteco.com/dto/" , IsReference = true) ]
    public partial class ProjectDto
    {
         #region Primitive Properties
    
    	[DataMember]
        public virtual int Id
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual int BudgetRequestId
        {
     
    
            get { return _budgetRequestId; }
            set
            {
                if (_budgetRequestId != value)
                {
                    if (BudgetRequest != null && BudgetRequest.Id != value)
                    {
                        BudgetRequest = null;
                    }
                    _budgetRequestId = value;
                }
            }
        }
        private int _budgetRequestId;
    
    	[DataMember]
        public virtual int CustumerId
        {
     
    
            get { return _custumerId; }
            set
            {
                if (_custumerId != value)
                {
                    if (Customer != null && Customer.Id != value)
                    {
                        Customer = null;
                    }
                    _custumerId = value;
                }
            }
        }
        private int _custumerId;
    
    	[DataMember]
        public virtual int EmployeeId
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual string Name
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual bool ManagementApproval
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual bool CxcApproval
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual System.DateTime CreateDate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double ContingenciesRate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double GuaranteeRate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double TotalUtilityRate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double DiscountRate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double SalesTax
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double OthersRate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual string Comments
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	[DataMember]
        public virtual BudgetRequestDto BudgetRequest
        {
            get { return _budgetRequest; }
            set
            {
                if (!ReferenceEquals(_budgetRequest, value))
                {
                    var previousValue = _budgetRequest;
                    _budgetRequest = value;
                    FixupBudgetRequest(previousValue);
                }
            }
        }
        private BudgetRequestDto _budgetRequest;
    
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
        public virtual ICollection<TaskDto> Tasks
        {
            get
            {
                if (_tasks == null)
                {
                    var newCollection = new FixupCollection<TaskDto>();
                    newCollection.CollectionChanged += FixupTasks;
                    _tasks = newCollection;
                }
                return _tasks;
            }
            set
            {
                if (!ReferenceEquals(_tasks, value))
                {
                    var previousValue = _tasks as FixupCollection<TaskDto>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTasks;
                    }
                    _tasks = value;
                    var newValue = value as FixupCollection<TaskDto>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTasks;
                    }
                }
            }
        }
        private ICollection<TaskDto> _tasks;

        #endregion
        #region Association Fixup
    
        private void FixupBudgetRequest(BudgetRequestDto previousValue)
        {
            if (previousValue != null && previousValue.Projects.Contains(this))
            {
                previousValue.Projects.Remove(this);
            }
    
            if (BudgetRequest != null)
            {
                if (!BudgetRequest.Projects.Contains(this))
                {
                    BudgetRequest.Projects.Add(this);
                }
                if (BudgetRequestId != BudgetRequest.Id)
                {
                    BudgetRequestId = BudgetRequest.Id;
                }
            }
        }
    
        private void FixupCustomer(CustomerDto previousValue)
        {
            if (previousValue != null && previousValue.Projects.Contains(this))
            {
                previousValue.Projects.Remove(this);
            }
    
            if (Customer != null)
            {
                if (!Customer.Projects.Contains(this))
                {
                    Customer.Projects.Add(this);
                }
                if (CustumerId != Customer.Id)
                {
                    CustumerId = Customer.Id;
                }
            }
        }
    
        private void FixupTasks(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (TaskDto item in e.NewItems)
                {
                    item.Project = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (TaskDto item in e.OldItems)
                {
                    if (ReferenceEquals(item.Project, this))
                    {
                        item.Project = null;
                    }
                }
            }
        }

        #endregion
    }
}
