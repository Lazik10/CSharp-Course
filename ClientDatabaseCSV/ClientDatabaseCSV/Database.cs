using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDatabaseCSV
{
    internal class Database
    {
        private List<User> _users;
        private string _file;

        public Database(string file)
        {
            _users = new List<User>();
            _file = file;
        }

        public void AddUser(string name, int age, DateTime dateTime)
        {
            User user = new User(name, age, dateTime);
            _users.Add(user);
        }

        public User[] AllUsers()
        {
            return _users.ToArray();
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(_file))
            {
                foreach (var user in _users)
                {
                    string[] values = { user.Name, user.Age.ToString(), user.Registration.ToShortDateString() };
                    string line = String.Join(";", values);
                    sw.WriteLine(line);
                }
            }
        }

        public void Load()
        {
            _users.Clear();

            using (StreamReader sr = new StreamReader(_file))
            {
                User user;
                while (!sr.EndOfStream)
                {
                    string userLine = sr.ReadLine();
                    string[] values = userLine.Split(";");
                    user = new User(values[0], int.Parse(values[1]), DateTime.Parse(values[2]));
                    AddUser(user.Name, user.Age, user.Registration);
                }
            }
        }

        public void Remove(User user)
        {
            _users.Remove(user);
        }
    }
}
