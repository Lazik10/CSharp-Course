using List;

/// <summary>
/// List
/// </summary>

List<int> list = new List<int>();

/// <summary>
/// Properties
/// </summary>

// Count - same as Length in arrays

/// <summary>
/// Methods
/// </summary>

// Add() - adds an item to the list
list.Add(0);

// AddRange() - adds range of items into the list (another array or list etc)
list.AddRange(list);

// Clear() - clears all items in the list
list.Clear();

// Contains(item) - returns false or true if that item is found in the list
list.Contains(0);

// CopyTo() - copies all items into the new compatible array, we can add parameters for starting position and number of items
list.Add(0);
int[] list2 = new int[10];
list.CopyTo(list2);

// IndexOf(item) - returns index of the first occurance of item in the list
list.IndexOf(0);

// Insert(index, item) - insert items at the specific index in the lsit
list.Insert(0, 1);

// InsertRange(index, collection) - inserts items of the collection into the list at specific position
List<int> list3 = new List<int> { 2, 3 };
list.InsertRange(1, list3);
//Console.WriteLine(list);

// LastIndexOf() - returns index of the last occurance of the item in the list
list.LastIndexOf(0);

// Remove() - Removes first found item
list.Remove(0);

// RemoveAt(index) - Removes item at the specific position
list.RemoveAt(0);

// RemoveRange() - Removes specific number of items from the specific index
list.RemoveRange(0, 0);

// Reverse() - revers the whole list
list.Reverse();

// Sort() - sorts the list
list.Sort();

// ToArray() - copies items from the list to a new array which it returns
list.ToArray();

/// <summary>
/// Another Methods
/// </summary>

// Average() - returns double average
list.Average();

// Distinct() - returns unique elements from the list
list.Distinct();

// First() - returns first element of the list
list.First();

// Last() - returns last element of the list
list.Last();

// Intersect() - returns intersect of two lists
list.Intersect(list);

// Union() - returns two lists joined together
list.Union(list);

// Min(), Max(), Sum()
list.Min();
list.Max();
list.Sum();

// Take() - returns number of items from the start of the list
list.Take(0);

Lottery lottery = new Lottery();

Console.WriteLine("Welcome in lottery!");
char choice = '0';

while (choice != '3')
{
    Console.WriteLine("1 - Draw new number");
    Console.WriteLine("2 - Show drawn numbers");
    Console.WriteLine("3 - End");

    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (choice)
    {
        case '1':
            Console.WriteLine("Drawn number is: {0}", lottery.DrawNumber());
            break;
        case '2':
            Console.WriteLine("Drawn numbers are: {0}", lottery.GetDrawnNumbers());
            break;
        case '3':
            Console.WriteLine("End of lottery!");
            break;
        default:
            Console.WriteLine("Incorrect choice, please try again.");
            break;
    }
}

