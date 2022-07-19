using LINQ_Exercises;

/*const string cestina = "čeština";
const string slovenstina = "slovenština";
const string anglictina = "angličtina";
const string nemcina = "němčina";
const string rustina = "ruština";
const string spanelstina = "španělština";

Human jiri = new Human("Jiří", cestina, anglictina, rustina);
Human hynek = new Human("Hynek", cestina, rustina);
Human petr = new Human("Peter", slovenstina, anglictina);
Human simona = new Human("Simona", cestina, anglictina);
Human tereza = new Human("Terézia", slovenstina, nemcina, rustina);
Human viktor = new Human("Viktor", cestina, anglictina);
Human roman = new Human("Roman", cestina, anglictina, nemcina);
Human julie = new Human("Julie", cestina, nemcina, spanelstina);

List<Human> humans = new List<Human>() { jiri, hynek, petr, simona, tereza, viktor, roman, julie };

List<string> SpeaksLanguage(string language)
{
    var query = from h in humans
                where h.Languages.Contains(language)
                select h.Name;
    return query.ToList();
}

List<string> SpeaksLanguages(List<string> language)
{
    var query = from h in humans
                where h.Languages.Contains(language[0]) && h.Languages.Contains(language[1])
                select h.Name;
    return query.ToList();
}

void PrintPeople(List<string> people)
{
    foreach (var item in people)
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine();
}

List<string> result = new List<string>();

Console.Write("Osoby hovořící česky: \n ");
result = SpeaksLanguage(cestina);
PrintPeople(result);

Console.Write("Osoby hovořící německy: \n ");
result = SpeaksLanguage(nemcina);
PrintPeople(result);

Console.Write("Osoby hovořící anglicky: \n ");
result = SpeaksLanguage(anglictina);
PrintPeople(result);

Console.Write("Osoby hovořící rusky: \n ");
result = SpeaksLanguage(rustina);
PrintPeople(result);

Console.Write("Osoby hovořící španělsky: \n ");
result = SpeaksLanguage(spanelstina);
PrintPeople(result);

Console.Write("Osoby hovořící česky a zároveň německy: \n ");
result = SpeaksLanguages(new List<string>() { cestina, nemcina });
PrintPeople(result);

var query = from h in humans
            where !h.Languages.Contains(anglictina) && !h.Languages.Contains(cestina)
            select h.Name;
Console.Write("Osoby nehovořící česky ani anglicky: \n ");
PrintPeople(query.ToList());

query = from h in humans
        where h.Languages.Contains(rustina) || h.Languages.Contains(spanelstina)
        select h.Name;
Console.Write("Osoby hovořící rusky nebo španělsky: \n ");
PrintPeople(query.ToList());

// Planets
Planet merkur = new Planet("Merkur", 2440, 0, true, 440);
Planet venuse = new Planet("Venuše", 12104, 0, true, 737);
Planet zeme = new Planet("Země", 12756, 1, true, 287);
Planet mars = new Planet("Mars", 6792, 2, true, 210);
Planet jupiter = new Planet("Jupiter", 142984, 79, false, 152);
Planet saturn = new Planet("Saturn", 120536, 82, false, 93);
Planet uran = new Planet("Uran", 51118, 27, false, 68);
Planet neptun = new Planet("Neptun", 49528, 14, false, 53);

List<Planet> list = new List<Planet>();
list.Add(merkur);
list.Add(venuse);
list.Add(zeme);
list.Add(mars);
list.Add(jupiter);
list.Add(saturn);
list.Add(uran);
list.Add(neptun);

var query1 = from planet in list
             where planet.IsRock == false
             select planet;

Console.WriteLine("Plynné planety ");
*//*foreach (var item in query1)
{
    Console.WriteLine(" " + item.Name);
}*//*

var plynnePlanety = list.Where(item => !item.IsRock).OrderByDescending(item => item.Diameter).Select(item => item.Name);
foreach (var item in plynnePlanety)
{
    Console.WriteLine(" " + item);
}

var kamennePlanety = list.Where(item => item.IsRock).OrderByDescending(item => item.Diameter).Select(item => item.Name);
Console.WriteLine("Kamenné planety ");
foreach (var item in kamennePlanety)
{
    Console.WriteLine(" " + item);
}

var higherAverageTemperature = list.Where(item => item.AverageTemperature > 273.15).Select(item => item.Name);
Console.WriteLine("Planety s průměrnou teplotou vyšší než 0°C (273,15 K): ");
foreach (var item in higherAverageTemperature)
{
    Console.WriteLine(" " + item);
}

var planetsWithMoons = list.Where(item => item.NumberOfMoons > 0).Select(item => item.Name);
Console.WriteLine("Planety s měsíci: ");
foreach (var item in planetsWithMoons)
{
    Console.WriteLine(" " + item);
}

var planetsBiggerThanVenuse = list.Select((item, index) => new { Index = index, Planet = item.Name, Diameter = item.Diameter }).Where(item => item.Diameter > 12104);
Console.WriteLine("Planety vetší než Venuše: ");
foreach (var item in planetsBiggerThanVenuse)
{
    Console.WriteLine(" " + (item.Index + 1) + ". planeta - " + item.Planet);
}


// Procesors
List<Procesor> procesory = new List<Procesor>
{
    new Procesor("AMD EPYC 7702", 64, 128, 3.35, 256, 169246, 0),
    new Procesor("Intel Core i5-9600K", 6, 6, 4.6, 9, 4928, 12),
    new Procesor("AMD Ryzen 5 5600X", 6, 12, 4.6, 32, 8740, 5),
    new Procesor("Intel Core i9-10900K", 10, 20, 5.3, 20, 12055, 32),
    new Procesor("AMD Ryzen 9 3900X", 12, 24, 4.6, 64, 12055, 1),
    new Procesor("Intel Core i3-10105", 4, 8, 4.4, 6, 3101, 9),
    new Procesor("Intel Xeon Gold 6252", 24, 48, 3.7, 36, 102406, 9),
};

string[] choices = { "Cena (Kč)", "Kusů na skladě", "Frekvence (GHz)", "Počet jader", "Počet vláken", "Vyrovnávací paměť (MB)" };

int choice = 0;

Intro();
do
{
    Console.WriteLine();
    Console.Write("Seřadit podle: ");
    while (!int.TryParse(Console.ReadLine(), out choice));
    Console.WriteLine();
    if (choice >= 0 && choice < 6)
        Sort(choice, procesory);

} while (choice >= 0 && choice < 6);

void Intro()
{
    Console.WriteLine("[0]: Cena (Kč)");
    Console.WriteLine("[1]: Kusů na skladě");
    Console.WriteLine("[2]: Frekvence (GHz)");
    Console.WriteLine("[3]: Počet jader");
    Console.WriteLine("[4]: Počet vláken");
    Console.WriteLine("[5]: Vyrovnávací paměť (MB)");
}

void Sort(int value, List<Procesor> procesors)
{
    Console.WriteLine(@"Procesory seřazené podle ""{0}"": ", choices[value]);

    ProcesorComparer comparer = new ProcesorComparer((ProcesorComparer.SortBy)value);
    procesors.Sort(comparer);
    procesors.Reverse();

    foreach (var item in procesors)
    {
        Console.WriteLine(" " + item.Nazev + " - " + (value == 0 ? item.Cena : value == 1 ? item.KusuSkladem :
                                                      value == 2 ? item.Frekvence : value == 3 ? item.PocetJader :
                                                      value == 4 ? item.PocetVlaken : value == 5 ? item.VyrovnacaciPamet : item.VyrovnacaciPamet));
    }
}


// Income
string[] mesice = { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };
//decimal[] income = { -25680, -12352, 1204, 13570, 36879, 40010, 62323, 59861, 12547, 1506, 26, -5892 };
List<MonthIncome> incomes = new List<MonthIncome>();

for (int i = 0; i < mesice.Length; i++)
{
    Console.Write(mesice[i] + ": ");
    decimal income = 0;
    while (!decimal.TryParse(Console.ReadLine(), out income)) ;
    incomes.Add(new MonthIncome(mesice[i], income));
}

foreach (var month in incomes)
{
    Console.WriteLine(month.Name + ": " + month.Amount);
}

Console.WriteLine();
Console.WriteLine("Celkový roční výdělek: {0} Kč", incomes.Sum(x => x.Amount));
Console.WriteLine("Průměrný výdělek {0} Kč", incomes.Average(x => x.Amount));
Console.WriteLine("Nejmenší výdělek {0} Kč", incomes.Min(x => x.Amount));
Console.WriteLine("Největší výdělek {0} Kč", incomes.Max(x => x.Amount));
Console.WriteLine("Počet výdělečných měsíců {0}", incomes.Where(x => x.Amount > 0).Count());
Console.WriteLine("Počet prodělečných měsíců {0}", incomes.Where(x => x.Amount < 0).Count());
Console.WriteLine("První výdělečný měsíc {0}", incomes.Where(x => x.Amount > 0).First().Name);
Console.WriteLine("Poslední výdělečný měsíc {0}", incomes.Where(x => x.Amount > 0).Last().Name);*/


