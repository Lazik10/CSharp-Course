using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Surname: " + Surname + " Date of Birth: " + DateOfBirth.ToShortDateString(); 
        }
    }
}
