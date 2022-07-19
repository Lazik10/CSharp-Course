using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    internal class Woman : Human
    {
        public Woman(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}
