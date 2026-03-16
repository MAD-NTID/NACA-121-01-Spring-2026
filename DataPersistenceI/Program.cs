string filePath = "sales.csv";

try
{
    StreamWriter sw = new(filePath);

    // First row (0) should always define the columns
    sw.WriteLine("item number, description, unit price, quantity");

    // Subsequent rows are the items (the items in stock)
    sw.WriteLine("123, soda, .99, 25");
    sw.WriteLine("321, slice white bread, 1.29, 15");
    sw.WriteLine("999, strawberries, 2.99, 30");

    // Write to file
    sw.Close();    

    Console.WriteLine($"Finished writing {filePath}");
}
catch(IOException ioe)
{
    Console.WriteLine($"File is being used by another app\n{ioe.Message}");
}

Console.WriteLine();

// Force the file to not be found
// filePath = "someNewFile.txt";

// try
// {
//     // Stream Reader
//     StreamReader sr = new(filePath);

//     // Continue reading until it's not the end of the stream
//     // Meaning, continue reading as long as there is binary data
//     // left to read.
//     // EndOfStream is a property of StreamReader (boolean)
//     while(!sr.EndOfStream)
//     {
//         // The ReadLine automatically moves the cursor to the next
//         // Line after reading the current line
//         Console.WriteLine(sr.ReadLine());
//     }
//     Console.WriteLine($"Finished reading {filePath}");
// } catch(FileNotFoundException fnfe)
// {
//     Console.WriteLine($"Could not find that file {filePath}\n{fnfe.Message}");
// }

// Rewriting the above try/catch using File.Exists
if(File.Exists(filePath))
{
    // Stream Reader
    StreamReader sr = new(filePath);

    // Read the firstline and ignore - this skips the heading for csv
    // sr.ReadLine();
    // int lineCounter = 0;
    bool firstLine = true;

    double totalUnitPrice = 0;
    double totalInventoryCost = 0;

    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();

        if(firstLine)
        {
            firstLine = false;
            continue;   
        }

        Console.WriteLine(line);

        // Split the string by comma
        string[] rowData = line.Split(",");

        // Parse the value and then use as double
        double unitPrice = double.Parse(rowData[2]); 
        totalUnitPrice += unitPrice;

        int quantity = int.Parse(rowData[3]);
        double totalPriceForItem = unitPrice * quantity;
        totalInventoryCost += totalPriceForItem;

        Console.WriteLine($"The Unit Price for Item is {rowData[2]}");
        Console.WriteLine($"The total value of this item in stock is {totalPriceForItem:c}");
        Console.WriteLine();
    }
    Console.WriteLine($"Finished reading {filePath}");
    Console.WriteLine($"The total Unit Price of all Item is: {totalUnitPrice:c}");
    Console.WriteLine($"The total inventory cost is {totalInventoryCost:c}");
}
else
{
    Console.WriteLine($"Could not find that file {filePath}");
}

// string filePath = "myFirstFile.txt";

// // Creates a StreamWriter Object with a given File Path (the file)
// StreamWriter sw = new(filePath);

// sw.WriteLine("Hello World!");
// sw.WriteLine("My new file, Yayyy!");
// sw.Write("I am a new sentence. ");
// sw.Write("I am in the same line as the previous sentence.");
// sw.WriteLine();

// // Up to this point, data is not persisted - it's still in Memory
// // sw.Close moves the data from buffer into permanent storage in the provided filepath
// sw.Close();

// Console.WriteLine($"Finished writing to file {filePath}");