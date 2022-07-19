using Indexer;

Collection collection = new Collection();
Collection collection2 = new Collection();
Console.WriteLine(collection[4]);
//collection[4] = 15;
Console.WriteLine(collection[4]);

Flags.FlagsType flags = Flags.FlagsType.All;
Console.WriteLine(flags.HasFlag(Flags.FlagsType.Delete));


// False even if the objects are same, they point in different memory location
Console.WriteLine(collection == collection2);
// False
Console.WriteLine(collection.Equals(collection2));

EqualCustomer customer1 = new EqualCustomer("Lazik", "Lazik", new DateTime(1991, 10, 21));
EqualCustomer customer2 = new EqualCustomer("Lazik", "Lazik", new DateTime(1991, 10, 21));

Console.WriteLine(customer1 == customer2);
Console.WriteLine(customer1.Equals(customer2));