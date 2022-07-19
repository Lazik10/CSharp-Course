// Math

// Math.Pi
Console.WriteLine("Pi: " + Math.PI);

// Math.E
Console.WriteLine("e: " + Math.E);

// Tau.Tau - number of radians in round
Console.WriteLine("Tau: " + Math.Tau);

// Methods

// Roud(), Ceiling(), Floor(), Truncate()

// Round - returns double, rounds up from 0.5, otherwise down
double d = 2.75;
int a = (int)Math.Round(d); // Round returns double so if we want to assign it to int we have to explicitly convert it
Console.WriteLine(Math.Round(d));
Console.WriteLine(a);

// IMPORTANT
Console.WriteLine(Math.Round(0.5)); // 0.5 is rounded down, because next int is not power of 2
Console.WriteLine(Math.Round(1.5)); // 1.5 is rounded up, because next int is power of 2

// Ceiling - always rounds up to next int
Console.WriteLine(Math.Ceiling(d));

// Floor - always rounds down to previous int
Console.WriteLine(Math.Floor(d));
// Truncate - omits the decimal numbers
Console.WriteLine(Math.Truncate(d));

// Diference between Floor and Truncate is that if we count with negative numbers
// Floor rounds to previous negative number and Truncate rounds up to next negative number !!!

// Abs() - returns absolute numbers -> negative numbers without negative sign
int negativeNumber = -100;
Console.WriteLine(Math.Abs(negativeNumber));

// Sign() - returns -1 for negative numbers, 0 for 0 and 1 for positive numbers
int positiveNumber = 100;
int zero = 0;
Console.WriteLine(Math.Sign(positiveNumber));
Console.WriteLine(Math.Sign(zero));
Console.WriteLine(Math.Sign(negativeNumber));

// Sin(), Cos(), Tan(), Acos(), Asin(), Atan()

double degree = 360;
Console.WriteLine(degree * (Math.PI / 180));

double radians = Math.Tau;
Console.WriteLine(radians * (180 / Math.PI));