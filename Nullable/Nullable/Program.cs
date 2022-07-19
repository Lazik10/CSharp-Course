int? a = null;
Console.WriteLine(a.HasValue ? a.Value : 0);
a = 100;
Console.WriteLine(a);