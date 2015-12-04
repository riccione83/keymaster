using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiavi
{
  [Serializable()]
    class User
    {
        string _name;
        string _surname;
        string _emailAddress;
        string _id;

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
