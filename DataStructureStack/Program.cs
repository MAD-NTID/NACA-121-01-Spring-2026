// // Create two Nodes, 1st with value int 10, and Next with value int 15
// Node<int> first = new(10);
// Node<int> second = new(15);

// // As of right now, they're independent
// Console.WriteLine(first);
// Console.WriteLine(second);

// // Attach second to the first's Next property
// first.Next = second;
// Console.WriteLine($"Attach second to the first's Next property\n{first}");

// // You can simply create it all at once
// Node<int> link = new(10, new(15));
// Console.WriteLine($"You can simply create it all at once\n{link}"); 

Stack<string> studentNames = new();
studentNames.Push(new("Michael"));
studentNames.Push(new("Ahmed"));
studentNames.Push(new("Aidan"));
studentNames.Push(new("Shashank"));
studentNames.Push(new("Shamik"));
studentNames.Push(new("Abhik"));

Console.WriteLine(studentNames);
Console.WriteLine("Remove the Top which should be Abhik. Shamik should become the new top");
Console.WriteLine($"Top Removed: {studentNames.Pop()}");
Console.WriteLine(studentNames);
Console.WriteLine();

Console.WriteLine($"Does Stack has \"Nathaniel\"? {studentNames.Contains("Nathaniel")}");
Console.WriteLine($"Does Stack has \"Michael\"? {studentNames.Contains("Michael")}");
Console.WriteLine();
Console.WriteLine($"Convert Stack to Array:");
string?[] toArray = studentNames.ToArray();
for(int i = 0; i < toArray.Length; i++)
    Console.WriteLine($"{toArray[i]}");

Console.WriteLine();
// For each is possible thanks to the IEnumerable implementation
Console.WriteLine("Iterating using IEnumerable (foreach): ");
foreach(string? studentName in studentNames)
    Console.WriteLine(studentName);
    
// // Remove all using iteration
// // Get the count first outside of the loop << impotant >>
// int count = studentNames.Count;
// for(int i = 0; i < count; i++)
// {
//     Console.WriteLine($"Top Removed: {studentNames.Pop()}");
//     Console.WriteLine(studentNames);
// }