while(true)
{
    Console.Write("Enter a number: ");

    string input = Console.ReadLine();

    // bool passed = int.TryParse(input, out int number)
    // if(passed)
    
    if(int.TryParse(input, out int number))
    {
        Console.WriteLine($"The number is {number}");
        
        break;
    }
    else
    {
        Console.WriteLine("Failed to convert input to an integer");
    }
}