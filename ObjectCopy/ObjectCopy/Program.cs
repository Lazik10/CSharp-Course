// Shallow copy
// - if we use shallow copy, we can create new copy of specific object, but
// if the original object had some instance reference in it they are copied as a reference as well
// this means that original and new object will point to the same instance reference
User lazik = new();
User tomas = lazik.ShallowCopy();
lazik.Number = new Number() { Value = 50 };
Console.WriteLine(lazik.Number.Value + " " + tomas.Number?.Value);

User clone = lazik.DeepClone();
User shallowClone = lazik.ShallowCopy();
Console.WriteLine();
//.Number = new Number() { Value = 100 };
Console.WriteLine(lazik.Number.Value + " " + clone.Number.Value + " " + shallowClone.Number.Value);
lazik.Number.Value = 200;
Console.WriteLine(lazik.Number.Value + " " + clone.Number.Value + " " + shallowClone.Number.Value);

class User : ICloneable
{
    public string Name { get; set; } = "Lazik";

    public Number Number { get; set; } = new Number() { Value = 20 };

    public object Clone()
    {
        User clone = new User();
        clone.Name = Name;
        clone.Number = new Number();
        clone.Number.Value = Number.Value;
        return this;
    }

    public User DeepClone()
    {
        User clone = new User();
        clone.Name = Name;
        clone.Number = new Number();
        clone.Number.Value = Number.Value;
        return clone;
    }

    public User ShallowCopy()
    {
        return (User)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return Name;
    }
}

class Number
{
    public int Value { get; set; } = 10;
}



// Deep copy

