using BinaryFiles;

int x = 2345678;
string name = "Lazik";

using (BinaryWriter bw = new BinaryWriter(new FileStream("file.dat", FileMode.Create)))
{
    bw.Write(x);
    bw.Write(name);
    bw.Flush();
}

using (BinaryReader br = new BinaryReader(new FileStream("file.dat", FileMode.Open)))
{
    int y = br.ReadInt32();
    Console.WriteLine(y);
}

List<User> users = new List<User>();
users.Add(new User("Jan Novák", 22, new DateTime(1980, 1, 1)));
users.Add(new User("Tomáš Marný", 22, new DateTime(1984, 2, 5)));
users.Add(new User("Jan Nový", 22, new DateTime(1988, 3, 8)));

using (BinaryWriter bw = new BinaryWriter(new FileStream("users.dat", FileMode.Create)))
{
    foreach (var user in users)
    {
        bw.Write(user.Name);
        bw.Write(user.Age);
        bw.Write(user.Birthday.Ticks);
    }
    bw.Flush();
}

using (BinaryReader br = new BinaryReader(new FileStream("users.dat", FileMode.Open)))
{
    while(br.BaseStream.Position < br.BaseStream.Length)
    {
        string userName = br.ReadString();
        int age = br.ReadInt32();
        DateTime birthday = new DateTime(br.ReadInt64());
        User user = new User(userName, age, birthday);
        Console.WriteLine(user);
    }
}
