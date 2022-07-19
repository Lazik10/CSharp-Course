using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP
{
    internal class Calculator
    {
        public double Add(double x, double y) => x + y;
        public double Substract(double x, double y) => x - y;
        public double Multiply(double x, double y) => x * y;
        public double Divide(double x, double y) => x / y;
        public double Modulo(double x, double y) => x % y;

        public double X;
        public double Y;
    }
}
