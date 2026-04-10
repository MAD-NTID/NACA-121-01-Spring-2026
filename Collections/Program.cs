Dictionary<string, string> students = new Dictionary<string, string>();

students.Add("Michael", "Michael Berrios");
students.Add("John", "John Smith");

foreach(var value in students)
{
    Console.WriteLine(value);
}

Stack<string> pringles = new Stack<string>();
pringles.Push("Chip 1");
pringles.Push("Chip 2");
pringles.Push("Chip 3");

int size = pringles.Count;

for(int i = 0; i < size; i++)
    Console.WriteLine($"Ate {pringles.Pop()}");

Queue<string> lineAtDC = new Queue<string>();
lineAtDC.Enqueue("Tony");
lineAtDC.Enqueue("Alysia");
lineAtDC.Enqueue("Mark");

int lineSize = lineAtDC.Count;

for(int i = 0; i < lineSize; i++)
    Console.WriteLine($"{lineAtDC.Dequeue()} Ordered");

List<int> favoriteNumbers = new List<int>();
favoriteNumbers.Add(5);
favoriteNumbers.Add(1);
favoriteNumbers.Add(3);

foreach(int number in favoriteNumbers)
    Console.WriteLine($"Favorite Number {number}");