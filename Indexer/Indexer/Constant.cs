using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Constant
    {
        // Readonly
        // - can be different for every instance
        // - they can be changed in constructor
        // - accessed by instance Constant constant = new Constant(); constant.minPasswordLength
        public readonly int minPasswordLength;

        // Const
        // - are same for all instances, THEY ARE STATIC!!!
        // - we access them by Class, Constant.maxPasswordLength
        public const int maxPasswordLength = 10;

        public Constant()
        {
            minPasswordLength = 4;
        }
    }
}
