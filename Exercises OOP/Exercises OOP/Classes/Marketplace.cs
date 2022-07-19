using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Marketplace
    {
        public string? Address { get; init; }
        public double Money { get; private set; }
        public List<Car> Cars { get; private set; }

        public Marketplace(string address, double money)
        {
            Address = address;
            Money = money;
            Cars = new List<Car>();
        }

        public void BuyCar(Car car)
        {
            if (car.Value < Money)
            {
                Money -= car.Value;
                Cars.Add(car);
            }
            else
                Console.WriteLine("Insufficient money on our bank account!");
        }

        public void SellCar(Car car)
        {
            if (Cars.Remove(car))
                Money += car.Value;
        }

        public double CarsValue()
        {
            return Cars.Sum(car => car.Value);
        }
    }
}
