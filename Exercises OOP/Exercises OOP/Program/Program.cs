using Exercises_OOP;
using Exercises_OOP.Arena_Game;
using Exercises_OOP.Classes;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

/*// Kalkulacka
Console.Write("Zadej 1. číslo: ");
int.TryParse(Console.ReadLine(), out int firstNumber);
Console.Write("Zadej 2. číslo: ");
int.TryParse(Console.ReadLine(), out int secondNumber);

Calculator calculator = new ();
Console.WriteLine("Součet: " + calculator.Add(firstNumber, secondNumber));
Console.WriteLine("Rozdíl: " + calculator.Substract(firstNumber, secondNumber));
Console.WriteLine("Součin: " + calculator.Multiply(firstNumber, secondNumber));
Console.WriteLine("Podíl: " + calculator.Divide(firstNumber, secondNumber));
//Console.WriteLine("Modulo: " + calculator.Modulo(firstNumber, secondNumber));

// Nakladak
Truck truck = new Truck();
truck.LoadCargo(10000);
truck.LoadCargo(500);
truck.UnloadCargo(300);
truck.UnloadCargo(1000);
Console.WriteLine("V nákladním autě je naloženo " + truck.GetCargoWight() + "kg");

// Friends
Human karel = new Human();
karel.SetName("Karel Novák");
karel.SetAge(33);

Human josef = new Human();
josef.SetName("Josef Nový");
josef.SetAge(27);

karel.SetFriend(josef);
josef.SetFriend(karel);
Console.WriteLine("Ahoj, já jsem {0}, je mi {1} let a můj kamarád je {2}", karel.GetName(), karel.GetAge(), karel.GetFriend().GetName());
Console.WriteLine("Ahoj, já jsem {0}, je mi {1} let a můj kamarád je {2}", josef.GetName(), josef.GetAge(), josef.GetFriend().GetName());

// Dice
Dice dice = new Dice(10);
Dice diceSixSide = new Dice(6);
Console.WriteLine("Dice has " + dice.GetNumberOfSides() + " sides");
Console.WriteLine(dice.ToString());

dice.ThrowManyTimes(10);
Console.WriteLine();
diceSixSide.ThrowManyTimes(10);
Console.WriteLine();

// Human running
Human lazik = new Human("Lazik");
lazik.Run(10);
lazik.Run(10);
lazik.Run(10);

// Random sentence generator
SentenceGenerator sentenceGenerator = new SentenceGenerator();
sentenceGenerator.GenerateSentence(10);

// Car and a garage
Garage garage = new Garage();
Car car = new Car("123ABC", "Black");
car.Park(garage);
Console.WriteLine(garage);

// Strings
string S1, S2;
S1 = "ABCD";
S2 = "EFGH";
Console.Write­Line("S1 = {0}, S2 = {1}", S1, S2);
S2 = S1;
Console.Write­Line("S1 = {0}, S2 = {1}", S1, S2);
S1 = "dcba";
Console.Write­Line("S1 = {0}, S2 = {1}", S1, S2);

// Dogs
Human marek = new Human("Marek");
Human lenka = new Human("Lenka");
Dog dog = new Dog(1, "Alik");
lenka.AdoptDog(dog);
marek.AdoptDog(dog);
Console.WriteLine(string.Format("{0} ({1} let)", dog.GetName(), dog.GetAge()));
marek?.Dog?.AddYear();
lenka?.Dog?.AddYear();
Console.WriteLine(string.Format("{0} ({1} let)", dog.GetName(), dog.GetAge()));

// From home to castle
Location home = new Location("Dům", "Stojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva," +
                             " která se line z hromady vedle vstupních dveří.");
Location forrestWest = new Location("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                            " kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
Location forrestCrossroad = new Location("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
Location forrestEast = new Location("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                            " kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
Location forrestSouth = new Location("Les", "Jsi na lesní cestě, která se klikatí až za obzor, " +
                            " kde mizí v siluetě zapadajícího slunce.Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
Location lake = new Location("Rybnik", "Došel jsi ke břehu malého rybníka.Hladina je v bezvětří jako zrcadlo.Kousek od tebe je dřevěná plošina se stavidlem.");
Location castle = new Location("Hrad", "Stojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná.");
Location currentLocation = home;
string[] correctAnswers = { "jdi na sever", "jdi na jih", "jdi na vychod", "jdi na západ" };

home.SetNeighbourField("západ", forrestSouth);
forrestSouth.SetNeighbourField("sever", forrestCrossroad);
forrestSouth.SetNeighbourField("vychod", home);
forrestCrossroad.SetNeighbourField("jih", forrestSouth);
forrestCrossroad.SetNeighbourField("západ", forrestWest);
forrestCrossroad.SetNeighbourField("vychod", forrestEast);
forrestWest.SetNeighbourField("západ", castle);
forrestWest.SetNeighbourField("vychod", forrestCrossroad);
castle.SetNeighbourField("vychod", forrestWest);
forrestEast.SetNeighbourField("západ", forrestCrossroad);
forrestEast.SetNeighbourField("vychod", lake);
lake.SetNeighbourField("západ", forrestEast);

string move = "";
string answer;
bool correctAnswer = false;

do
{
    do
    {
        Console.WriteLine(currentLocation);
        Console.WriteLine(currentLocation.GetPossibleMoves());

        Console.Write("Zadej příkaz: ");
        answer = Console.ReadLine().Normalize();
        if (answer == "konec")
        {
            move = answer;
            break;
        }

        if (correctAnswers.Contains(answer))
        {
            string[] direction = answer.Split(' ');
            string moves = currentLocation.GetPossibleMoves();
            if (moves.Contains(direction.Last()))
            {
                currentLocation = currentLocation.GetCorrectLocation(direction.Last());
                correctAnswer = true;
            }
            else
                Console.WriteLine("Tímto směrem nelze jít.");
        }
        else
        {
            Console.WriteLine("Můj vstupní slovník neobsahuje tento příkaz.");
            //Console.WriteLine(currentLocation);
            //Console.WriteLine(currentLocation.GetPossibleMoves());
        }

    } while (!correctAnswer);

} while (move != "konec");

// Simpsons
Human BartSimpson = new Human("Bart Simpson");
Human HomerSimpson = new Human("Homer Simpson");
Human MargeBouvier = new Human("Marge Bouvier");
Human HerbPowers = new Human("Herb Powers");
Human AbrahamSimpson = new Human("Abraham Simpson");
Human PenelopeOlsen = new Human("Penelope Olsen");
Human PanBouvier = new Human("Pan Bouvier");
Human JackieBouvier = new Human("Jackie Bouvier");
Human SelmaBouvier = new Human("Selma Bouvier");

BartSimpson.SetParents(HomerSimpson, MargeBouvier);
HomerSimpson.SetParents(AbrahamSimpson, PenelopeOlsen);
HerbPowers.SetParents(AbrahamSimpson, PenelopeOlsen);
MargeBouvier.SetParents(PanBouvier, JackieBouvier);
SelmaBouvier.SetParents(PanBouvier, JackieBouvier);

FamilyTree familyTree = new FamilyTree(BartSimpson);
Console.WriteLine();
familyTree = new FamilyTree(HomerSimpson);*/

