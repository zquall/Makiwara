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
    
    [DataContract(Name = "ResourceTypeDto", Namespace = "http://core.renteco.com/dto/" , IsReference = true) ]
    public partial class ResourceTypeDto
    {
         #region Primitive Properties
    
    	[DataMember]
        public virtual int Id
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
        public virtual bool isTaxed
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	[DataMember]
        public virtual ICollection<ResourceDto> Resources
        {
            get
            {
                if (_resources == null)
                {
                    var newCollection = new FixupCollection<ResourceDto>();
                    newCollection.CollectionChanged += FixupResources;
                    _resources = newCollection;
                }
                return _resources;
            }
            set
            {
                if (!ReferenceEquals(_resources, value))
                {
                    var previousValue = _resources as FixupCollection<ResourceDto>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupResources;
                    }
                    _resources = value;
                    var newValue = value as FixupCollection<ResourceDto>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupResources;
                    }
                }
            }
        }
        private ICollection<ResourceDto> _resources;

        #endregion
        #region Association Fixup
    
        private void FixupResources(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ResourceDto item in e.NewItems)
                {
                    item.ResourceType = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ResourceDto item in e.OldItems)
                {
                    if (ReferenceEquals(item.ResourceType, this))
                    {
                        item.ResourceType = null;
                    }
                }
            }
        }

        #endregion
    }
}
