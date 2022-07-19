using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Numbers
    {
        private List<int> numbers = new List<int>();

        public Numbers()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
            }
        }

        public override string? ToString()
        {
            string vystup = "";
            foreach (int cislo in numbers)
            {
                vystup += cislo + ", ";
            }
            return vystup;
        }

        // Delegate is a reference to a Method, Operation is a data type and it can store method which has the same signature
        // that method can be static or instantion, it has to have the same return type
        public delegate int Operation(int value);

        public void DoOperation(Operation operation)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = operation(numbers[i]);
            }
        }

/*        public delegate int MoreComplexOperation(int a, int b);

        public void DoComplexOperation(MoreComplexOperation operation, operation1)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = operation(numbers[i]);
            }
        }*/

    }
}
