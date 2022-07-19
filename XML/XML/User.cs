using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    internal class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime Registration { get; private set; }

        public User(string name, int age, DateTime registration)
        {
            Name = name;
            Age = age;
            Registration = registration;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Name, Age, Registration.ToShortDateString());
        }
    }
}