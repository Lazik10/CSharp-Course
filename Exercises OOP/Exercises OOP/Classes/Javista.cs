using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Javista : Human
    {
        private string _IDE;

        public Javista(string name, int age) : base(name, age)
        {
            _IDE = "Java";
        }

        public void DoProgram(int numberOfLines)
        {
            if (Rest == 20)
                Console.WriteLine("Jsem prilis unaveny, abych probramoval");
            Rest += numberOfLines / 10;
            if (Rest > 20)
                Rest = 20;
        }
    }
}
