// ARRAY
int[] array = new int[10];

// Accessing array with index number
array[0] = 1;
Console.WriteLine(array[0]);

// Filling array with for loop
for (int i = 0; i < 10; i++)
{
    array[i] = i + 1;
    Console.Write(array[i]);
}

// Filling array manually
string[] names = { "Lazik", "Patrik", "Tadeas", "Simona" };

// Array Length property
Console.WriteLine("\nArray has length " + array.Length);

// Foreach access of arrays
foreach (int item in array)
{
    Console.WriteLine(item);
}

foreach (var item in names)
{
    Console.WriteLine(item);
}

// CLASS ARRAY and its methods
// ---------------------------

// Sort()
string[] simpsons = { "Marge", "Homer", "Bart", "Maggie", "Lisa" };
Array.Sort(simpsons);
foreach (var item in simpsons)
{
    Console.WriteLine(item);
}

// Reverse()
Array.Reverse(simpsons);
foreach (var item in simpsons)
{
    Console.WriteLine(item);
}

// IndexOf() and LastIndexOf()
// This methods return first or last index of found item, if not found it returns -1
// It takes 2 parameters, first one is collection and second one is item we look for
int position = Array.IndexOf(simpsons, "Marge");
Console.WriteLine(position);

// Copy()
// Takes 3 parameters, first one is original collection, second one is target collection and third one is number of items it should copy
string[] nicknames = { "Lazik", "Lecek", "Forgo", "Chamiel", "Pulcik", "Svata" };
int copyNumber = 3;
string[] newNicknames = new string[copyNumber];
Array.Copy(nicknames, newNicknames, copyNumber);
foreach (var item in newNicknames)
{
    Console.WriteLine(item);
}

// ARRAY Methods

// Length
Console.WriteLine($"Simpsonovi maji {simpsons.Length} clenu.");

// Min(), Max(), Average(), Sum()
Console.WriteLine($"Nejstarsi ze Simpsonu je: {simpsons.Max()}");
Console.WriteLine($"Nejmladsi ze Simpsonu je: {simpsons.Min()}");
int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
Console.WriteLine($"Prumer je: {numbers.Average()}");
Console.WriteLine($"Soucet je: {numbers.Sum()}");

// Concat() - joins two arrays
string[] concatArray = nicknames.Concat(newNicknames).ToArray();
foreach (var item in concatArray)
{
    Console.WriteLine(item);
}

// Intersect - joins two arrays but only items that are in both of them
string[] intersectArray = nicknames.Intersect(newNicknames).ToArray();
foreach (var item in intersectArray)
{
    Console.WriteLine(item);
}

// Union - joins two arrays but no item will be twice in that array
string[] unionArray = nicknames.Union(intersectArray).ToArray();
foreach (var item in unionArray)
{
    Console.WriteLine(item);
}

// First(), Last()
Console.WriteLine("First item in array is: {0}", nicknames.First());
Console.WriteLine("Last ite in array is: {0}", nicknames.Last());

// Take(), Skip() - both methods takes one parameter to determine how many items to copy from original array
// Take - takes number of items from the begining
// Skip - takes rest of the items (after the number from begining)
string[] takeArray = nicknames.Take(10).ToArray();
foreach (var item in takeArray)
{
    Console.WriteLine(item);
}

string[] notFirstThree = nicknames.Skip(3).ToArray();
foreach (var item in notFirstThree)
{
    Console.WriteLine(item);
}

// Contains - returns true or fales if it founds an item
bool result = nicknames.Contains("Lazik");
Console.WriteLine(result + "\n");

// Reverse - returns new array when items are in reverse order
string[] reverseNicknames = nicknames.Reverse().ToArray();
foreach (var item in nicknames)
{
    Console.WriteLine(item);
}
foreach (var item in reverseNicknames)
{
    Console.WriteLine(item);
}

// Distinct - delets duplicit items in an array and returns new array
int[] bunchOfNumbers = { 1, 2, 3, 2, 1, 2, 3, 4, 9 };
int[] distinctNumbers = bunchOfNumbers.Distinct().ToArray();
foreach (var item in distinctNumbers)
{
    Console.WriteLine(item);
}

// Variable array length in runtime example
Console.WriteLine("Please insert number of your marks: ");
int numberOfMarks = int.Parse(Console.ReadLine());
int[] marks = new int[numberOfMarks];
for (int i = 0; i < numberOfMarks; i++)
{ 
    marks[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(marks.Average());