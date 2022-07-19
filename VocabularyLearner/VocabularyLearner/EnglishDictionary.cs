using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyLearner
{
    internal class EnglishDictionary
    {
        private Dictionary<string, string> _dictionary;

        private string _fileName = "";
        private const int numberOfQuestions = 5;
        static private Random _random = new Random();
        private int _counter = 0;

        public EnglishDictionary(string fileName)
        {
            _fileName = fileName;
            _dictionary = new Dictionary<string, string>();
        }

        public void LoadWords()
        {
            _dictionary.Clear();

            using (StreamReader sr = new StreamReader(_fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split("\t");

                    _dictionary.Add(words[0], words[1]);
                }
            }
        }

        public void ShowRecord()
        {
            using (StreamReader sr = new StreamReader("record.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] record = sr.ReadLine().Split(";");
                    if (record.Length >= 2)
                        Console.WriteLine("Nejvyssi rekord drzi {0}: ", record[0], record[1]);
                }
            }
        }
        public static (string name, int points, TimeSpan time) GetRecord()
        {
            using (StreamReader sr = new StreamReader("record.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] record = sr.ReadLine().Split(";");
                    if (record.Length >= 3)
                        Console.WriteLine("Nejvyssi rekord drzi {0} s casem {1} vterin", record[0], record[2]);

                    return (record[0], int.Parse(record[1]), TimeSpan.Parse(record[2]));
                }
            }

            return ("unknown", (int)0, TimeSpan.Parse("0"));
        }

        public void SaveRecord(string name, int correctAnswers, TimeSpan time)
        {
            using (StreamWriter sw = new StreamWriter("record.txt"))
            {
                sw.WriteLine(string.Join(";", name, correctAnswers, ((int)time.TotalSeconds)));
            }
        }

        public void StartAskingForTranslations()
        {
            bool again = false;
            do
            {
                _counter = 0;
                DateTime startTime = DateTime.Now;
                Console.WriteLine("Novy test spustis libovolnou klavesou...");
                Console.ReadLine();

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    int randomWord = _random.Next(1, _dictionary.Keys.Count) - 1;

                    string englishWord = _dictionary.Keys.ElementAt(randomWord);
                    string czechWord = _dictionary.Values.ElementAt(randomWord);

                    Console.WriteLine("Co znamena {0}?", englishWord);
                    string answer = Console.ReadLine();
                    string[] czechWordsSplitted = czechWord.Split(',');
                    if (czechWordsSplitted.Contains(answer))
                    {
                        Console.WriteLine("Vyborne! Pojdme dal.");
                        _counter++;
                    }
                    else
                    {
                        Console.WriteLine("Spravny preklad je: {0}. Nevadi zkusme to jeste jednou", _dictionary[englishWord]);
                    }
                }

                DateTime endTime = DateTime.Now;
                TimeSpan gameTime = endTime - startTime;
                Console.WriteLine("Ziskal jsi {0} bodu z 5 s casem {1} vterin.", _counter, gameTime.TotalSeconds);

                var record = GetRecord();
                if (_counter >= record.points)
                {
                    if (record.time.TotalSeconds >= gameTime.TotalSeconds)
                    {
                        Console.WriteLine("Mas novy rekord!");
                        Console.Write("Zadej sve jmeno, genie: ");
                        string name = Console.ReadLine();
                        SaveRecord(name, _counter, gameTime);
                    }
                }

                Console.WriteLine("Prejes si pokracovat? [a/n]");
                if (Console.ReadLine().ToLower() == "a")
                    again = true;


            } while (again);
        }
    }
}
