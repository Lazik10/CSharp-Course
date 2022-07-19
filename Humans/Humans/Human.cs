using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    internal abstract class Human : IComparable<Human>
    {
        public string Name { get; protected set; }

        public string Surname { get; protected set; }

        public DateTime DateOfBirth { get; protected set; }

        public static Random random = new Random();

        public int CompareTo(Human? other)
        {
            int result = Name.CompareTo(other?.Name);
            if (result == 0)
                result = DateOfBirth.CompareTo(other?.DateOfBirth);
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Surname, DateOfBirth.ToString("yy"));
        }

        public static Human operator +(Human humanFirst, Human humanSecond)
        {
            if (!(humanFirst is Woman && humanSecond is Man ||
                humanFirst is Man && humanSecond is Woman))
                return null;
            /*  Better and shorter version
                if (humanFirst.GetType() == humanSecond.GetType())
                return null; 
            */

            bool gender = Gender();
            if (gender)
                return new Man("Adam", humanFirst is Man ? humanFirst.Surname : humanSecond.Surname, DateTime.Now);
            else
                return new Woman("Eva", humanFirst is Woman ? humanFirst.Surname : humanSecond.Surname, DateTime.Now);
        }

        private static bool Gender()
        {
            return random.Next(0, 2) == 1;
        }
    }
}
