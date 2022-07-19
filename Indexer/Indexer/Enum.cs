using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Enum
    {
        public enum EnumType { New, InOrder, Confirmed, Finished };

        public EnumType Type { get; set; }
    }
}
