using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ATMUnsafe
    {
        private decimal cash = 100;

        private void Withdraw100()
        {
            if (cash >= 100)
            {
                Console.WriteLine("Withdrawing 100");
                cash -= 100;
                Console.WriteLine("Your balance is {0}.", cash);
            }
        }

        public void VyberVlakny()
        {
            Thread thread1 = new Thread(Withdraw100);
            thread1.Start();
            Withdraw100();
            if (cash < 0)
                Console.WriteLine("Your balance is negative, you've been robbed!");
        }
    }
}
