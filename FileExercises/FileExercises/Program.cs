/*Console.Write("Zadej cestu k vstupnímu souboru: ");
string inputFileName = Console.ReadLine();
Console.Write("Zadej cestu k výstupnímu souboru: ");
string outputFileName = Console.ReadLine();

List<string> lines = new List<string>();
Random random = new Random();

try
{
    // Load file
    using (StreamReader sr = new StreamReader(string.IsNullOrWhiteSpace(inputFileName) ? "vstup.txt" : inputFileName))
    {
        while (!sr.EndOfStream)
        {
            lines.Add(sr.ReadLine());
        }
    }
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.ToString()); 
}

try
{
    // Save File
    using (StreamWriter sw = new StreamWriter(string.IsNullOrWhiteSpace(outputFileName) ? "vystup.txt" : outputFileName))
    {
        while (lines.Count > 0)
        {
            int randomPos = random.Next(0, lines.Count - 1);
            sw.WriteLine(lines[randomPos]);
            lines.RemoveAt(randomPos);
        }
        Console.WriteLine("Hotovo");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}*/


string[,] svatky = new string[12, 31];
try
{
    using (StreamReader sr = new StreamReader("svatky.txt"))
    {
        int month = 0;
        int day = 0;
        string line = "";
        while (!sr.EndOfStream)
        {
            if (string.IsNullOrEmpty(line = sr.ReadLine()))
            {
                month++;
                day = 0;
            }
            else
            {
                svatky[month, day] = line;
                day++;
            }

            if (month > 12 || day > 31)
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

/*for (int i = 0; i < svatky.GetLength(0); i++)
{
    for (int j = 0; j < svatky.GetLength(1); j++)
    {
        Console.WriteLine(svatky[i,j]);
    }
}*/

DateTime today = DateTime.Today;
string name = svatky[today.Month - 1, today.Day - 1];

Console.WriteLine("Dnes je {0}", DateTime.Today.ToShortDateString());
Console.WriteLine("Svatek ma: {0}", name);

Console.Write("Zadejte sve jmeno: ");
string userName = Console.ReadLine();

for (int i = 0; i < svatky.GetLength(0); i++)
{
    for (int j = 0; j < svatky.GetLength(1); j++)
    {
        if (svatky[i, j] is not null)
        {
            if (svatky[i, j] != "" && svatky[i, j].Contains(userName))
                Console.WriteLine("Mas svatek: {0}.{1}.", j + 1, i + 1);
        }
    }
}