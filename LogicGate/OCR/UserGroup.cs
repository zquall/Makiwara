using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    [Serializable]
    public class UserGroup : IChocolate
    {
        #region Private Fields

        /// <summary>
        /// Id unico del Grupo
        /// </summary>
        private int _idGroup;
        /// <summary>
        /// Nombre del Grupo
        /// </summary>
        private string _name;
        /// <summary>
        /// Descripcion del Grupo
        /// </summary>
        private string _description;
        /// <summary>
        /// Llavero asignado al grupo
        /// </summary>
        private KeyRing _keyRing;
        /// <summary>
        /// Las Llaves del Llavero
        /// </summary>
        private List<KeyAccess> _listKeyAccess;
        #endregion

        #region Constructor

        /// <summary>
        /// Contructor del Grupo
        /// </summary>
        public UserGroup()
        {
            _idGroup = 0;
            _name = "";
            _description = "";
            _keyRing = new KeyRing();
            _listKeyAccess = new List<KeyAccess>();
        }

        #endregion               

        #region Public Properties

        /// <summary>
        /// Id unico del Grupo
        /// </summary>
        public int IdGroup
        {
            get { return this._idGroup; }
            set { this._idGroup = value; }
        }

        /// <summary>
        /// Nombre del Grupo
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Descripcion del Grupo
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        /// <summary>
        /// Llavero del Grupo
        /// </summary>
        public KeyRing KeyRing
        {
            get { return this._keyRing; }
            set { this._keyRing = value; }
        }

        /// <summary>
        /// Llavero del Grupo
        /// </summary>
        public List<KeyAccess> ListKeyAccess
        {
            get { return this._listKeyAccess; }
            set 
            { 
                this._listKeyAccess = value;
                this._keyRing.addKeyAccessList(value);
            }
        }

        #endregion

        #region IChocolate Members

        /// <summary>
        /// Devuelve el nombre de la Tabla
        /// </summary>
        public string getTable()
        {
            return "SEG_USER_GROUP";
        }

        /// <summary>
        /// Devuelve el diseño de la Tabla entendible a los UmpaLumpas
        /// </summary>
        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdGroup", new ChocoDesing(true, "ID_GROUP", _idGroup.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            sl.Add("Description", new ChocoDesing("DESCRIPTION", _description.GetType()));
            sl.Add("ListKeyAccess", new ChocoDesing(new KeyAccess(), ChocoDesing.Wrapper.F___OO));
            return sl;
        }
        #endregion
             
    }
}
