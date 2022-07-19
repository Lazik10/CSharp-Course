using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Programmer
    {
        public string Name { get; private set; }
        public HashSet<string> ProgrammingLanguages { get; private set; }

        public Programmer(string jmeno, string[] jazyky)
        {
            Name = jmeno;
            ProgrammingLanguages = new HashSet<string>(jazyky);
        }
    }
}
