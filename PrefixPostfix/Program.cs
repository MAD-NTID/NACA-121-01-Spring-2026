// Prefix
int y = 5;

Console.WriteLine($"Current y value: {++y}");
Console.WriteLine($"Current y value: {y}");

Console.WriteLine();

// Postfix
Console.WriteLine($"Current y value: {y++}");
Console.WriteLine($"Current y value: {y}");

// Single line after evaluation no need for { }
if(y >= 7) 
    Console.WriteLine("Y is 7");

// If multiple statements after evaluation, then need { }
if(y >= 7)
{
    Console.WriteLine("Y is 7");
    Console.WriteLine("Y is still 7");
}

Console.WriteLine("This is NOT part of the evluation");


