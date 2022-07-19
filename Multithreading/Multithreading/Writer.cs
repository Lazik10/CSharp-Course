using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Writer
    {
        public void Write0()
        {
            for (int i = 0; i < 150; i++)
            {
                Console.Write("0");
                Thread.Sleep(5);
            }
        }

        public void Write1()
        {
            for (int i = 0; i < 150; i++)
            {
                Console.Write("1");
                Thread.Sleep(5);
            }
        }
    }
}
