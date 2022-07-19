using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class AngryBird : Bird
    {
        private int anger = 50;

        public void Provoke(int provocationValue)
        {
            anger += isHungry() ? provocationValue * 2 : provocationValue;
        }

        public override string ToString()
        {
            return string.Format("Jsem angry-pták s váhou {0} a hladem {1}, míra mého vzteku je {2}.", weight, hunger, anger);
        }
    }
}
