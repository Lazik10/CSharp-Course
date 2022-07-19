using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Student
    {
        public string Name { get; private set; }
        public bool Gender { get; private set; }
        public bool Adult { get; private set; }
        //public bool Adult => Age > 18;

        private int _age; // Attribute - private attribute only used in class

        public int Age // Property - public attribute, access possible from outside of the class
        {
            // get => _age;
            get // default access modificator of the property (can be always only more strict than the property)
            {
                return _age;
            }
            private set // access modificator
            {
                _age = value;

                Adult = false;
                if (Age > 18)
                    Adult = true;
            }
        }

        public Student(string name, bool gender, int age)
        {
            EditStudent(name, gender, age);
        }

        public void EditStudent(string name, bool gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public override string ToString()
        {
            string tmpAdult = "am";
            if (!Adult)
            {
                tmpAdult = "am not";
            }

            string tmpGender = "man";
            if (!Gender)
            {
                tmpGender = "woman";
            }

            return string.Format("I am {0}, {1}. I am {2} years old and I {3} an adult.", Name, tmpGender, Age, tmpAdult);
        }
    }
}
