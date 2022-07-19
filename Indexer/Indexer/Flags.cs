using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Flags
    {
        [Flags]
        public enum FlagsType
        {
            None        = 1,
            Write       = 2,
            Read        = 4 ,
            Run         = 8,
            Delete      = 16,
            Print       = 32,
            All         = Write | Read | Run | Delete | Print
        }
    }
}
