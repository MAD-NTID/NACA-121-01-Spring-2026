int number;

while(true)
{
    Console.Write("Enter a number: ");

    string input = Console.ReadLine();

    try
    {
        number = int.Parse(input);

        // if line 11 successfully parses, then break from the loop
        break;
    }
    catch (FormatException exception)
    {
        Console.WriteLine($"Could not convert {input} to integer");
        Console.WriteLine(exception.Message);
    }    
}

Console.WriteLine($"The number is {number}");