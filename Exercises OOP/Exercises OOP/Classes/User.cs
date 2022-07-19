using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class User
    {
        private string name;
        private string password;
        private bool loggedIn;
        private int id;

        private static int minPasswordLength = 6;
        public static int userCount = 0;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            loggedIn = false;
            userCount++;
            id = userCount;
        }

        public bool LogIn(string password)
        {
            return this.password == password && isValidPassword(this.password) ? loggedIn = true : loggedIn = false;
        }

        public bool isLoggedIn()
        {
            return loggedIn;
        }

        public static int GetMinPasswordLength()
        {
            return minPasswordLength;
        }

        public static bool isValidPassword(string password)
        {
            return password.Length >= minPasswordLength;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
