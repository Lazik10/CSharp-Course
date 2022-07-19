// Loops

// FOR Loop

// variable, condition, command
for (int i = 0; i < 3 /*length*/; i++)
{
    Console.WriteLine("Knock");
}
Console.WriteLine("Penny!");

for (int i = 1; i <= 10; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{ i * j} ".PadRight(5));
    }
    Console.WriteLine();
}

// Short For loop version
for (int i = 0; i < 10; Console.WriteLine(i++));

// Ednless for loop
for ( ; ; ) // same as while (true)
{
    break;
}

Console.WriteLine("Power");
Console.WriteLine("==============");
Console.WriteLine("Please insert base of power");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please insert power");
int n = int.Parse(Console.ReadLine());

int result = a;
for (int i = 0; i < (n - 1); i++)
{
    result = result * a;
}

Console.WriteLine("Result is: {0}", result);

// WHILE Loop

// condition
while (true == false)
{
    // comands
}

int number = 1;
while (number <= 10)
{
    Console.Write("{0}", number);
    number++;
}

// Ternary operator ?: (expression) ? value1 : value2
Console.WriteLine("\n" + (18 > 15 ? true : false));
string gender = "Unknown";
string genderName = gender == "Male" ? "Male" : gender == "Female" ? "Female" : "Unknown";
Console.WriteLine(genderName);

// Range Switch
int myValue = 63;
switch (myValue)
{
    case >= 100:
        Console.WriteLine($"I am 100 or above: {myValue}");
        break;

    case < 100 and >= 50:
        Console.WriteLine($"I am between 99 and 50: {myValue}");
        break;

    case < 50:
        Console.WriteLine($"I am less than 50: {myValue}");
        break;
}

// Do ... while
do
{

} while (/*true*/ false);

// break and continue
// break - is used to break from curent loop e.g. if we found what we were looking for
// continue - is used to end current iteration and skip to the next one

// Continue
string cislaRetezec = "10,50,abcd,30,9";
// rozložení řetězce do pole
string[] cislaPole = cislaRetezec.Split(',');
int soucet = 0;
foreach (string cislo in cislaPole)
{
    if (!int.TryParse(cislo, out int celeCislo))
        continue;

    soucet += celeCislo;
}
Console.WriteLine("Součet je: " + soucet);