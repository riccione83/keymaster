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
        string _expityDate;
        string _description;
        string _ID;
        string _position;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

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
        public string ExpiryDate
        {
            get { return _expityDate; }
            set { _expityDate = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string readablePosition()
        {
            KeyUtility utils = new KeyUtility();
            if (this._position != null)
            {
                string[] currentKey = this._position.Split('-');
                if (currentKey.Length >= 3)
                    return utils.getFace(int.Parse(currentKey[0])) + " - " + currentKey[1] + " - " + currentKey[2];
            }
            return "Nessuna";
        }

        public Key()
        {

        }
    }
}
