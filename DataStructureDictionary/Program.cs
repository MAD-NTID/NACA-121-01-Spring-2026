// Uncomment to test KVP
// IKVP<string, string> nathan = new KVP<string, string>("Nathan", "Nathan Meyer");
// Console.WriteLine(nathan);

// Test Creating a Dictionary
IDictionary<string, string> dictionary = new Dictionary<string, string>(7);

dictionary.Add("Nathan", "Nathan Meyer");
dictionary.Add("Abhik", "Abhik Chakraborty");
dictionary.Add("Ahmed", "Ahmed Sharif");
dictionary.Add("Shamik", "Shamik Chakraborty");
dictionary.Add("Aidan", "Aidan Chamberlin");
dictionary.Add("Shashank", "Shashank Beligere");
dictionary.Add("Michael", "Michael Berrios");

Console.WriteLine("All Names Added Should be Here - No Collision");
Console.WriteLine($"Dictionary Size: {dictionary.Count} / {dictionary.Capacity}");
Console.WriteLine(dictionary);

Console.WriteLine("Now we try to add Nathan F and there should be a collision (one KVP will be replaced)");
dictionary.Add("Nathan F", "Nathan Facey");
Console.WriteLine($"Dictionary Size: {dictionary.Count} / {dictionary.Capacity}");
Console.WriteLine(dictionary);