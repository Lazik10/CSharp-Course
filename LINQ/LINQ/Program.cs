string[] names = { "David", "Martin", "Dan", "Petr", "Vratislav", "Eliska" };

var query = from name in names 
            where name.Length > 5 
            orderby name.Length /*, another field for order */ descending /*ascending*/
            select name;

// var query = names.Where(name => name.Length > 15).OrderBy/OrderByDescending(name => name.Name).Select(name => name.Age);

foreach (var name in query)
{
    Console.WriteLine(name);
}

// Anonymous types
var anonymous = new { Name = "Anonymous", Surname = "Anonymous", Age = 15 };
Console.WriteLine(anonymous.Name);
Console.WriteLine(anonymous.Surname);
Console.WriteLine(anonymous.Age);



/// GROUP BY
Osoba karel = new Osoba("Karel", "Novák", 15);
Osoba josef = new Osoba("Josef", "Nový", 24);
Osoba jan = new Osoba("Jan", "Marek", 13);
Osoba marie = new Osoba("Marie", "Nová", 18);
Osoba simona = new Osoba("Simona", "Mladá", 24);
Osoba michaela = new Osoba("Michaela", "Marná", 14);

List<Osoba> uzivatele = new List<Osoba> { karel, josef, jan, marie, simona, michaela };

var dotaz = from u in uzivatele
            group u by u.Vek into vekovaSkupina
            select new { Vek = vekovaSkupina.Key, Uzivatele = vekovaSkupina };


foreach (var skupina in dotaz)
{
    Console.WriteLine(skupina.Vek);
    foreach (var uzivatel in skupina.Uzivatele)
        Console.WriteLine(uzivatel.Jmeno);
}

/// WHERE
int[] cisla1 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz1 = from c in cisla1
            where (c > 5)
            select c;

foreach (int c in dotaz1)
    Console.WriteLine(c);

/// INDEXED WHERE()
int[] cisla2 = { 0, 5, 2, 5, 4, 1, 3, 7 };

var dotaz2 = cisla2.Where((cislo, index) => cislo == index);

foreach (int c in dotaz2)
    Console.WriteLine(c);

/// SELECT
int[] cisla3 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz3 = from c in cisla3
            where (c > 5)
            select c * 2;


foreach (int c in dotaz3)
    Console.WriteLine(c);

/// INDEXED SELECT
int[] cisla4 = { 3, 5, 8, 5 };

var dotaz4 = cisla4.Select((cislo, index) => new { Index = index, Hodnota = cislo });

foreach (var d in dotaz4)
    Console.WriteLine(d);

/// TAKE(int) - Takes number of first elements
int[] cisla5 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz5 = cisla5.Take(3).Where(cislo => cislo > 4);

foreach (int c in dotaz5)
    Console.WriteLine(c);

// Random
int[] cisla7 = { 3, 5, 8, 5, 9, 1, 3, 4 };
Random r = new Random();

var dotaz7 = cisla7.Skip(r.Next(cisla7.Length)).Take(1);

foreach (int c in dotaz7)
    Console.WriteLine(c);

/// SKIP(int) - same as take, but it skips first number of elements
int[] cisla6 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz6 = cisla6.Skip(5);

foreach (int c in dotaz6)
    Console.WriteLine(c);

/// TAKEWHILE()
int[] cisla8 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz8 = cisla8.TakeWhile(c => c > 2);

foreach (int c in dotaz8)
    Console.WriteLine(c);

/// SKIPWHILE()
int[] cisla9 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz9 = cisla9.SkipWhile(c => c > 2);

foreach (int c in dotaz9)
    Console.WriteLine(c);

/// ORDERBY() with IComparer
string[] slova10 = { "Argentina", "anakonda", "aLbert", "Bizon", "brčál", "BOmba" };

var dotaz10 = slova10.OrderBy(s => s, new CaseSensitiveComparer());

foreach (string s in dotaz10)
    Console.WriteLine(s);

/// DISTINCT(), UNION(), INTERSECT(), EXCEPT()
// Distinct()
int[] cisla11 = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz11 = cisla11.Distinct();

foreach (int c in dotaz11)
    Console.WriteLine(c);

// Union()
int[] mnozina1 = { 3, 5, 8, 5, 9, 1, 3, 4 };
int[] mnozina2 = { 3, 7, 2, 1, 4 };

var dotaz12 = mnozina1.Union(mnozina2);

foreach (int c in dotaz12)
    Console.WriteLine(c);

// Intersect()
int[] mnozina3 = { 3, 5, 8, 5, 9, 1, 3, 4 };
int[] mnozina4 = { 3, 7, 2, 1, 4 };

var dotaz13 = mnozina3.Intersect(mnozina4);

foreach (int c in dotaz13)
    Console.WriteLine(c);

// Except()
int[] mnozina5 = { 3, 5, 8, 5, 9, 1, 3, 4 };
int[] mnozina6 = { 3, 7, 2, 1, 4 };

