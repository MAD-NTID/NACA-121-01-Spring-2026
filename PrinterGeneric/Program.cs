// // Creates a printer class with type string
Printer<string> printerString = new(7);
Console.WriteLine(printerString);
printerString.Add("Ahmed");
printerString.Add("Aidan");
printerString.Add("Shashank");
printerString.Add("Shamik");
printerString.Add("Nathan M");
printerString.Add("Nathan F");
printerString.Add("Abhik");

// // Creates a printer class with type int
// Printer<int> printerInt = new();
// Console.WriteLine(printerInt);

// Creates a printer class with type double
// Printer<double> printerDouble = new(4);
// Console.WriteLine(printerDouble);
// // Average Temperature
// printerDouble.Add(100);
// printerDouble.Add(90);
// printerDouble.Add(80);
// printerDouble.Add(70);

// // Creates a printer class with type Object
// Printer<object> printerObjects = new();
// Console.WriteLine(printerObjects);



for(int i = 0; i < printerString.Size; i++)
{
    Console.WriteLine($"Printing {i + 1}: {printerString.Print()}");
}

Console.WriteLine();
Console.WriteLine("Finished Printing");