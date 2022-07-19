using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Alarm
    {
        protected int Volume {  get; set; }
        // Delegate 
        public delegate void Delegate();

        public event Delegate? Ring;


        //public delegate void EventHandler();

        public virtual event EventHandler<AlarmParametres> Ringing;

        public Alarm(int volume)
        {
            Volume = volume;
        }

        public virtual void StartRinging()
        {
            Console.WriteLine("Budík zvoní");
            Ring?.Invoke();

            /*
            if (Ring != null)
                Ring();
            */

            Ringing?.Invoke(this, new AlarmParametres(10));
        }
    }

    internal class DigiAlarm : Alarm
    {
        public override event EventHandler<AlarmParametres> Ringing;

        public DigiAlarm(int volume) : base(volume) {}
        public override void StartRinging()
        {
            Console.WriteLine("Digi budik zvoni");
            Ringing?.Invoke(this, new AlarmParametres(100));
        }
    }
}
