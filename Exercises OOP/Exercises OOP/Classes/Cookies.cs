using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Cookies
    {
        private string color;
        private string shape;
        private string weight;

        public Cookies(string color, string shape, string weight)
        {
            this.color = color;
            this.shape = shape;
            this.weight = weight;
        }

        public override string ToString()
        {
            return string.Format("Cookies with color {0}, shape is {1} and weight is {2}", color, shape, weight);
        }
    }
}
