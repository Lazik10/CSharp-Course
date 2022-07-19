using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal static class Settings
    {
        private static string language = "CZ";
        private static string schemeColor = "red";
        private static bool loadOnStart = false;

        public static string Language() { return language; }
        public static string SchemeColor() { return schemeColor; }
        public static bool LoadOnStart() { return loadOnStart; }
    }
}
