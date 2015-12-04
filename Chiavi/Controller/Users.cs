using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 

namespace Chiavi
{
    class Users
    {
        const bool USE_DATABASE = true;

        public List<User> users;
        public Keys keys = new Keys();
        int index = -1;

        public Users()
        {
            users = load();
            if (users == null)
                users = new List<User>();
            else
                index = 0;
        }

        ~Users()
        {
         //   save();
        }

        public List<Key> getAssociatedKeys()
        {
            List<Key> keyList = new List<Key>();
            DBConnect database = new DBConnect();
            return database.SelectKeys(current().ID);
        }

        void save()
        {
            string fileName = "file.dat";    
            BinaryFormatter bf = new BinaryFormatter();   
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);   
            bf.Serialize(fs, users);  
        }

        List<User> load()
        {
            DBConnect database = new DBConnect();
            return database.SelectUser();
        }

        public void setCurrent(User user)
        {
            index = 0;
            for(int i=0; i<users.Count; i++)
            {
                if (users[i].ID == user.ID)
                {
                    index = i;
                    break;
                }
            }
        }

        public User current()
        {
            if (users.Count > 0)
                return users[index];
            else
                return null;
        }
        public User findFirst() 
        {
            if (users.Count>0)
                return users[0];
            else
                return null;
        }

        public User next()
        {
            if (users.Count > 0)
            {
                index++;
                if (index >= users.Count)
                    index = users.Count - 1;

                return users[index];
            }
            return null;
        }

        public User prev()
        {
            if (users.Count > 0)
            {
                index--;
                if (index < 0) index = 0;
                return users[index];
            }
            else
                return null;
        }

        public User last()
        {
            return users.Last();
        }

        public void newUser(User user)
        {
            if (!USE_DATABASE)
            {
                user.ID = users.Count.ToString();
                users.Add(user);
            }
            else
            {
                DBConnect database = new DBConnect();
                string sql = "INSERT INTO Users (Name, Surname, Email) VALUES('" +user.Name+"', '" + user.Surname + "','r.riki@tiscali.it')";
                database.Insert(sql);
                users.Add(user);
            }
        }

    }
}
