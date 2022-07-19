using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    internal class MonthIncome
    {
        public decimal Amount { get; private set; }

        public string Name { get; private set; }

        public MonthIncome(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
