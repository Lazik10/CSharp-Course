class Zapis
{
    static public void ZapisTest()
    {
        using (StreamWriter sw = new StreamWriter(@"C:\Users\Lazik\OneDrive\Projects\Visual Studio\C#\IT Network\TestFiles\soubor.txt", true))
        {
            sw.WriteLine("Test text");
            sw.Flush();

            // To append text we can use second parametr and set it to true
            sw.Write("And another sentence in my text file {0}", Environment.NewLine);
            sw.Flush();
        }
    }

    static public void NacistTest()
    {
        using (StreamReader sr = new StreamReader(@"C:\Users\Lazik\OneDrive\Projects\Visual Studio\C#\IT Network\TestFiles\soubor.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

    static public void FileClassTest()
    {
        var lines = File.ReadLines(@"C:\Users\Lazik\OneDrive\Projects\Visual Studio\C#\IT Network\TestFiles\soubor.txt");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}