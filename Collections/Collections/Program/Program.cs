using System.Collections;
using Collections.Classes;
using Collections;

// Nongeneric collection ArrayList stores all elements as an object type
// so we can add anything into this collection
ArrayList list = new ArrayList();
list.Add("text");
list.Add(1);
Console.WriteLine(list[0]);
Console.WriteLine((string)list[0]);

List<int> list2 = new List<int>();


// Generic type - instead of generic T we specifi datatype when creating instance of that object and that object will work with that type
Generic<int> variableInt = new Generic<int>(10);
Generic<string> variableString = new Generic<string>("Name");
Generic<string> variableString2 = new Generic<string>("Name");
bool equals = variableString2.Compare<string>(variableString._value);
Console.WriteLine(equals);


// Linked List
LinkedList<int> seznam = new LinkedList<int>();
LinkedListNode<int> hlava = seznam.AddFirst(5);
seznam.AddAfter(hlava, 10);
seznam.AddFirst(1);
seznam.AddFirst(2);
seznam.AddLast(3);
Console.WriteLine("seznam first: " + seznam?.First?.Value);
Console.WriteLine("seznam second: " + seznam?.First?.Next?.Value);
Console.WriteLine("seznam second: " + seznam?.First?.Next?.Next?.Next?.Next?.Next?.Value);

foreach (var item in seznam)
{
    Console.WriteLine(item);
}

// Boxes
UniversalBox<Book> box2 = new UniversalBox<Book>(new Book("Zlocin a trest"));
UniversalBox<Shoe> box1 = new UniversalBox<Shoe>(new Shoe("Adidas", 8));
UniversalBox<Bottle> box3 = new UniversalBox<Bottle>(new Bottle("Sprite", 700));

Console.WriteLine("V první krabici jsou {0} velikosti 39", box1.Item.Name, (box1.Item as Shoe).Size);
Console.WriteLine("Ve druhé krabici je kniha s názvem Proměna");
Console.WriteLine("Ve třetí krabici je termoska o objemu 1,5 l");
Console.WriteLine("Ve čtvrté krabici jsou zimní boty velikosti 42");

// Diary
Diary diary = new Diary();
diary.Intro();

// Dictionary
Dictionary<string, string> dic = new Dictionary<string, string>();
dic.Add("1", "Lazik");
dic.Add("2", "Lazik");
Console.WriteLine("Pocet prvku je: " + dic.Count);

Array array = dic.Keys.ToArray();
foreach (var item in array)
{
    Console.WriteLine(item);
}

foreach (var item in dic.Keys)
{
    Console.WriteLine(item + ", " + dic[item]);
}

foreach (KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine(pair);
    Console.WriteLine(pair.Value + " " + pair.Key);
}

// Programmers
List<Programmer> programmerList = new List<Programmer>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Zadejte {0}. programátora", i + 1);
    Console.Write("Jméno: ");
    string name = Console.ReadLine();
    Console.Write("Programovací jazyky (oddělujte čárkou a mezerou): ");
    string[] languages = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < languages.Length; j++)
    {
        languages[j] = languages[j].Trim();
    }
    programmerList.Add(new Programmer(name, languages));
}

HashSet<string> allLanguages = new HashSet<string>();

// All languages:
foreach (Programmer programmer in programmerList)
{
    allLanguages = new HashSet<string>(allLanguages.Union(programmer.ProgrammingLanguages));
}
Console.WriteLine("Všechny jazyky: {0}", string.Join(", ", allLanguages) + ",");

// Common Languages
foreach (var programmer in programmerList)
{
    allLanguages.IntersectWith(new HashSet<string>(programmer.ProgrammingLanguages));
}
Console.WriteLine("Společné jazyky: {0}", string.Join(", ", allLanguages) + ",");
Console.WriteLine();

// Unique Languages
foreach (Programmer item in programmerList)
{
    HashSet<string> uniqueLanguages = new HashSet<string>(item.ProgrammingLanguages);
    foreach (var programmer in programmerList)
    {
        if (item != programmer)
            uniqueLanguages.ExceptWith(programmer.ProgrammingLanguages);
    }
    Console.WriteLine("Jazyky, které umí jen {1}: {0}", string.Join(", ", uniqueLanguages) + ",", item.Name);
}

// Find path from S-start to F-finish
// Prostředí, ve kterém hledáme cestu (1 = překážka, 0 = volná plocha)
int[,] environment = new int[12, 12]
{
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1 },
            { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1 },
            { 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1 },
            { 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1 },
            { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
};

// Zde se budou ukládat všechny procházené body
Point[,] points = new Point[environment.GetLength(0), environment.GetLength(1)];
Point startPoint = new Point(4, 7, 1);
Point endPoint = new Point(8, 9, int.MaxValue);

points[startPoint.X, startPoint.Y] = startPoint;

Queue<Point> path = new Queue<Point>();
Queue<Point> currQue = new Queue<Point>();
path.Enqueue(startPoint);

int step = 2;

