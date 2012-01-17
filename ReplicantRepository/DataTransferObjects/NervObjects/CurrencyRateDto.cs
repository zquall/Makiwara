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

namespace ReplicantRepository.DataTransferObjects.NervObjects
{
    
    [DataContract(Name = "CurrencyRateDto", Namespace = "http://core.renteco.com/dto/" , IsReference = true) ]
    public partial class CurrencyRateDto
    {
         #region Primitive Properties
    
    	[DataMember]
        public virtual int Id
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual int CurrencyId
        {
     
    
            get { return _currencyId; }
            set
            {
                if (_currencyId != value)
                {
                    if (Currency != null && Currency.Id != value)
                    {
                        Currency = null;
                    }
                    _currencyId = value;
                }
            }
        }
        private int _currencyId;
    
    	[DataMember]
        public virtual double Buy
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual double Sell
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual System.DateTime IssueDate
        {
            get;
            set;
        }
    
    	[DataMember]
        public virtual int CurrencyIdReference
        {
     
    
            get { return _currencyIdReference; }
            set
            {
                if (_currencyIdReference != value)
                {
                    if (Currency1 != null && Currency1.Id != value)
                    {
                        Currency1 = null;
                    }
                    _currencyIdReference = value;
                }
            }
        }
        private int _currencyIdReference;
    
    	[DataMember]
        public virtual int UserId
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
    	[DataMember]
        public virtual CurrencyDto Currency
        {
            get { return _currency; }
            set
            {
                if (!ReferenceEquals(_currency, value))
                {
                    var previousValue = _currency;
                    _currency = value;
                    FixupCurrency(previousValue);
                }
            }
        }
        private CurrencyDto _currency;
    
    	[DataMember]
        public virtual CurrencyDto Currency1
        {
            get { return _currency1; }
            set
            {
                if (!ReferenceEquals(_currency1, value))
                {
                    var previousValue = _currency1;
                    _currency1 = value;
                    FixupCurrency1(previousValue);
                }
            }
        }
        private CurrencyDto _currency1;

        #endregion
        #region Association Fixup
    
        private void FixupCurrency(CurrencyDto previousValue)
        {
            if (previousValue != null && previousValue.CurrencyRates.Contains(this))
            {
                previousValue.CurrencyRates.Remove(this);
            }
    
            if (Currency != null)
            {
                if (!Currency.CurrencyRates.Contains(this))
                {
                    Currency.CurrencyRates.Add(this);
                }
                if (CurrencyId != Currency.Id)
                {
                    CurrencyId = Currency.Id;
                }
            }
        }
    
        private void FixupCurrency1(CurrencyDto previousValue)
        {
            if (previousValue != null && previousValue.CurrencyRates1.Contains(this))
            {
                previousValue.CurrencyRates1.Remove(this);
            }
    
            if (Currency1 != null)
            {
                if (!Currency1.CurrencyRates1.Contains(this))
                {
                    Currency1.CurrencyRates1.Add(this);
                }
                if (CurrencyIdReference != Currency1.Id)
                {
                    CurrencyIdReference = Currency1.Id;
                }
            }
        }

        #endregion
    }
}