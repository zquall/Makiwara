using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    [Serializable]
    public class Role : IChocolate
    {

        #region Private Fields

        /// <summary>
        /// Id unico del Rol
        /// </summary>
        private int _idRole;
        /// <summary>
        /// Nombre del Rol
        /// </summary>
        private string _name;
        /// <summary>
        /// Descripcion del Rol
        /// </summary>
        private string _description;

        #endregion

        #region Constructor

        /// <summary>
        /// Contructor del Objeto Role
        /// </summary>
        public Role()
        {
            _idRole = 0;
            _name = "";
            _description = "";
        }

        #endregion               

        #region Public Properties

        /// <summary>
        /// Id unico del Rol
        /// </summary>
        public int IdRole
        {
            get { return this._idRole; }
            set { this._idRole = value; }
        }

        /// <summary>
        /// Nombre del Rol
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Descripcion del Rol
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        #endregion

        #region IChocolate Members

        /// <summary>
        /// Devuelve el nombre de la Tabla
        /// </summary>
        public string getTable()
        {
            return "SEG_ROLE";
        }

        /// <summary>
        /// Devuelve el diseño de la Tabla entendible a los UmpaLumpas
        /// </summary>
        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdRole", new ChocoDesing(true, "ID_ROLE", _idRole.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            sl.Add("Description", new ChocoDesing("DESCRIPTION", _description.GetType()));
            return sl;
        }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// Devuelve una instacia del Limpia Objeto
        /// </summary>
        public object Clone()
        {
            return new Role();
        }

        #endregion
    }
}
