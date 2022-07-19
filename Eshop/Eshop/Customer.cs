using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Customer
    {
        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// Customer's address
        /// </summary>
        public Address Address { get; set; }

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
