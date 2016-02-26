using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            if (user != null)
            {
                index = 0;
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].ID == user.ID)
                    {
                        index = i;
                        break;
                    }
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

        public void saveUser(User user)
        {
            DBConnect database = new DBConnect();
            string sql = "UPDATE Users SET Name = '" + user.Name + "', Surname = '" + user.Surname + "', Email = '" + user.EmailAddress + "',Password = '" + user.UserPassword + "',Address = '" + user.Address + "',City = '" + user.City + "',Note = '" + user.Note + "' WHERE id = '"+user.ID+"'";
            database.Insert(sql);
        }

        public void newUser(User user)
        {
                DBConnect database = new DBConnect();
                string sql = "INSERT INTO Users (Name, Surname, Email,Password,Address,City,Note) VALUES('" +user.Name+"', '" + user.Surname + "','" + user.EmailAddress + "','" + user.UserPassword + "','" + user.Address + "','" + user.City + "','" + user.Note + "')";
                database.Insert(sql);
                users.Add(user);
        }

        public User searchUserByID(string ID)
        {
            foreach (User user in users)
            {
                if (user.ID == ID)
                    return user;
            }
            return null;
        }
    }
}
