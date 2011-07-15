using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    [Serializable]
    public class Telephone : IChocolate
    {

        #region Private Fields

        /// <summary>
        /// Id unico del Rol
        /// </summary>
        private int _idTelephone;
        /// <summary>
        /// Nombre del Rol
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Descripcion del Rol
        /// </summary>
        private int _phoneType;

        #endregion

        #region Constructor

        /// <summary>
        /// Contructor del Objeto Role
        /// </summary>
        public Telephone()
        {
            _idTelephone = 0;
            _phoneNumber = "";
            _phoneType = 0;
        }

        #endregion               

        #region Public Properties

        /// <summary>
        /// Id unico del Rol
        /// </summary>
        public int IdTelephone
        {
            get { return this._idTelephone; }
            set { this._idTelephone = value; }
        }

        /// <summary>
        /// Nombre del Rol
        /// </summary>
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        /// <summary>
        /// Descripcion del Rol
        /// </summary>
        public int TelephoneType
        {
            get { return this._phoneType; }
            set { this._phoneType = value; }
        }

        #endregion

        #region IChocolate Members

        /// <summary>
        /// Devuelve el nombre de la Tabla
        /// </summary>
        public string getTable()
        {
            return "PER_TELEPHONE";
        }

        /// <summary>
        /// Devuelve el diseño de la Tabla entendible a los UmpaLumpas
        /// </summary>
        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdTelephone", new ChocoDesing(true, "ID_TELEPHONE", _idTelephone.GetType()));
            sl.Add("PhoneNumber", new ChocoDesing("PHONENUMBER", _phoneNumber.GetType()));
            sl.Add("TelephoneType", new ChocoDesing("ID_TELEPHONETYPE",_phoneType.GetType()));
            return sl;
        }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// Devuelve una instacia del Limpia Objeto
        /// </summary>
        public object Clone()
        {
            return new Telephone();
        }

        #endregion
    }
}
