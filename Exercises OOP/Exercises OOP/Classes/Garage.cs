using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Garage
    {
        private Car car;

        public override string ToString()
        {
            return string.Format("V garazi je auto: {0}", car);
        }

        public void Park(Car car)
        {
            this.car = car;
        }
    }
}