var dotaz14 = mnozina5.Except(mnozina6);

foreach (int c in dotaz14)
    Console.WriteLine(c);


/// First(), First(with condition), FirstOrDefault(), Last(), ElementAt()
// First()FirstOrDefault()
int[] cisla = { 3, 5, 8, 5, 9, 1, 3, 4 };

var dotaz15 = (from c in cisla
             where (c > 5)
             select c).First();

Console.WriteLine(dotaz15);

// First(with condition), 
var nalezen = cisla.First(c => c > 5);
Console.WriteLine(nalezen);

// FirstOrDefault() - returns default value if not found
int[] prazdno = { };
int hledany = prazdno.FirstOrDefault();
Console.WriteLine(hledany);

// Last
var nalezenPosledni = cisla.Last(c => c > 5);
Console.WriteLine(nalezenPosledni);

// ElementAt()
var thirdNumber = cisla.OrderByDescending(c => c).ElementAt(2);
Console.WriteLine(thirdNumber);


/// Generating operators
// Range()
var queryRange = from x in Enumerable.Range(20, 11)
                 select new { Cislo = x, Sude = (x % 2 == 0) };
foreach (var item in queryRange)
{
    Console.WriteLine(item);
}

// Repeat()
var queryRepeat = Enumerable.Repeat("day", 3); // what and how many times
foreach (var item in queryRepeat)
{
    Console.WriteLine(item);
}

// Quantificators
// Any() - at least one item in collection meets the requirements
bool result = (from x in cisla
              where x > 5
              select x).Any();
result = cisla.Any(x => x > 5);
Console.WriteLine(result);

// Any with group by
/*var dotaz = from p in programatori
            group p by p.Vek into vekovaSkupina
            where vekovaSkupina.Any(p => p.Pohlavi == "zena")
            select new { Vek = vekovaSkupina.Key, Programatorky = vekovaSkupina };*/

// All() - returns true or false if all items in collection meets the reguirements
bool splnuje = cisla.All(c => c > 5);
Console.WriteLine(splnuje);


/// Aggregate operators
// Count()
var unique = cisla.Distinct().Count();
Console.WriteLine(unique);

// Count(with condition)
var count = cisla.Count(x => x > 5);
Console.WriteLine(count);

// Sum
var sum = cisla.Sum();
Console.WriteLine(sum);

// Sum with projection
string[] slova = { "SOcialNi", "SiT", "ITnetWOrk" };
int celkovaDelka = slova.Sum(s => s.Length);
Console.WriteLine(celkovaDelka);

// Sum with group by
/*var dotaz = from p in programatori
            group p by p.Vek into vekovaSkupina
            where vekovaSkupina.Any(p => p.Pohlavi == "zena")
            select new { Vek = vekovaSkupina.Key, Programatorky = vekovaSkupina, Programu = vekovaSkupina.Sum(p => p.Programu) };*/

// Min(), Max(), Average()
int minimum = cisla.Min();
int maximum = cisla.Max();
double average = cisla.Average();
Console.WriteLine(minimum);
Console.WriteLine(maximum);
Console.WriteLine(average);

// Aggregate
int soucet = cisla.Aggregate((agregovany, dalsi) => agregovany += dalsi);
int soucet0 = cisla.Aggregate(10, (agregovany, dalsi) => agregovany += dalsi); // first parameter 10 is starting value of aggregation

Console.WriteLine(soucet);
Console.WriteLine(soucet0);

// Concat()
int[] cislaX = { 3, 5, 8, 5 };
int[] cislaY = { 3, 5, 8, 5 };

var queryXY = cislaX.Concat(cislaY);
foreach (var item in queryXY)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// SequenceEqual() - returns true or false if two sequence of collections are exactly the same
var sequenceEqual = cislaX.SequenceEqual(cislaY);
Console.WriteLine(sequenceEqual);

/// Join
// Cross Join
List<Osoba> uzivatele2 = new List<Osoba> { karel, josef, jan, marie, simona, michaela };
string[] jmena = new string[] { "Jan", "Simona", "Michaela" };

var queryJoin = from jmeno in jmena
                join uzivatel in uzivatele on jmeno equals uzivatel.Jmeno into jmenoUzivatel
                from ju in jmenoUzivatel
                select ju;

var queryJoin2 = from j in jmena
                 from u in uzivatele
                 where (j == u.Jmeno)
                 select u;

foreach (var user in queryJoin)
{
    Console.WriteLine(user.Jmeno + " " + user.Vek);
}

class Osoba
{
    public int Vek;
    public string Jmeno;
    public string Prijmeni;

    public Osoba(string name, string surname, int age)
    {
        Vek = age;
        Jmeno = name;
        Prijmeni = surname;
    }
}
public class CaseSensitiveComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return string.Compare(x, y, StringComparison.Ordinal);
    }
}