/*
// Food list
//Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();
List<Food> items = new List<Food>();
string[] foodCategories = { "Ovoce a zelenina", "Luštěniny", "Pečivo", "Mléčné výrobky", "Maso", "Sladkosti", "Nápoje", "Ostatní" };
for (int i = 0; i < foodCategories.Length; i++)
{
    Console.WriteLine("[" + i + "]" + foodCategories[i]);
    //items[foodCategories[i]] = new List<string>();
}
Console.WriteLine("-------------------------------------");

bool addNext = true;
do
{
    Console.Write("Položka: ");
    string food = Console.ReadLine();
    int category;
    Console.Write("Kategorie: ");
    while (!int.TryParse(Console.ReadLine(), out category)) ;

    //items[foodCategories[category]].Add(food);
    items.Add(new Food(food, foodCategories[category]));

    Console.Write("Přidat další položku [ano/ne]: ");
    string answer = Console.ReadLine();
    addNext = answer != "ne";

} while (addNext);

var query10 =   from categ in foodCategories
                join item in items on categ equals item.Category into categitem
                select new { Category = categ, Food = categitem };

foreach (var item in query10)
{
    Console.Write(item.Category.ToUpper() + ": ");

    if (item.Food.Any())
    {
        foreach (var food in item.Food)
        {
            Console.Write(food.Name);
        }
    }
    else
        Console.Write("-");

    Console.WriteLine();
    Console.WriteLine();
}*/

/*foreach (KeyValuePair<string, List<string>> entry in items)
{
    Console.Write(entry.Key.ToUpper() + ": ");
    if (entry.Value.Count > 0)
    {
        foreach (var item in entry.Value)
        {
            Console.Write(item + " ");
        }
    }
    else
        Console.Write("-");

    Console.WriteLine();
    Console.WriteLine();
}*/

// Faktorial
var queryFact = from factorial in Enumerable.Range(1, 120).Select(x => (double)x)
                select factorial;

double number = 0;
while (true)
{
    Console.Write("Chci vědět faktoriál čísla: ");
    //while (!double.TryParse(Console.ReadLine(), out number)) ;
    number = double.Parse(Console.ReadLine());
    if (!(number <= 120 && number >= 0))
        break;

    var resultFact = queryFact.TakeWhile(x => x <= number).Aggregate((double)1, (x, next) => x *= next);
    Console.WriteLine("{0}! = {1}", number, number != 0 ? resultFact : 1);
    Console.WriteLine();
}