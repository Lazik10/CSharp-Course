using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Converter
    {
        public static double ToDegrees(double radians)
        {
            return 360 / Math.Tau * radians;
        }

        public static double ToRadians(double degrees)
        {
            return Math.Tau / 360 * degrees;
        }
    }
}
