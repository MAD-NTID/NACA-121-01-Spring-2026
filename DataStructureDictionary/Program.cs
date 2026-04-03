// Uncomment to test KVP
// IKVP<string, string> nathan = new KVP<string, string>("Nathan", "Nathan Meyer");
// Console.WriteLine(nathan);

// Test Creating a Dictionary
IDictionary<string, string> dictionary = new Dictionary<string, string>(20);
Console.WriteLine(dictionary.Capacity);

dictionary.Add("Nathan", "Nathan Meyer");
dictionary.Add("Abhik", "Abhik Chakraborty");
dictionary.Add("Ahmed", "Ahmed Sharif");
dictionary.Add("Shamik", "Shamik Chakraborty");
dictionary.Add("Aidan", "Aidan Chamberlin");
dictionary.Add("Shashank", "Shashank Beligere");
dictionary.Add("Michael", "Michael Berrios");

Console.WriteLine(dictionary.Get("Nathan"));
Console.WriteLine(dictionary.Get("Abhik"));
Console.WriteLine(dictionary.Get("Ahmed"));
Console.WriteLine(dictionary.Get("Shamik"));
Console.WriteLine(dictionary.Get("Aidan"));
Console.WriteLine(dictionary.Get("Shashank"));
Console.WriteLine(dictionary.Get("Michael"));