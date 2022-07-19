using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Address
    {
        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; private set; }
        /// <summary>
        /// House number
        /// </summary>
        public int HouseNumber { get; private set; }
        /// <summary>
        /// Registry number
        /// </summary>
        public int RegistryNumber { get; private set; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; private set; }
        /// <summary>
        /// Zip code
        /// </summary>
        public string Zip { get; private set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; private set; }

        public Address(string street, int houseNumber, int registryNumber, string city, string zip, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            RegistryNumber = registryNumber;
            City = city;
            Zip = zip;
            Country = country;
        }
    }
}
