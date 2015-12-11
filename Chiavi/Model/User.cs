using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiavi
{
  [Serializable()]
    public class User
    {
        string _name;
        string _surname;
        string _emailAddress;
        string _id;
        string _userPassword;
        string _address;
        string _city;
        string _notes;

        public string Note
        {
            get { return _notes; }
            set { _notes = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public User()
        {
            this._name = "";
            this._surname = "";
            this._emailAddress = "";
            this._id = "";
        }

    }
}
