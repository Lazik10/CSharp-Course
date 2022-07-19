using Delegates;

static int PowerTwo(int a)
{
    return a * a;
}

static int Double(int a)
{
    return a * 2;
}

Numbers numbers = new Numbers();
Console.WriteLine(numbers.ToString());
numbers.DoOperation(PowerTwo);
Console.WriteLine(numbers.ToString());
numbers.DoOperation(Double);
Console.WriteLine(numbers.ToString());

Numbers.Operation operation = PowerTwo;

numbers.DoOperation(delegate(int a) { return a * a; });
Console.WriteLine(numbers);
numbers.DoOperation(delegate(int a) { return a * 2; });
Console.WriteLine(numbers);

// Predicate
// - returns only bool
// - declaration delegate bool Predicate<T>(T t);
Predicate<bool> predicate = delegate(bool result) { return result = false; };

// Func
// - can store lambda functions in variable
Func<int, string> func = x => x.ToString();

// Action
// - doesn't return value
Action<string, int> action = (x, y) => { Console.WriteLine(x + y); };