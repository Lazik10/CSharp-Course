// Numbers

/*
Datový typ                    Rozsah                                  Velikost  NET typ
-----------------------------------------------------------------------------------------------

sbyte                       -128 až 127                                 8 bitů  System.SByte
byte                           0 až 255                                 8 bitů  System.Byte
short                    -32 768 až 32 767                             16 bitů  System.Int16
ushort                         0 až 65 535                             16 bitů  System.UInt16
int               -2 147 483 648 až 2 147 483 647                      32 bitů  System.Int32
uint                           0 až 4 294 967 295                      32 bitů  System.UInt32
long  -9 223 372 036 854 775 808 až 9 223 372 036 854 775 807	       64 bitů  System.Int64
ulong                          0 až 18 446 744 073 709 551 615	       64 bitů  System.UInt64

float              +-1.5 * 10−45 až +-3.4 * 1038                       7 čísel  System.Single
double            +-5.0 * 10−324 až +-1.7 * 10308                  15-16 čísel  System.Double
decimal            +-1.0 * 10−28 až +-7.9 * 1028                   28-29 čísel  System.Decimal

char                      U+0000 až U+ffff                             16 bitů  System.Char
bool                        true nebo false                             8 bitů  System.Boolean
*/

//Examples:
int a = 10;
System.Int32 b = 11;

float f = 3.14F;
double d = 2.72;
decimal m = 3.14159265358979323846m;

char c = 'a';

bool isTrue = false;
bool expression = (15 > 5);
Console.WriteLine(expression + "\n");

// Parse systems
//-----------------------

// 1) int.Parse()
var inputString = "123";
var outputString = int.Parse(inputString);

// 2) Convert
var inputString2 = "123";
var outputString2 = Convert.ToInt32(inputString2);

// Difference between int.Parse() and Convert.ToInt32()
string? inputNullString = null;
try
{
    var outputInteger = int.Parse(inputNullString);
    Console.WriteLine(outputInteger);
}
catch (ArgumentNullException ex)
{ 
    Console.WriteLine(ex.Message);
}

var outputIntegerWithConvert = Convert.ToInt32(inputNullString);
Console.WriteLine($"The value of the outputIntegerWithConvert variable is: {outputIntegerWithConvert}\n");

// 3) TryParse() - BEST OPTION!!!
bool success;
do
{
    Console.WriteLine("Please insert any int number: ");
    string? userInput = Console.ReadLine();
    success = int.TryParse(userInput, out int outputInteger);

    if (!success)
        Console.WriteLine("You have to insert at least one character representing number!");
    else
        Console.WriteLine($"Your input is: {outputInteger}");
}
while (!success);
