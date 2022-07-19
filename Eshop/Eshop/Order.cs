using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Order : IOrder
    {
        private static int orderID = 1;

        public int Number { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Street { get; private set; }

        public int HouseNumber { get; private set; }

        public int RegistryNumber { get; private set; }

        public string City { get; private set; }

        public string Zip { get; private set; }

        public string Country { get; private set; }

        public string[] Products { get; private set; }

        public int[] Quantities { get; private set; }

        public double[] Prices { get; private set; }

        public Order(Customer customer)
        {
            Number = orderID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Street = customer.Address.Street;
            HouseNumber = customer.Address.HouseNumber;
            RegistryNumber = customer.Address.RegistryNumber;
            City = customer.Address.City;
            Zip = customer.Address.Zip;
            Country = customer.Address.Country;

            Products = new string[1];
            Quantities = new int[1];
            Prices = new double[1];

            orderID++;
        }

        public void AddProduct(Product product, int quantity)
        {
            Products[0] = product.Name;
            Quantities[0] = quantity;
            Prices[0] = product.Price;
        }
    }
}
