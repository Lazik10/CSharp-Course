using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exercises
{
    internal class Planet
    {
        public string Name { get; private set; }
        public double Diameter { get; private set; }
        public int NumberOfMoons { get; private set; }
        public bool IsRock { get; private set; }
        public int AverageTemperature { get; private set; }

        public Planet(string name, double diameter, int numberOfMoons, bool isRock, int averageTemperature)
        {
            Name = name;
            Diameter = diameter;
            NumberOfMoons = numberOfMoons;
            IsRock = isRock;
            AverageTemperature = averageTemperature;
        }
    }
}
