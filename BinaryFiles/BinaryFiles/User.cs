using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFiles
{
    internal class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime Birthday { get; private set; }

        public User(string name, int age, DateTime dateTime)
        {
            Name = name;
            Age = age;
            Birthday = dateTime;
        }

        public override string ToString()
        {
            return string.Format($"{Name}, {Age} years old, birthday: {Birthday.ToShortDateString()}");
        }
    }
}
