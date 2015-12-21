using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chiavi
{
    class Keys
    {
        public List<Key> keys;
        int index = -1;

        public Keys()
        {
            keys = load();
            if (keys == null)
                keys = new List<Key>();
            else
                index = 0;
        }

        public Key current(string KeyNumber)
        {
            int indx = 0;
            foreach (Key key in keys)
            {
                if (key.KeyNumber == KeyNumber)
                {
                    index = indx;
                    return key;
                }
                indx++;
            }
            return null;
        }
        public Key current()
        {
            if (keys.Count > 0)
                return keys[index];
            else
                return new Key();
        }
        public Key findFirst()
        {
            if (keys.Count > 0)
                return keys[0];
            else
                return null;
        }

        public Key next()
        {
            if (keys.Count > 0)
            {
                index++;
                if (index >= keys.Count)
                    index = keys.Count - 1;

                return keys[index];
            }
            return new Key();
        }

        public Key prev()
        {
            if (keys.Count > 0)
            {
                index--;
                if (index < 0) index = 0;
                return keys[index];
            }
            return new Key();
        }

        public void updateKey(Key key)
        {
            DBConnect database = new DBConnect();

            string expiryDate = DateTime.Parse(key.ExpiryDate).ToString("yyyy-MM-dd HH:mm:ss");

            string sql = "UPDATE `Keys` SET Description = '" + key.Description + "', ExpiryDate= '" + expiryDate + "', Position='" + key.Position + "' WHERE KeyNumber = '" + key.KeyNumber + "'";
            database.Insert(sql);
        }

        public void newKey(Key key)
        {
            DBConnect database = new DBConnect();
            string sql = "INSERT INTO `Keys` (KeyNumber,Description,ExpiryDate) VALUES('" + key.KeyNumber + "','" + key.Description + "','" + key.ExpiryDate + "')";
            database.Insert(sql);
            keys.Add(key);
        }

        public void associateToUser(string UserID, Key currentKey)
        {
            if (currentKey != null)
            {
                User user = getUserForKey(currentKey.KeyNumber);

                if (user == null)
                {
                    string sql = "UPDATE `keys` SET USER_ID='" + UserID + "' WHERE KeyNumber='" + currentKey.KeyNumber + "'";
                    DBConnect database = new DBConnect();
                    database.Update(sql);
                    keys[index].UserID = UserID;
                    MessageBox.Show("Card correttemente assegnata");
                }
                else
                {
                    MessageBox.Show("Impossibile associare la CARD. E' già assegnata all'utente [" + user.ID + "] " + user.Name + " " + user.Surname);
                }
            }
        }
        public void deassociateFromUser(string UserID, Key currentKey)
        {
            if (currentKey != null)
            {
                string sql = "UPDATE `keys` SET USER_ID='0' WHERE KeyNumber='" + currentKey.KeyNumber + "'";
                DBConnect database = new DBConnect();
                database.Update(sql);
                keys[index].UserID = UserID;
            }
        }

        public void loadFreeKey()
        {
            keys = loadOnlyFreeKey();
            if (keys == null)
                keys = new List<Key>();
            else
                index = 0;
        }

        public void loadAllKey()
        {
            keys = load();
            if (keys == null)
                keys = new List<Key>();
            else
                index = 0;
        }

        List<Key> loadOnlyFreeKey()
        {
            DBConnect database = new DBConnect();
            return database.SelectKeys("0");
        }

        List<Key> load()
        {
            DBConnect database = new DBConnect();
            return database.SelectKeys();
        }

        
        public User getUserForKey(string KeyNumber)
        {
            string query = "SELECT USER_ID FROM `keys` WHERE KeyNumber = '"+KeyNumber+"'";
            DBConnect database = new DBConnect();
            Dictionary<string, object> returnedData = database.Select(query);
            string USER_ID = returnedData["USER_ID"].ToString();
            User user = new User();

            query = "SELECT * FROM `users` WHERE ID = '" + USER_ID + "'";
            returnedData = database.Select(query);
            if (returnedData.Count > 0)
            {
                user.ID = (returnedData["id"] + "");
                user.Name = (returnedData["Name"] + "");
                user.Surname = (returnedData["Surname"] + "");
                user.EmailAddress = (returnedData["Email"] + "");
                user.Address = (returnedData["Address"] + "");
                user.City = (returnedData["City"] + "");
                user.Note = (returnedData["Note"] + "");
                user.UserPassword = (returnedData["Password"] + "");
                return user;
            }
            return null;
        }

        public void deleteKey(string KeyNumber)
        {
            string query = "DELETE FROM `keys` WHERE KeyNumber = '" + KeyNumber + "'";
            DBConnect database = new DBConnect();
            database.Delete(query);
        }

        public int KeyExist(string KeyNumber)
        {
            string query = "SELECT Count(*) FROM `keys` WHERE KeyNumber = '"+KeyNumber+"'";
            DBConnect database = new DBConnect();
            return database.Count(query);
        }
    }
}
