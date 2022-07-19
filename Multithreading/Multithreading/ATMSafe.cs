using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ATMSafe
    {
        private object lockVariable = new object();

        private void Withdraw100()
        {
            bool lockTaken = false;
            try 
            {
                Monitor.Enter(lockVariable, ref lockTaken);
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit(lockVariable);
            }
        }
    }
}
