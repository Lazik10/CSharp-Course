using System.Text;
using VocabularyLearner;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

EnglishDictionary dictionary = new EnglishDictionary("english-words.txt");
try
{
    dictionary.LoadWords();
    dictionary.ShowRecord();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

dictionary.StartAskingForTranslations();