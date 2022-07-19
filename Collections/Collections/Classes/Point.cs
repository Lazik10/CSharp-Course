using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    struct Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Value { get; set; }

        public Point(int x, int y, int hodnota)
        {
            X = x;
            Y = y;
            Value = hodnota;
        }
    }
}
