using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    [Serializable]
    public class Person : IChocolate
    {
        private int _idPerson;
        private int _idUser;
        private string _name;
        private string _lastName;
        private string _gender;
        private string _nationality;
        private string _civilStatus;
        private DateTime _birthday;
        private List<Telephone> _telephoneList;

        public Person()
        {
            _idPerson = 0;
            _idUser = 0;
            _name = "";
            _lastName = "";
            _gender = "";
            _nationality = "";
            _civilStatus = "";
            _birthday = new DateTime();
            _telephoneList = new List<Telephone>();
        }

        #region Public Properties

        public int IdPerson
        {
            get { return this._idPerson; }
            set { this._idPerson = value; }
        }

        public int IdUser
        {
            get { return this._idUser; }
            set { this._idUser = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public string Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

        public string Nationality
        {
            get { return this._nationality; }
            set { this._nationality = value; }
        }

        public string CivilStatus
        {
            get { return this._civilStatus; }
            set { this._civilStatus = value; }
        }

        public DateTime Birthday
        {
            get { return this._birthday; }
            set { this._birthday = value; }
        }

        public List<Telephone> TelephoneList
        {
            get { return this._telephoneList; }
            set { this._telephoneList = value; }
        }

        #endregion

        public override string ToString()
        {
            return _idPerson + " - " + _name + " " + _lastName;
        }

        #region IChocolate Members

        public string getTable()
        {
            return "PER_PERSON";
        }

        public SortedList<string, ChocoDesing> getDesing()
        {
            SortedList<string, ChocoDesing> sl = new SortedList<string, ChocoDesing>();
            sl.Add("IdPerson", new ChocoDesing(true, "ID_PERSON", _idPerson.GetType()));
            sl.Add("IdUser", new ChocoDesing("ID_USER", _idUser.GetType()));
            sl.Add("Name", new ChocoDesing("NAME", _name.GetType()));
            sl.Add("LastName", new ChocoDesing("LASTNAME", _lastName.GetType()));
            sl.Add("Gender", new ChocoDesing("GENDER", _gender.GetType()));
            sl.Add("Nationality", new ChocoDesing("NATIONALITY", _nationality.GetType()));
            sl.Add("CivilStatus", new ChocoDesing("CIVILSTATUS", _civilStatus.GetType()));
            sl.Add("Birthday", new ChocoDesing("BIRTHDAY", _birthday.GetType()));
            sl.Add("TelephoneList", new ChocoDesing(new Telephone(), ChocoDesing.Wrapper.OO__OO));
            return sl;
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new Person();
        }

        #endregion
    }
}
