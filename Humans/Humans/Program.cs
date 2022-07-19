using Humans;

List<Human> humans = new List<Human>();
humans.Add(new Man("Karel", "Novák", new DateTime(1988, 2, 5)));
humans.Add(new Man("Josef", "Nový", new DateTime(1978, 3, 19)));
humans.Add(new Man("Jan", "Marek", new DateTime(1968, 4, 8)));
humans.Add(new Man("Karel", "Novák", new DateTime(1958, 6, 25)));
humans.Add(new Woman("Marie", "Nová", new DateTime(1988, 8, 15)));
humans.Add(new Woman("Věra", "Nováková", new DateTime(1978, 10, 2)));
humans.Add(new Woman("Simona", "Mladá", new DateTime(1968, 1, 8)));
humans.Add(new Woman("Michaela", "Marná", new DateTime(1958, 12, 6)));

humans.Sort();

foreach (var human in humans)
{
    Console.WriteLine(human);
}

Human child = humans[3] + humans[4];
Console.WriteLine("{0} a {1} spolu mají dítě {2}", humans[3], humans[4], child);