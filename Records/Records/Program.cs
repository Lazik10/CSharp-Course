// Records

// they are reference types, that act like a value types
// simply class with setters set as init
// they have overriden few methods by default
// they can inherit from another record but not from a class!!! but instead of : base() we use : recordName()

User lazik = new("Lazik", "Lazik");
User lazik2 = new("Lazik", "Lazik");
User tomas = new("Tomas", "Tomas");

ClassUser classLazik = new("Lazik", "Lazik");
ClassUser classLazik2 = new("Lazik", "Lazik");
ClassUser classTomas = new("Tomas", "Tomas");

// Difference between record and class
Console.WriteLine("RECORD USER:");
Console.WriteLine("ToString(): {0}", lazik);
Console.WriteLine("Are these objects Equals()? {0}", Equals(lazik, lazik2));
Console.WriteLine("Are these objects equal? == {0}", lazik == lazik2);
Console.WriteLine("Hash code of record {0} is: {1}", lazik, lazik.GetHashCode());
Console.WriteLine("Hash code of record {0} is: {1}", lazik2, lazik2.GetHashCode());
Console.WriteLine("Hash code of record {0} is: {1}", tomas, tomas.GetHashCode());
Console.WriteLine("Is reference on both records equal?: {0}", ReferenceEquals(lazik, lazik2));

Console.WriteLine("CLASS USER");
Console.WriteLine("ToString(): {0}", classLazik);
Console.WriteLine("Are these objects Equals()? {0}", Equals(classLazik, classLazik2));
Console.WriteLine("Are these objects equal? == {0}", classLazik == classLazik2);
Console.WriteLine("Hash code of record {0} is: {1}", classLazik, classLazik.GetHashCode());
Console.WriteLine("Hash code of record {0} is: {1}", classLazik2, classLazik2.GetHashCode());
Console.WriteLine("Hash code of record {0} is: {1}", classTomas, classTomas.GetHashCode());
Console.WriteLine("Is reference on both records equal?: {0}", ReferenceEquals(classLazik, classLazik2));

// Automatic deconstruction of record into tuple
User user = new("Name", "Surname");
var (name1, surname1) = user;
Console.WriteLine("name: {0} surname: {1}", name1, surname1);

// In class we have to create Deconstruct method
ClassUser userClass = new("Test Name", "Test Surname");
var(name2, surname2) = userClass;
Console.WriteLine("name: {0} surname: {1}", name2 , surname2);

var obed = (HlavniChod: "Guláš", Priloha: "Knedlík");
ValueTuple obed = (HlavniChod: "Guláš", Priloha: "Knedlík");
/// <summary>
/// RECORDS
/// </summary>
/// <param name="Name"></param>
/// <param name="Surname"></param>

// Definition
// Records have automatically defined constructor, overriden methods ToString(), Equals(), operators == and != and others
public record User(string Name, string Surname);

// Equivalent to:
/*
    public class User
    {
        public string Jmeno { get; init; }
        public string Prijmeni { get; init; }

        public User(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
    }
*/

// Records can have methods and we can change it fields but not their values!!! in that case record would not be immutable
// we can only change getter
/*public record User(string Jmeno, string Prijmeni)
{
    internal string jmeno = Jmeno;

    public string Jmeno
    {
        get { return jmeno.Substring(0, 1); }
    }

    public string FullName { get => $"{Jmeno} {Prijmeni}"; }

    public string Ahoj()
    {
        return $"Ahoj {Jmeno}";
    }
}*/

class ClassUser
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public ClassUser(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public void Deconstruct(out string name, out string surname)
    {
        name = Name;
        surname = Surname;
    }
}


