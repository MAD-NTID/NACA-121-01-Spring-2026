Console.WriteLine("Welcome to the coffee Grind - Get in the line you!");
Queue<string> people = new  Queue<string>();

people.Enqueue("Ahmed");
people.Enqueue("Aidan");
people.Enqueue("Shashank");
people.Enqueue("Shamik");
people.Enqueue("Nathan M");
people.Enqueue("Nathan F");
people.Enqueue("Abhik");
foreach(string person in people)
{
    Console.WriteLine($"{person} added to the line");
}
Console.WriteLine(people);

Console.WriteLine("\nGet them out of the line");
// Get the count as of Right now (before starting to dequeue)
int count = people.Count;
for(int i = 0; i < count; i++)
    Console.WriteLine($"{people.Dequeue()} was removed from the line");

// This should be null now
Console.WriteLine(people);