while (path.Count > 0)
{
    Point point = path.Dequeue();

    if (point.X == endPoint.X && point.Y == endPoint.Y)
        break;

    // Up
    if (environment[point.X, point.Y - 1] != 1 && points[point.X, point.Y - 1].Value == 0)
    {
        currQue.Enqueue(new Point(point.X, point.Y - 1, step));
        points[point.X, point.Y - 1] = new Point(point.X, point.Y - 1, step);
    }
    // Left
    if (environment[point.X - 1, point.Y] != 1 && points[point.X - 1, point.Y].Value == 0)
    {
        currQue.Enqueue(new Point(point.X - 1, point.Y, step));
        points[point.X - 1, point.Y] = new Point(point.X - 1, point.Y, step);
    }
    // Down
    if (environment[point.X, point.Y + 1] != 1 && points[point.X, point.Y + 1].Value == 0)
    {
        currQue.Enqueue(new Point(point.X, point.Y + 1, step));
        points[point.X, point.Y + 1] = new Point(point.X, point.Y + 1, step);
    }
    // Right
    if (environment[point.X + 1, point.Y] != 1 && points[point.X + 1, point.Y].Value == 0)
    {
        currQue.Enqueue(new Point(point.X + 1, point.Y, step));
        points[point.X + 1, point.Y] = new Point(point.X + 1, point.Y, step);
    }

    if (path.Count == 0)
    {
        path = new Queue<Point>(currQue);
        step++;
    }
}

Stack<Point> finalPath = new Stack<Point>();
finalPath.Push(endPoint);
int endValue = points[endPoint.X, endPoint.Y].Value - 1;
Point searchedPoint = endPoint;

// Generate Path
while(endValue > 0)
{
    if (points[searchedPoint.X, searchedPoint.Y - 1].Value == endValue)
        searchedPoint = new Point(searchedPoint.X, searchedPoint.Y - 1, endValue);
    else if (points[searchedPoint.X - 1, searchedPoint.Y].Value == endValue)
        searchedPoint = new Point(searchedPoint.X - 1, searchedPoint.Y, endValue);
    else if (points[searchedPoint.X, searchedPoint.Y + 1].Value == endValue)
        searchedPoint = new Point(searchedPoint.X, searchedPoint.Y + 1, endValue);
    else if (points[searchedPoint.X + 1, searchedPoint.Y].Value == endValue)
        searchedPoint = new Point(searchedPoint.X + 1, searchedPoint.Y, endValue);

    finalPath.Push(searchedPoint);
    endValue--;
}

// Print Path
while (finalPath.Count > 0)
{
    Point point = finalPath.Pop();
    Console.Write("[" + point.X + ";" + point.Y + "] ");
}

// Hanoi Towers
int[] ints = { 5, 4, 3, 2, 1 };
Stack<int> firstTower = new Stack<int>(ints);
Stack<int> secondTower = new Stack<int>();
Stack<int> thirdTower = new Stack<int>();
bool win = false;

bool CheckForWin(Stack<int> tower)
{
    int[] winCondition = { 5, 4, 3, 2, 1 };
    Stack<int> stack = new Stack<int>(winCondition);
    Stack<int> compareStack = new Stack<int>(new Stack<int>(tower));

    if (stack.Count != tower.Count)
        return false;
  
    for (int i = 0; i < stack.Count; i++)
    {
        if (stack.Pop() != compareStack.Pop())
        {
            return false;
        }
    }
    return true;
}

void PrintTowers()
{
    string[] strFirstTower = TowerToArray(firstTower);
    string[] strSecondTower = TowerToArray(secondTower);
    string[] strThirdTower = TowerToArray(thirdTower);
    Console.WriteLine();
    Console.WriteLine("1".PadRight(10) + "2".PadRight(10) + "3".PadRight(10));
    for (int i = 0; i < 5 ; i++)
    {
        Console.WriteLine(strFirstTower[i] + strSecondTower[i] + strThirdTower[i]);
    }
}

string[] TowerToArray(Stack<int> stack)
{
    Stack<int> tower = new Stack<int>(new Stack<int>(stack));
    string[] strTower = new string[5];
    int towerHeight = stack.Count;
    int position = 0;

    for (int i = 0; i < 5 - towerHeight; i++)
    {
        strTower[position] = "          ";
        position++;
    }

    for (int j = 0; j < towerHeight; j++)
    {
        strTower[position] = CreateDisc(tower.Pop());
        position++;
    }

    return strTower;
}

string CreateDisc(int value)
{
    const int length = 10;
    string disc = "";

    for (int i = 0; i < length / 2 - value; i++)
        disc += " ";

    for (int i = 0; i < value; i++)
        disc += "██";

    for (int i = 0; i < length / 2 - value; i++)
        disc += " ";

    return disc;
}

(Stack<int>, Stack<int>) AskForMove()
{
    int from, to;
    Console.Write("Přesunout kotouč z věže: ");
    while (!int.TryParse(Console.ReadLine(), out from) && !(from > 0 && from < 4));
    Console.Write("Přesunout kotouč na věž: ");
    while (!int.TryParse(Console.ReadLine(), out to) && !(to > 0 && to < 4));

    return (GetTower(from), GetTower(to));
}

Stack<int> GetTower(int value)
{
    Stack<int> stack = new Stack<int>();
    switch (value)
    {
        case 1:
            stack = firstTower;
            break;
        case 2:
            stack = secondTower;
            break;
        case 3:
            stack = thirdTower;
            break;
        default:
            break;
    }
    return stack;
}

void ChangeDisc(Stack<int> fromTower, Stack<int> toTower)
{
    if (fromTower.Count > 0 && fromTower.Count <= 5 && toTower.Count < 5 && toTower.Count >= 0)
    {
        int disc = fromTower.Pop();

        if (toTower.Count == 0)
            toTower.Push(disc);
        else if (disc < toTower.Peek() && toTower.Count > 0)
            toTower.Push(disc);
        else
            Console.WriteLine("Nelze presunout vetsi disk na mensi!");
    }
}

do
{
    PrintTowers();

    (Stack<int> from, Stack<int> to) = AskForMove();
    ChangeDisc(from, to);

    if (/*CheckForWin(firstTower) || */CheckForWin(secondTower) || CheckForWin(thirdTower))
    {
        win = true;
        PrintTowers();
        Console.WriteLine("Vyhrál jsi!");
    }

} while (!win);

