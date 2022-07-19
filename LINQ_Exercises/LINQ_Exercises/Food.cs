using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    internal class Food
    {
        public string Name { get; private set; }
        public string Category { get; private set; }

        public Food(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
