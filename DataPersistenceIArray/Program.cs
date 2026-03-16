// Write data from an array to streamwriter
string[] items = new string[5];
items[0] = "cherry";
items[1] = "blueberry";
items[2] = "strawberry";
items[3] = "orange";
items[4] = "apple";

StreamWriter sw = new("fruits.csv");

// Write the columns first
sw.WriteLine("fruit name");

// For each item in the array write to the file
for(int i = 0; i < items.Length; i++)
    sw.WriteLine(items[i]);

sw.Close();