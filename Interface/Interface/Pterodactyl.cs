using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Pterodactyl : Animal, IBird, ILizard, IComparable<Pterodactyl>
    {
        private int value;

        void IBird.Breathe()
        {
            Console.WriteLine("Breathing as a bird...");
        }

        void ILizard.Breathe()
        {
            Console.WriteLine("Breathing as a lizard...");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing as a pterodactyl...");
        }

        public override void Move()
        {
            Console.WriteLine("Moving...");
        }

        public void Sound()
        {
            Console.WriteLine("Squeaking...");
        }

        public int CompareTo(Pterodactyl? pterodactyl)
        {
            if (pterodactyl == null)
                return 1;

            return value.CompareTo(pterodactyl.value);
        }

        // Define the is greater than operator.
        public static bool operator >(Pterodactyl operand1, Pterodactyl operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        // Define the is less than operator.
        public static bool operator <(Pterodactyl operand1, Pterodactyl operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Pterodactyl operand1, Pterodactyl operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Pterodactyl operand1, Pterodactyl operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
    }
}
