/*// Excersises

// Parrot
Console.WriteLine("Hi, what is your name?");
string? jmeno = Console.ReadLine();
Console.WriteLine("How would you describe yourself");
string? vlastnost = Console.ReadLine();
Console.WriteLine(jmeno + " is " + vlastnost);
Console.ReadKey();

// Power number
Console.WriteLine("Insert number: ");
int number = int.Parse(Console.ReadLine());
int vysledek = number * number;
Console.WriteLine("Result is: " + vysledek);
Console.ReadKey();

// Perimeter and area of circle
Console.WriteLine("Insert radius of circle (cm):");
float radius = float.Parse(Console.ReadLine());
float pi = 3.1415F;
Console.WriteLine("Perimeter of circle is: " + 2 * pi * radius + " cm");
Console.WriteLine("Area of circle is " + pi * radius * radius + " cm^2");

// Uppercase name and age + 1
Console.WriteLine("Inesrt your name: ");
string? name = Console.ReadLine();
Console.WriteLine("Insert your surname: ");
string? surname = Console.ReadLine();
Console.WriteLine("Inser your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()}");
Console.WriteLine(++age);

// Length division between two strings
Console.WriteLine("Zadejte delší slovo:");
string? firstString = Console.ReadLine();
Console.WriteLine("Zadejte kratší slovo:");
string? secondString = Console.ReadLine();
Console.WriteLine("Slova se liší délkou o {0} znaků", firstString.Length - secondString.Length);

// Too short or too long name
Console.WriteLine("Please insert your name: ");
string? alias = Console.ReadLine();
if (alias.Length < 3 || alias.Length > 10)
    Console.WriteLine("Mas moc kratke nebo moc dlouhe jmeno!");
else
    Console.WriteLine("Your name is long enough");

// Smile conversion
Console.WriteLine("Please insert your smile: ");
string? smile = Console.ReadLine();
smile = smile switch
{
    ":-)" or ":)" => "Your smile is happy",
    ":-(" or ":(" => "Your smile is unhappy",
    ":-*" or ":*" => "Your smile is in love",
    ":-P" or ":P" => "Your smile is with tongue out",
    _ => "Your smile is uknown"
};
Console.WriteLine(smile);

// Quadratic equation
Console.WriteLine("Please insert your coeficients a,b,c for quadratic equation ax^2+bx+c=0 : ");
double a = int.Parse(Console.ReadLine());
double b = int.Parse(Console.ReadLine());
double c = int.Parse(Console.ReadLine());

double d = b * b - 4 * a * c;

double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b - Math.Sqrt(d)) / (2 * a);

if (d < 0)
    Console.WriteLine("There is no solution in range of real numbers");
else if (d == 0)
{
    Console.WriteLine("Equation has one root x = {0}", -b / (2 * a));
}
else
{
    if ((a * x1 * x1 + b * x1 + c) == 0 && (a * x2 * x2 + b * x2 + c) == 0)
    {
        Console.WriteLine("Eauqtion has two roots x1 = {0}, x2 = {1}", x1, x2);
    }
    else
        Console.WriteLine("This is not a quadratic equation!");
}

// Fishes
Console.WriteLine("How many fishes would you like to eat?");
int howManyFishes = int.Parse(Console.ReadLine());

for (int i = 0; i < howManyFishes; i++)
{
    Console.WriteLine("<° )))-<");
    Console.WriteLine();
}

// Bottles
for (int i = 10; i < 1; i--)
{
    if (i > 4)
        Console.WriteLine($"{i} green bottles are standing and one bottle falls");
    else
        Console.WriteLine($"{i} blue bottles are standing and one bottle falls");
}

// Intervals
Console.WriteLine("Zadejte levou mez 1. intervalu:");
int levaMez1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte pravou mez 1. intervalu:");
int pravaMez1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte levou mez 2. intervalu:");
int levaMez2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte pravou mez 2. intervalu:");
int pravaMez2 = int.Parse(Console.ReadLine());

Console.WriteLine("Dvojice čísel, jejichž součet leží v některém z intervalů:");
Console.WriteLine("(1. číslo je z prvního intervalu a 2. z druhého intervalu)");

for (int i = levaMez1; i <= pravaMez1; i++)
{
    for (int j = levaMez2; j <= pravaMez2; j++)
    {
        if ((i + j >= levaMez1 && i + j <= pravaMez1) ||
            (i + j >= levaMez2 && i + j <= pravaMez2))
        {
            Console.Write("[{0};{1}], ", i, j);
        }
    }
}

// Filling an array in reverse order
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = array.Length - i;
}

foreach (var item in array)
{
    Console.WriteLine(item);
}

// Fruit or vegetable
string[] zeleniny = { "zelí", "okurka", "rajče", "paprika", "ředkev", "mrkev", "brokolice" };
string[] ovoce = { "jablko", "hruška", "pomeranč", "jahoda", "banán", "kiwi", "malina" };
int counter = 0;

bool nextFood = true;

while (nextFood)
{
    Console.WriteLine("Zadejte název libovolného ovoce nebo zeleniny: ");
    string food = Console.ReadLine().ToLower();

    if (zeleniny.Contains(food))
        Console.WriteLine("Zadal jsi zeleninu");
    else if (ovoce.Contains(food))
        Console.WriteLine("Zadal jsi ovoce");
    else
        Console.WriteLine("Toto slovo nemám v seznamu");

    counter++;

    bool repeat = true;
    do
    {
        Console.WriteLine("Přeješ si zadat další slovo? (ano/ne)");
        string answer = Console.ReadLine().ToLower();
        if (answer == "ne" || answer == "ano")
        {
            if (answer == "ne")
            {
                nextFood = false;
                Console.WriteLine("Zadal jsi {0} slov", counter);
            }
            repeat = false;
        }
    } while (repeat);
}

// Median
Console.WriteLine("Zadej počet čísel: ");
int pocet = int.Parse(Console.ReadLine());

int[] numbers = new int[pocet];
for (int i = 0; i < pocet; i++)
{
    Console.WriteLine($"Zadej {i + 1}. číslo: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Sort(numbers);
int median = numbers[numbers.Length / 2];

foreach (var item in numbers)
{
    Console.WriteLine($"{item} se od mediánu odchyluje o {item - median}");
}

*//*Console.WriteLine("Zadej počet čísel: ");
int pocet = int.Parse(Console.ReadLine());

int[] numbers = new int[pocet];
for (int i = 0; i < pocet; i++)
{
    Console.Write("Zadej {0}. číslo: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] numbers2 = new int[pocet];
Array.Copy(numbers, numbers2, pocet);
Array.Sort(numbers2);
float median = numbers2[numbers.Length / 2];

foreach (var item in numbers)
{
    Console.WriteLine("{0} se od mediánu odchyluje o {1}", item, item - median);
}*//*

// ASCI Table
Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine((char)122);
for (int i = 0; i < 256 ; i++)
{
    Console.Write("{0}:{1}\t", i, (char)i);
    if (i % 10 == 0 && i != 0)
        Console.WriteLine();
}

// Palindrom
Console.WriteLine("\nZadejte palindrom:");
string? word = Console.ReadLine();
if (word is not null)
{
    bool palindrom = true;
    if (word.Length > 1)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                palindrom = false;
                break;
            }
        }
    }

    if (palindrom)
        Console.WriteLine("Ano, toto je palindrom.");
    else
        Console.WriteLine("Toto není palindrom.");
}

// Vigener's cipher
string? sentence = "moribundus";
string? password = "ahoj";
string? cipher = "";
string? decipher = "";

// Cipher
for (int i = 0, j = 0; i < sentence.Length; i++, j++)
{
    if (i % password.Length == 0)
        j = 0;

    int character = (int)sentence[i] + ((int)password[j] - 96);
    if (character > (int)'z')
        character -= 26;

    Console.WriteLine(character);

    cipher += (char)character;
}

Console.WriteLine(cipher);

// Decipher
for (int i = 0, j = 0; i < sentence.Length; i++, j++)
{
    if (i % password.Length == 0)
        j = 0;

    int character = (int)cipher[i] - ((int)password[j] - 96);
    if (character < (int)'a')
        character += 26;

    Console.WriteLine(character);

    decipher += (char)character;
}

Console.WriteLine(decipher);
*/
// Average of marks
Console.WriteLine("Zadejte znamky oddelene mezerou: ");
string? marks = Console.ReadLine();
string[] marksInArray = marks.Split(' ', StringSplitOptions.RemoveEmptyEntries);
double average = 0;

