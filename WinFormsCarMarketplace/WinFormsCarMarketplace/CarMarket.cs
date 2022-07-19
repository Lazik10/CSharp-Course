using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WinFormsCarMarketplace
{
    public class CarMarket
    {
        const decimal _initialCash = 100000;
        private decimal _cash;
        public List<Car> Cars { get; private set; }

        public CarMarket()
        {
            _cash = _initialCash;
            Cars = new List<Car>();
            Load();
        }

        public void AddMoney(decimal cash)
        {
            _cash += cash;
        }

        public void WithdrawMoney(decimal cash)
        {
            _cash -= cash;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter("cars.csv"))
            {
                foreach (var car in Cars)
                {
                    string[] values = { car.Brand, car.ManufactureYear.ToString(), car.SPZ, car.Value.ToString() };
                    string line = string.Join(",", values);
                    sw.WriteLine(line);
                }
            }
        }

        public void Load()
        {
            if (File.Exists("cars.csv"))
            {
                using (StreamReader sr = new StreamReader("cars.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split('\u002C');
                        Cars.Add(new Car(values[0], int.Parse(values[1]), values[2], int.Parse(values[3])));
                    }
                }
            }
        }
    }
}
