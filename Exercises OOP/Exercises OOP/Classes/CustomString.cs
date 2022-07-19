using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class CustomString
    {
        private List<string> words = new List<string>();

        public CustomString(string sentence)
        {
            char[] spliters = { '.', ',', '!', ' ', ':' };
            words = sentence.Split(spliters, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public void Map(Func<string, string> function)
        {
            for (int i = 0; i < words.Count; i++)
            {
                words[i] = function(words[i]);
            }
        }

        public string Aggreggate(Func<string, string, string> function) 
        {
            if (words.Count == 0)
                return null;

            string vysledek = words[0];
            for (int i = 1; i < words.Count; i++)
            {
                vysledek = function(vysledek, words[i]);
            }
            return vysledek;
        }

        public override string ToString()
        {
            return string.Join(" ", words) + ".";
        }
    }
}
