using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Bird
    {
        protected int hunger;
        protected int weight;

        public Bird()
        {
            hunger = 100;
            weight = 50;
        }

        public void Eat(int foodWeight)
        {
            weight += foodWeight;
            hunger -= foodWeight;
        }

        public override string ToString()
        {
            return string.Format("Jsem pták s váhou {0} a hladem {1}.", weight, hunger);
        }

        public bool isHungry()
        {
            return hunger > 0;
        }
    }
}
