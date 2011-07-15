using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    [Serializable]
    public class TelephoneType : IChocolate
    {

        #region Private Fields

        /// <summary>
        /// Id unico del Tipo de Telefono
        /// 
        /// </summary>
        private int _idTelephoneType;
        /// <summary>
        /// Nombre del Tipo de Telefono (Casa,Movil)
        /// </summary>
        private string _name;

        #endregion

        #region Constructor

        /// <summary>
        /// Contructor del Objeto Role
        /// </summary>
        public TelephoneType()
        {
            _idTelephoneType = 0;
            _name = "";
        }

        #endregion               

        #region Public Properties

        /// <summary>
        /// Id unico del Tipo de Telefono
        /// </summary>
        public int IdTelephoneType
        {
            get { return this._idTelephoneType; }
            set { this._idTelephoneType = value; }
        }

        /// <summary>
        /// Nombre del Tipo de Telefono
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        #endregion

        #region IChocolate Members

        /// <summary>
        /// Devuelve el nombre de la Tabla
        /// </summary>
        public string getTable()
        {
            return "PER_TELEPHONETYPE";
        }

        /// <summary>
        /// Devuelve el diseño de la Tabla entendible a los UmpaLumpas
        /// </summary>
        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdTelephoneType", new ChocoDesing(true, "ID_TELEPHONETYPE", _idTelephoneType.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            return sl;
        }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// Devuelve una instacia del Limpia Objeto
        /// </summary>
        public object Clone()
        {
            return new TelephoneType();
        }

        #endregion
    }
}
