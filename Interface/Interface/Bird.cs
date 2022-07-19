using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Bird : Animal, IBird
    {
        public void Sound()
        {
            Console.WriteLine("Pip pip pip");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Moving...");
        }
    }
}