foreach (var item in marksInArray)
{
    average += int.Parse(item);
}

Console.WriteLine(average / marksInArray.Length);

// Happy text
Console.WriteLine("Zadej text k rozveselení:");
string inputMessage = Console.ReadLine();
string[] smiles = { " :)", " :D", " :P" };
string happyMessage = "";
int smilesCounter = 0;

for (int i = 0; i < inputMessage.Length; i++)
{
    switch (inputMessage[i])
    {
        case '.':
            happyMessage += smiles[smilesCounter];
            smilesCounter++;
            break;
        case '!':
        case '?':
            happyMessage += inputMessage[i] + smiles[smilesCounter];
            smilesCounter++;
            break;
        default:
            happyMessage += inputMessage[i];
            break;
    }

    if (smilesCounter >= 3)
        smilesCounter = 0;
}
Console.WriteLine("Rozveselený text: " + happyMessage);

// Chessboard
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if ((i + j) % 2 == 0)
            Console.Write("██");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}

// Number conversions to different base systems
string[] numberSet = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

int userNumber = 0;
int numberBase = 0;
string resultNumber = "";

// Let user to input number with base of 10
Console.WriteLine("Číslo v desítkové soustavě: ");
while (!int.TryParse(Console.ReadLine(), out userNumber));
// Let user to input base system number
Console.WriteLine("Číselná soustava (2-16): ");

while (!int.TryParse(Console.ReadLine(), out numberBase) || !(numberBase >= 2 && numberBase <= 16))
{
    Console.WriteLine("Cislo musi byt mezi 2 a 16!");
}

if (userNumber > 0)
{
    while (userNumber > 0)
    {
        int result = userNumber % numberBase;
        userNumber /= numberBase;
        resultNumber += numberSet[result];
    }

    char[] resultString = resultNumber.ToCharArray();
    Array.Reverse(resultString);
    string reverse = new string(resultString);

    Console.WriteLine("Cislo ve zvolene soustave: " + reverse);
}
/*else if (numberBase == 0)
    Console.WriteLine("Cislo ve zvolene soustave: 0");
else
    Console.WriteLine("Vase cislo je zaporne!");*/