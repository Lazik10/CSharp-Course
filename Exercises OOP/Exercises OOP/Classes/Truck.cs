using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Truck : Car
    {
        private int cargoWeight;
        public int MaxWeight { get; set; }

        public Truck(string spz, string manufacturer, double value, int weight) : base(spz, manufacturer, value)
        {
            MaxWeight = weight;
        }
        public void LoadCargo(int weigth)
        {
            if (weigth + cargoWeight < MaxWeight)
                cargoWeight += weigth;
            //else
            //    Console.WriteLine("Nemuzete nalozit vice hmotnosti nez je maximalni hmotnost, kterou auto muze vozit!");
        }

        public void UnloadCargo(int weight)
        {
            if (cargoWeight - weight > 0)
                cargoWeight -= weight;
            //else
            //    Console.WriteLine("V aute tolik nakladu neni!");
        }

        public int GetCargoWight() { return cargoWeight; }
    }
}
