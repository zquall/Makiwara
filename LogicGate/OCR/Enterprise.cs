using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    public class Enterprise : IChocolate
    {
        private int _idEnterprise;
        private string _name;
        private int _baseCurrency;

        public Enterprise()
        {
            _idEnterprise = 0;
            _name = "";
            _baseCurrency = 0;
        }

        public int IdEnterprise
        {
            get { return this._idEnterprise; }
            set { this._idEnterprise = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int BaseCurrency
        {
            get { return this._baseCurrency; }
            set { this._baseCurrency = value; }
        }
        #region IChocolate Members

        public string getTable()
        {
            return "COM_ENTERPRISE";
        }

        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdEnterprise", new ChocoDesing(true, "ID_ENTERPRISE", _idEnterprise.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            sl.Add("BaseCurrency", new ChocoDesing("BASE_CURRENCY", _baseCurrency.GetType()));
            return sl;
        }

        #endregion

        

    }
}