// Arena
/*Dice newDice = new Dice(6);
Warrior mage = new Mage("Lazik", newDice);
Warrior warrior = new Warrior("Ondra", newDice);
Arena arena = new Arena(mage, warrior, newDice);
arena.StartBattle();*/
/*
// Angry Bird
Bird bird = new Bird();
Console.WriteLine(bird);
bird.Eat(20);
Console.WriteLine(bird);
AngryBird angryBird= new AngryBird();
Console.WriteLine(angryBird);
angryBird.Provoke(5);
Console.WriteLine(angryBird);
angryBird.Eat(100);
angryBird.Provoke(5);
Console.WriteLine(angryBird);

// Javista
Javista javista = new Javista("Karel Nový", 25);
Console.WriteLine(javista);
javista.Run(10);
javista.Run(10);
javista.DoProgram(5);
javista.Run(10);
javista.Sleep(8);
javista.DoProgram(100);

// Tree Area
Shape rectangle = new Rectangle(3, 26, "brown");
Shape triangle = new Triangle(25, 15, 15, "green");
Console.WriteLine("Area of tree is: {0}", (rectangle.Area() + 4 * triangle.Area()));

// User
User lazik = new User("Lazik", "Lazik");
lazik.LogIn("Lazik");
Console.WriteLine(User.isValidPassword(lazik.GetPassword()));
Console.WriteLine(lazik.isLoggedIn());
Console.WriteLine(User.GetMinPasswordLength());

Calendar calendar = new Calendar();
Console.WriteLine(calendar.GetSettings());

// Converter
double radians = 6.28;
double degrees = 90;
Console.WriteLine("{0} radians is equal to {1} degrees", radians, Converter.ToDegrees(radians));
Console.WriteLine("{0} degrees is equal to {1} radians", degrees, Converter.ToRadians(degrees));

// Factory
int bananaCookies = 5;
int strawberryCookies = 8;
int chocolateCookies = 12;

for (int i = 0; i < bananaCookies; i++)
{
    Cookies cookie = Factory.CreateBananaFlavor();
    Console.WriteLine(cookie);
}

for (int i = 0; i < strawberryCookies; i++)
{
    Cookies cookie = Factory.CreateStrawberryCookie();
    Console.WriteLine(cookie);
}

for (int i = 0; i < chocolateCookies; i++)
{
    Cookies cookie = Factory.CreateChocolateCookie();
    Console.WriteLine(cookie);
}

// Dices
Dice dice1 = new Dice();
Dice dice2 = new Dice();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Dice 1 throw: " + dice1.Throw());
    Console.WriteLine("Dice 2 throw: " + dice2.Throw());
}

// Student
Student student = new Student("Lazik", true, 15);
Console.WriteLine(student);

// Next 7 days
Console.WriteLine("Day + Motnh + Year");
//DateTime date = DateTime.Parse(Console.ReadLine());
DateTime date = new DateTime(2016, 11, 27);
for (int i = 0; i < 7; i++)
{
    Console.WriteLine(String.Format("{0} - {1}", date.ToShortDateString(), date.Day + date.Month + date.Year));
    date = date.AddDays(1);
}

// Friday 13th
Console.WriteLine("Please enter start date: ");
DateTime startDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Please enter end date: ");
DateTime endDate = DateTime.Parse(Console.ReadLine());

Console.Write(string.Format("Friday's the 13th are: "));
while (startDate < endDate)
{
    if (startDate.Day == 13 && startDate.DayOfWeek == DayOfWeek.Friday)
    {
        Console.Write(startDate.ToShortDateString() + ", ");
        startDate = startDate.AddDays(7);
    }
    startDate = startDate.AddDays(1);
}

// Birthday
Console.WriteLine("Please insert your date of birth: ");
DateTime birthday = DateTime.Parse(Console.ReadLine());
DateTime today = DateTime.Now;
DateTime thisYearBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
TimeSpan days = thisYearBirthday.DayOfYear < today.DayOfYear ? today - thisYearBirthday : today.AddYears(1) - thisYearBirthday;
int years = today.Year - birthday.Year + (birthday.DayOfYear > today.DayOfYear ? -1 : 0);
Console.WriteLine("You are {0} years old and your next birthday is in {1} days.", years, days.Days);

// Moon words
bool end = false;
List<string?> words = new List<string?>();
while (!end)
{
    Console.Write("Write word: ");
    string? word = Console.ReadLine();
    if (word != "end")
        words.Add(word);
    else
        end = true;
}

words = words.Distinct().ToList();
List<string?> lowerList = new List<string?>();

// Instead of looping and changing ToLower() I should have save it as lower word right away!
foreach (var item in words)
{
    lowerList.Add(item?.ToLower());
}

Console.Write("You have entered this words: ");
Console.WriteLine(string.Join(", ", lowerList));

// Marketplace for cars
Marketplace marketplace = new Marketplace("Jesenice", 5000000);
marketplace.BuyCar(new Car("123ABC", "Skoda", 10000));
marketplace.BuyCar(new Car("456DEF", "Skoda Fabia", 100000));
marketplace.BuyCar(new Car("789GHI", "Ferrari FF", 3000000));
marketplace.BuyCar(new Truck("534NGS", "Tatra 811", 50000, 20000));
marketplace.BuyCar(new Truck("489GSR", "Renault Midliner", 100000, 30000));

Console.WriteLine("There is {0} cars in this marketplace in {1}", marketplace.Cars.Count, marketplace.Address);
Console.WriteLine("This marketplace has {0} dolars in bank", marketplace.Money);
Console.WriteLine("Total value of all cars is: {0}", marketplace.CarsValue());*/

