using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class AlarmParametres : EventArgs
    {
        public int Volume { get; set; }

        public AlarmParametres(int volume)
        {
            Volume = volume;
        }
    }
}
