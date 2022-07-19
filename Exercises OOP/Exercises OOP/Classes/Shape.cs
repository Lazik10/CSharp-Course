using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Shape
    {
        protected string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public virtual double Area()
        {
            return -1;
        }
    }

    internal class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            // Heron's formula
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height, string color) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