/*// Toolbox
Box box = new Box(10000);

Hammer kladivko = new Hammer("Kladívko", 1200, false);
Hammer velkeKladivo = new Hammer("Velké kladivo", 3000, true);
Hammer bouraciKladivo = new Hammer("Bourací kladivo", 4000, true);
Screwdriver sroubovak = new Screwdriver("Šroubovák Philips", 800);
Chainsaw zrezivelaPila = new Chainsaw("Zrezivělá pila", 2500);
ElectricScrewdriver elektrickySroubovak = new ElectricScrewdriver("Elektrický šroubovák Bosh", 1800, 100);

box.Content();

box.AddTool(kladivko);
box.AddTool(velkeKladivo);
box.AddTool(bouraciKladivo);
box.AddTool(sroubovak);
box.AddTool(zrezivelaPila);
box.AddTool(elektrickySroubovak);

box.Content();
box.ToolsWork();
Console.WriteLine("Váha obouručních kladiv je {0}", box.AllBothHandedHammersWeight());

// Tinder Users
List<TinderUser> tinderUsers = new List<TinderUser>();
tinderUsers.Add(new TinderUser("Karel", "Novak", new DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond));
tinderUsers.Add(new TinderUser("Josef", "Novy", new DateTime(1978, 3, 19), EyeColor.Brown, HairColor.Brown));
tinderUsers.Add(new TinderUser("Jan", "Marek", new DateTime(1968, 4, 28), EyeColor.Black | EyeColor.Brown, HairColor.Undefined));
tinderUsers.Add(new TinderUser("Karel", "Novak", new DateTime(1958, 6, 25), EyeColor.Green, HairColor.Blond));
tinderUsers.Add(new TinderUser("Marie", "Nova", new DateTime(1988, 8, 15), EyeColor.Blue, HairColor.Black));
tinderUsers.Add(new TinderUser("Vera", "Novakova", new DateTime(1978, 10, 2), EyeColor.GreenBlue, HairColor.Blond));
tinderUsers.Add(new TinderUser("Simona", "Mlada", new DateTime(1968, 1, 8), EyeColor.Undefined, HairColor.Brown));
tinderUsers.Add(new TinderUser("Michaela", "Marna", new DateTime(1958, 12, 6), EyeColor.Blue, HairColor.Redhead));

tinderUsers = tinderUsers.Distinct().ToList();

foreach (TinderUser user in tinderUsers)
{
    Console.WriteLine("{0} {1}, {2}, oči: {3}, vlasy: {4}", user.Name, user.Surname, user.DateOfBirth.ToString("d"), user.EyeColor, user.HairColor);
}

// .NET List
CustomList customList = new CustomList();
customList.Add("První");
for (int i = 2; i < 100000; i++)
{
    customList.Add(i);
}
customList[3] = "Čtvrtý";

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(customList[i]);
}

// Custom string
CustomString customString = new CustomString("Delegát v C# .NET funguje jako odkaz na metodu.");
customString.Map(x => x.Length > 5 ? x.ToUpper() : x);
Console.WriteLine(duplicateString);
Console.WriteLine("Agregaty: ");
Console.WriteLine(customString.Aggreggate((a, b) => a + " " + b));
Console.WriteLine(customString.Aggreggate((a, b) => "(" + a + b + ")"));
Console.WriteLine(customString.Aggreggate((a, b) => b.Length > 4 ? a + " " + b.Substring(0, 3) + "." : a + " " + b));*/

// Events
Human newHuman = new Human("Lazik");
Alarm newAlarm = new Alarm(10);
newAlarm.Ring += newHuman.WakeUp;
newAlarm.StartRinging();

// Semaphor
Semaphor newSemaphor = new Semaphor();
Console.WriteLine(newSemaphor);
Car newCar = new Car();
newSemaphor.ColorChange += newCar.HandleSemaphor;
newCar.Drive();
newSemaphor.ChangeColor(Semaphor.Colors.Oranzova);
newSemaphor.ChangeColor(Semaphor.Colors.Cervena);

// Digi grandma alarm
Human human = new Human();
Grandma grandma = new Grandma();
Alarm alarm = new Alarm(10);
DigiAlarm digiAlarm = new DigiAlarm(100);

alarm.Ringing += human.WakeUpWithParams;
alarm.Ringing += grandma.WakeUpWithParams;
digiAlarm.Ringing += human.WakeUpWithParams;
digiAlarm.Ringing += grandma.WakeUpWithParams;

alarm.StartRinging();
digiAlarm.StartRinging();