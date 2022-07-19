using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Semaphor
    {
        public enum Colors
        {
            Zelena, Oranzova, Cervena
        }

        public Colors Color { get; set; }

        public event EventHandler ColorChange;


        public Semaphor()
        {
            ChangeColor(Colors.Zelena);
        }

        public override string ToString()
        {
            return "Sviti " + Color.ToString();
        }

        public void ChangeColor(Colors color)
        {
            Color = color;

            string colorString = "";
            switch (color)
            {
                case Colors.Zelena:
                    colorString = "zelená";
                    break;
                case Colors.Oranzova:
                    colorString = "oranžová";
                    break;
                case Colors.Cervena:
                    colorString = "červená";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Rozsvítila se {0}", colorString);

            ColorChange?.Invoke(this, new EventArgs());
        }
    }
}
