// Console.WriteLine("Prove Array Copying Works");

// string[] original = {"Michael", "John", "Tesla"};
// Console.Write("Original [");
// for(int i = 0; i < original.Length; i++)
//     Console.Write(original[i] + " " );

// Console.Write("]");

// Console.WriteLine();

// MergeSort<string> mergeSort = new();

// string[] copy = mergeSort.Copy(original, 0, original.Length);

// Console.Write("Copy [");
// for(int i = 0; i < copy.Length; i++)
//     Console.Write(copy[i] + " " );

// Console.Write("]");

// Console.WriteLine($"{(int)5/2}");
// Comparer<string> comparer = Comparer<string>.Default;

// Console.WriteLine($"Compare {comparer.Compare("john", "john")}");

string[] animals =
{
    "Zebra",
    "Giraffe",
    "Hippo",
    "Horse",
    "Axolotl",
    "Donkey",
    "Dog", 
    "Cat",
    "Turtle",
    "Owl",
    "Koala",
    "Hawk",
    "Monkey"
};

MergeSort<string> mergeSort = new();
string[] sortedAnimals = mergeSort.Sort(animals);

Console.Write("Original [");
for(int i = 0; i < animals.Length; i++)
    Console.Write(animals[i] + " " );

Console.Write("]");

Console.WriteLine();

Console.Write("Sorted [");
for(int i = 0; i < sortedAnimals.Length; i++)
    Console.Write(sortedAnimals[i] + " " );

Console.Write("]");

Console.WriteLine();