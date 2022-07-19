using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Product
    {
        public string Name { get; private set; }

        public string Descreption { get; private set; }

        public double Price { get; private set; }

        public Product(string name, string descreption, double price)
        {
            Name = name;
            Descreption = descreption;
            Price = price;
        }
    }
}
