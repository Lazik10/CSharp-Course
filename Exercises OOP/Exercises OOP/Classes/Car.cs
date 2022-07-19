using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Car
    {
        public string SPZ { get; private set; }
        public string Manufacturer { get; private set; }
        public double Value { get; private set; }

        public int Speed { get; private set; }

        public Car() { }

        public Car(string spz, string manufacturer, double value)
        {
            SPZ = spz;
            Manufacturer = manufacturer;
            Value = value;
            Speed = 100;
        }

        public override string ToString()
        {
            return SPZ;
        }

        public void Park(Garage garage)
        {
            garage.Park(this);
        }

        public void HandleSemaphor(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            if ((sender as Semaphor)?.Color == Semaphor.Colors.Oranzova ||
                (sender as Semaphor)?.Color == Semaphor.Colors.Zelena)
                Console.WriteLine("Jedu");
            
            if ((sender as Semaphor)?.Color == Semaphor.Colors.Cervena)
                Console.WriteLine("Stojim");
        }

        public void Drive()
        {
            Console.WriteLine("Jedu");
        }
    }
}
