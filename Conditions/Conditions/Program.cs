// Conditions IF/ELSE, SWITCH

// IF/ELSE
if (15 > 5)
    Console.WriteLine("true");

Console.WriteLine("Zadej nějaké číslo, ze kterého spočítám odmocninu:");
int a = int.Parse(Console.ReadLine());
if (a > 0)
{
    Console.WriteLine("Zadal jsi číslo větší než 0, to znamená, že ho mohu odmocnit!");
    double o = Math.Sqrt(a);
    Console.WriteLine("Odmocnina z čísla " + a + " je " + o);
}
else
    Console.WriteLine("Odmocnina zaporneho cisla neexistuje!");

Console.WriteLine("Děkuji za zadání");

Console.WriteLine("Zadejte číslo v rozmezí 10-20:");
int b = int.Parse(Console.ReadLine());
if ((b >= 10) && (b <= 20))
    Console.WriteLine("Zadal jsi správně");
else
    Console.WriteLine("Zadal jsi špatně");

// SWITCH
Console.WriteLine("Vitejte v kalkulacce");
Console.WriteLine("Zadejte prvni cislo: ");
int prvniCislo = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte operaci (+ - / *): ");
string? operace = Console.ReadLine();
Console.WriteLine("Zadejte druhe cislo: ");
int druheCislo = int.Parse(Console.ReadLine());
double vysledek;

switch (operace)
{
    case "+":
        vysledek = prvniCislo + druheCislo;
        break;
    case "-":
        vysledek = prvniCislo - druheCislo;
        break;
    case "/":
        vysledek = prvniCislo / druheCislo;
        break;
    case "*":
        vysledek = prvniCislo * druheCislo;
        break;
    default:
        vysledek = 0;
        break;
}
Console.WriteLine($"Vysledek je: {vysledek}");

// SWITCH EXPRESSION
int teplota = 12;
string teplotaSlovy = teplota switch
{
    < -5 => "Mrzne",
    >= -5 and 5 => "Zima",
    0 or 100 => "Mrzne nebo vre",
    > 5 and < 15 => "Chladno",
    >= 15 and <= 25 => "Teplo",
    > 25 => "Horko",
    _ => "Neznama teplota"
};
Console.WriteLine(teplotaSlovy);
