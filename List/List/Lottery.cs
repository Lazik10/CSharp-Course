using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Lottery
    {
        private List<int> numbers;
        private Random random;

        public Lottery()
        {
            numbers = new List<int>();
            random = new Random();
        }

        public int DrawNumber()
        {
            int number = random.Next(100) + 1;
            numbers.Add(number);
            return number;
        }

        public string GetDrawnNumbers()
        {
            numbers.Sort();
            string s = string.Join(' ', numbers);
            //s = s + "\n";
            return s;
        }
    }
}
