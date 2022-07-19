using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP
{
    internal class SentenceGenerator
    {
        private string[] podmet = { "jednorozec", "programator", "manazer", "hroch", "T-rex" };
        private string[] prisudek = { "spal", "lezel", "varil", "uklizel", "derivoval" };
        private string[] privlastek = { "modry", "velky", "hubeny", "nejlepsi", "automatizovany" };
        private string[] prislovce = { "rychly", "s oblibou", "hodne", "malo", "se zpozdenim" };
        private string[] misto = { "pod stolem", "v lese", "u babicky", "v praci", "na stole" };
        readonly Random random = new Random();

        public SentenceGenerator() { }

        public void GenerateSentence(int numberOfSentences)
        {
            for (int i = 0; i < numberOfSentences; i++)
            {
                Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", 
                                                 RandomWord(privlastek), 
                                                 RandomWord(podmet), 
                                                 RandomWord(prislovce),
                                                 RandomWord(prisudek), 
                                                 RandomWord(misto)));
            }
        }

        private string RandomWord(string[] array)
        {
            int index = random.Next(0, array.Length);
            return array[index];
        }
    }
}
