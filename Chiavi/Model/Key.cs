using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiavi
{
    [Serializable()]
    class Key
    {
        string _keyNumber;
        string _userID;

        public string KeyNumber
        {
            get { return _keyNumber; }
            set { _keyNumber = value; }
        }

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public Key()
        {

        }
    }
}
