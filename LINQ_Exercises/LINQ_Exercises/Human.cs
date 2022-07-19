using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    internal class Human
    {
        public List<string> Languages { get; set; }
        public string Name { get; set; }

        public Human(string name, params string[] languages)
        {
            Name = name;
            Languages = new List<string>(languages);
        }
    }
}
