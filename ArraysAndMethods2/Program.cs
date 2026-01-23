Console.Write("Which math operation do you want? (1 add, 2 substract): ");
string operationChoice = Console.ReadLine();

if(operationChoice == "1")
{
    Console.Write("Enter the first number to add: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number to add: ");
    double num2 = double.Parse(Console.ReadLine());

    // Method Invocation to Add
    double results = Add(num1, num2);
    Console.WriteLine($"The sum of {num1} and {num2} is {results}");
}
else if(operationChoice == "2")
{
    Console.Write("Enter the first number to subtract: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number to subtract: ");
    double num2 = double.Parse(Console.ReadLine());

    // Method Invocation to Subtract
    double results = Subtract(num1, num2);
    Console.WriteLine($"The difference of {num1} and {num2} is {results}");
}
else
{
    Console.WriteLine("Not a valid operation");
}

double Add(double num1, double num2)
{
    return num1 + num2;
}

double Subtract(double num1, double num2)
{
    return num1 - num2;
}