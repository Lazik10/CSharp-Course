using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Factory
    {
        public static Cookies CreateBananaFlavor()
        {
            return new Cookies("yellow", "round", "20kg");
        }

        public static Cookies CreateStrawberryCookie()
        {
            return new Cookies("red", "round", "15kg");
        }

        public static Cookies CreateChocolateCookie()
        {
            return new Cookies("brown", "edgy", "25kg");
        }

    }
}
