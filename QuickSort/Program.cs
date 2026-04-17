Console.WriteLine("Quick Sort Algorithm");

int[] numbers = new int[]
{
    42, 7, 19, 88, 3,
    56, 91, 24, 67, 10,
    5, 73, 38, 84, 29
};


foreach(int number in numbers)
{
    Console.Write(number+" ");
}

Console.WriteLine("\nSorting the elements");

Quicksort<int> quicksort = new Quicksort<int>();
quicksort.Sort(numbers,0,numbers.Length-1);

foreach(int number in numbers)
{
    Console.Write(number+" ");
}


string[] names = new string[]
{
    "Liam", "Ava", "Noah", "Emma", "Elijah",
    "Sophia", "Lucas", "Mia", "Mason", "Isabella",
    "Ethan", "Amelia", "James", "Harper", "Benjamin"
};

Console.WriteLine();
foreach(string name in names)
{
    Console.Write(name+" ");
}

Quicksort<string> quicksortString = new Quicksort<string>();
quicksortString.Sort(names, 0, names.Length-1);
Console.WriteLine("\nSorting the elements");

foreach(string name in names)
{
    Console.Write(name+" ");
}



