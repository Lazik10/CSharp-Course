using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Calendar
    {
        public string GetSettings()
        {
            string settings = "";
            settings += string.Format("Language: {0}\n", Settings.Language());
            settings += string.Format("Schema color: {0}\n", Settings.SchemeColor());
            settings += string.Format("Load on startup: {0}\n", Settings.LoadOnStart());
            return settings;
        }
    }
}
