using Tuples;

User user = new User(0, "Lazik");
user.Name = "Lestr";
Console.WriteLine(user.Name);

// 
void DoChange(User user)
{
    user.Name = "Lazik";
}

DoChange(user);
Console.WriteLine(user.Name);


// ValueTuple with naming of elements
(int Id, string name) user1 = (27, "Lazik");
Console.WriteLine(user1.name);

(int Id, string name) Return()
{
    return (0, "Lazik");
}

Console.WriteLine(Return().name);

(int, string) user2 = (10, "Lestr");
user2.Item1 = 20;
Console.WriteLine(user2.Item1);

var user3 = (Id: 0, Name: "Lazik");
Console.WriteLine(user3.Name);

// To initialize tuple we can use variables as well
int id = 0;
string name = "Lazik";
var user4 = (Id: id, Name: name);
Console.WriteLine(user4.Name);

// Deconstruct - creates new local variables
(int Id, string Name) = Return();
Console.WriteLine(Id);
Console.WriteLine(Name);



var tuple8 = Tuple.Create(1, 2, "Šípková Růženka", 18, 1, 4, "Princ Bajaja", 52);
Console.WriteLine(tuple8.Rest);
var tuple10 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));
Console.WriteLine(tuple10.Rest.Item1.ToString());