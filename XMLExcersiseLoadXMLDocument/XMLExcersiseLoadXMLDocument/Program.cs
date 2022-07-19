using System.Xml.Linq;
using System.Xml;
using System.Globalization;

/*XmlDocument doc = new XmlDocument();
doc.Load("computers.xml");*/

XDocument docX = XDocument.Load("computers.xml");

var sum = (from procesor in docX.Element("pocitace").Elements("pocitac").Elements("procesor")
           select double.Parse(procesor.Element("frekvence").Value.Split(" ")[0], CultureInfo.InvariantCulture)
                  * int.Parse(procesor.Element("jader").Value)).Sum();
Console.WriteLine("Celkový součet výkonů všech jader všech pořítaču je {0} Ghz", sum);

var average = (from ram in docX.Element("pocitace").Elements("pocitac").Elements("ram")
               select double.Parse(ram.Value.Split(" ")[0])).Average();
Console.WriteLine($"Průměrná velikost operační paměti je {average} GB");

var mostPowerfull = from computer in docX.Element("pocitace").Elements("pocitac")
                    select new
                    {
                        Name = computer.Attribute("nazev").Value,
                        Power = double.Parse(computer.Element("procesor").Element("jader").Value)
                        * double.Parse(computer.Element("procesor").Element("frekvence").Value
                        .Split(" ")[0], CultureInfo.InvariantCulture)
                    };

//var mostPower = mostPowerfull.Select(x => new { x.Name, x.Power } ).Max(x => x.Power);
string mostPowerPc = "";
double max = 0;
foreach (var computer in mostPowerfull)
{
    if (computer.Power > max)
    {
        mostPowerPc = computer.Name;
        max = computer.Power;
    }
}

Console.WriteLine($"Nejvykonejsi pocitac je {mostPowerPc}");