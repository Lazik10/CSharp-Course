using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Grandma : Human
    {
        public override void WakeUpWithParams(object? sender, AlarmParametres e)
        {
            if (sender is DigiAlarm && e.Volume > 50)
                Console.WriteLine("Babička vstává");
        }
    }
}
