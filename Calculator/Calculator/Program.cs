// Calculator
Console.WriteLine("Welcome in calculator");
Console.WriteLine();

bool compute = true;

while (compute)
{
    bool correctOperation = false;
    string operation = "";
    while (correctOperation == false)
    {
        // Operation
        Console.WriteLine("Please choose wchich operation would you like to compute (+,-,*,/): ");
        operation = Console.ReadKey().KeyChar.ToString().ToLower();

        if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
        {
            correctOperation = true;
            Console.WriteLine($"\nSelected operation is: {operation} \n");
        }
        else
            Console.WriteLine("Please insert correct operation sign");
    }

    // First number
    Console.WriteLine("Please enter your firrst number");
    double x, y;
    while (!double.TryParse(Console.ReadLine(), out x))
        Console.WriteLine("Your first number has incorrect format! Please insert new one: ");

    // Second number
    Console.WriteLine("Please insert your second number");
    while (!(double.TryParse(Console.ReadLine(), out y) && !(operation == "/" && y == 0)))
    {
        Console.WriteLine("Your second number has incorrect format or you are trying to divide by 0!\nPlease insert new second number: ");
    }

    double result = operation switch
    {
        "+" => x + y,
        "-" => x - y,
        "*" => x * y,
        "/" => x / y,
        _ => 0,
    };

    Console.WriteLine($"Result is: {result}");

    Console.WriteLine("Would you like to compute anything else? [y/n]");

    bool computeNextCorrectAnswer = false;
    while (!computeNextCorrectAnswer)
    {
        string? answer = Console.ReadKey().Key.ToString().ToLower();
        if (answer == "y" || answer == "n")
        {
            if (answer == "n")
            {
                compute = false;
                Console.WriteLine("Thank you for using this calculator, to end this app please press any key!");
            }

            computeNextCorrectAnswer = true;
        }
        else
            Console.WriteLine("Your choce is invalid!");

        Console.WriteLine();
    }
}
