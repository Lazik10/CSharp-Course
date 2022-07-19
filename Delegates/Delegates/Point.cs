using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Lambda-like method body
        public double DistanceFromZero() => Math.Sqrt(X * X + Y * Y);
    }
}
