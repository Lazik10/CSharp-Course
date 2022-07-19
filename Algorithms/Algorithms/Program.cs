// Selection sort
Console.WriteLine("Zadejte seznam cisel: ");
string? userInput = Console.ReadLine();
string[] poleCiselKSerazeni = userInput.Split(',');
int[] poleCiselConverted = new int[poleCiselKSerazeni.Length];
int k = 0;

foreach (var item in poleCiselKSerazeni)
{
    poleCiselConverted[k] = Convert.ToInt32(item);
    k++;
}

for (int i = 0; i < poleCiselKSerazeni.Length; i++)
{
    int minimum = poleCiselConverted[i];
    int position = 0;
    bool smallerNumber = false;

    for (int j = i; j < poleCiselKSerazeni.Length; j++)
    {
        if (poleCiselConverted[j] < minimum)
        {
            position = j;
            minimum = poleCiselConverted[j];
            smallerNumber = true;
        }
    }

    if (smallerNumber)
    {
        int tmp = poleCiselConverted[i];
        poleCiselConverted[i] = poleCiselConverted[position];
        poleCiselConverted[position] = tmp;
    }
}

Console.WriteLine("Seřazená čísla:");
Console.WriteLine(string.Join(", ", poleCiselConverted));

/*foreach (var item in poleCiselConverted)
{
    if (item != poleCiselConverted.Last())
        Console.Write(item + " ");
}*/

string text = Console.ReadLine();
foreach (char c in text)
    Console.Write(c);