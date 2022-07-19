try
{
    int a = 0;
    int b = 1 / a;
}
catch (Exception ex)
{
    Console.WriteLine("Error");
    Console.WriteLine();
    Console.WriteLine(ex.Message);
    Console.WriteLine();
    Console.WriteLine(ex);
}
Console.WriteLine();

Random rand = new Random();
Console.WriteLine("Exception");
try
{
    if (rand.Next(2) == 1)
    {
        int a = 0;
        int b = 1 / a;
    }
    else
        int.Parse("Hi, how are you?");
}
catch (DivideByZeroException e) // More strict exceptions have to be first!!!
{
    Console.WriteLine("Catched dividing by zero");
}
catch (Exception e) // More global exception
{
    Console.WriteLine("Some other exception occoured");
    Console.WriteLine();
    Console.WriteLine(e.Message);
    Console.WriteLine();
    Console.WriteLine(e);
}

/// <summary>
/// LOG exceptions
/// </summary>

static bool Log(Exception exception)
{
    Console.WriteLine($"Log: {exception.Message}");
    return false;
}

try
{
    // something...
}
catch (Exception ex) when (Log(ex)) // returns false, so catch block wont run
{

}

/// <summary>
/// OWN EXCEPTIONS
/// </summary>

class MyException : Exception
{
}

// To throw our exception just use
// throw new MyException();
