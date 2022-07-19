using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCarMarketplace
{
    public class Car
    {
        public string Brand { get; private set; }
        public int ManufactureYear { get; private set; }
        public string SPZ { get; private set; }
        public int Value { get; private set; }

        public Car(string brand, int year, string spz, int value)
        {
            Brand = brand;
            ManufactureYear = year;
            SPZ = spz;
            Value = value;
        }

        public override string ToString()
        {
            return Brand + " " + ManufactureYear + " " + SPZ + " " + Value;
        }
    }
}
