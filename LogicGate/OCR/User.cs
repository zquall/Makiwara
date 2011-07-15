using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    public class User : UserOperator, IChocolate
    {
        #region Variables Privadas

        /// <summary>
        /// Es el Id único del Usuario
        /// </summary>
        private int _idUser;
        /// <summary>
        /// Nombre de la cuenta del usuario
        /// </summary>
        private string _name;
        /// <summary>
        /// Contraseña encryptada del usuario
        /// </summary>
        private string _password;
        /// <summary>
        /// Es el Id de la ultima compañia que se logeo este usuario
        /// </summary>
        private int _lastCompany;
        /// <summary>
        /// No se que es? ni pa que sirve, Jose lo pidio pero ahorita no me acuerdo que hacia
        /// </summary>
        private int _access;
        /// <summary>
        /// El estado del Usuario
        /// </summary>
        private string _state;
        /// <summary>
        /// Especifica si el Usuario esta conectado actualmente
        /// </summary>
        private bool _online;
        /// <summary>
        /// Rol asignado al Usuario
        /// </summary>
        private Role _role;
        /// Rol asignado al Usuario
        /// </summary>
        private UserGroup _group;
        /// <summary>
        /// Objeto Persona asociado al usuario
        /// </summary>
        private Person _person;
        /// <summary>
        /// Es el Llavero que contiene las Llaves de acceso al sistema
        /// </summary>
        private KeyRing _keyRing;
        
        #endregion
        
        #region Constructor
        /// <summary>
        /// Contructor del Objeto User
        /// </summary>
        public User()
        {
            _idUser = 0;
            _name = "";
            _password = "";
            _lastCompany = 0;
            _access = 0;
            _state = "";
            _online = false;
            _role = new Role();
            _group = new UserGroup();
            _person = new Person();
            _keyRing = new KeyRing();
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Es el Id único del Usuario
        /// </summary>
        public int IdUser
        {
            get { return this._idUser; }
            set { this._idUser = value; }
        }

        /// <summary>
        /// Nombre de la cuenta del usuario
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// Contraseña encryptada del usuario
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        /// <summary>
        /// Es el Id de la ultima compañia que se logeo este usuario
        /// </summary>
        public int LastCompany
        {
            get { return this._lastCompany; }
            set { this._lastCompany = value; }
        }

        /// <summary>
        /// No se que es? ni pa que sirve, Jose lo pidio pero ahorita no me acuerdo que hacia
        /// </summary>
        public int Access
        {
            get { return this._access; }
            set { this._access = value; }
        }

        /// <summary>
        /// El estado del Usuario
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        /// <summary>
        /// Especifica si el Usuario esta conectado actualmente
        /// </summary>
        public bool Online
        {
            get { return this._online; }
            set { this._online = value; }
        }

        /// <summary>
        /// Objeto Persona asociado al usuario
        /// </summary>
        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        /// <summary>
        /// Es el Llavero que contiene las Llaves de acceso al sistema
        /// </summary>
        public UserGroup Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        /// <summary>
        /// Rol asignado al Usuario
        /// </summary>
        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }

        #endregion
        
        #region IChocolate Members

        /// <summary>
        /// Devuelve el nombre de la Tabla
        /// </summary>
        public string getTable()
        {
            return "SEG_USER";
        }

        /// <summary>
        /// Devuelve el diseño de la Tabla entendible a los UmpaLumpas
        /// </summary>
        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdUser", new ChocoDesing(true, "ID_USER", _idUser.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            sl.Add("Password", new ChocoDesing("PASSWORD", _password.GetType()));
            sl.Add("LastCompany", new ChocoDesing("LASTCOMPANY", _lastCompany.GetType()));
            sl.Add("Access", new ChocoDesing("ACCESS", _access.GetType()));
            sl.Add("State", new ChocoDesing("STATE", _state.GetType()));
            sl.Add("Online", new ChocoDesing("ONLINE", _online.GetType()));
            sl.Add("Role", new ChocoDesing(new Role(), ChocoDesing.Wrapper.OO__OO));
            sl.Add("Person", new ChocoDesing(new Person(), ChocoDesing.Wrapper.F___OO));
            sl.Add("Group", new ChocoDesing(new UserGroup(), ChocoDesing.Wrapper.OO__OO));
            

            return sl;
        }


        #endregion

        public override string ToString()
        {
            return _person.Name + " " + _person.LastName;
        }

        #region UserOperator Members


        public KeyRing KeyRing
        {
            get
            {
                return _group.KeyRing;
            }
        }

        #endregion
    }
}
