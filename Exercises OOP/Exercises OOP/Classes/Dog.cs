using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP
{
    internal class Dog
    {
        private int age;
        private string name;

        public Dog(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void AddYear() { age++; }

        public int GetAge() { return age; }

        public string GetName() { return name; }
    }
}
