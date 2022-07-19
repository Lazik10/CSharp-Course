// User Input Handling

// Int, float, double, decimal
float number;
while (!float.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Incorrect number format!");
}
Console.WriteLine(number);

// One character
char character = Console.ReadKey(false).KeyChar; // Intercept argument, false if you want to display that pressed character
Console.WriteLine(character);
string choice = Console.ReadKey(false).KeyChar.ToString().ToLower();
Console.WriteLine(choice);
Console.ReadKey();