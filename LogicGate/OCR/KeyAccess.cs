using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WillyWonka;

namespace LogicGate.OCR
{
    public class KeyAccess : IChocolate
        {
            private int _idGroup;
            private int _idModule;
            private int _keyValue;


            public KeyAccess()
            {
                _idGroup = 0;
                _idModule = 0;
                _keyValue = 0;
            }

            public int IdGroup
            {
                get { return this._idGroup; }
                set { this._idGroup = value; }
            }

            public int IdModule
            {
                get { return this._idModule; }
                set { this._idModule = value; }
            }

            public int keyValue
            {
                get { return this._keyValue; }
                set { this._keyValue = value; }
            }

            #region IChocolate Members

            public string getTable()
            {
                return "SEG_KEYACCESS";
            }

            public SortedList<string, ChocoDesing> getDesing()
            {
                SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
                sl.Add("IdGroup", new ChocoDesing("ID_GROUP", _idGroup.GetType()));
                sl.Add("IdModule", new ChocoDesing("ID_MODULE", _idModule.GetType()));
                sl.Add("keyValue", new ChocoDesing("KEYVALUE", _keyValue.GetType()));
                return sl;
            }
            #endregion
        }
}
