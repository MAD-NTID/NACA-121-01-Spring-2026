// Answer should be [-2, 1, 2, 3, 100] - ascending
int[] randomNumbers = {3, 2, 1, -2, 100};

InsertionSort<int> insertionSortNumbers = new InsertionSort<int>(randomNumbers);
int[] sorted = insertionSortNumbers.Sort();

// Loop through the sorted results
Console.Write("[");
for(int i = 0; i < sorted.Length; i++)
    Console.Write($"{sorted[i]},");
Console.WriteLine("]");

// Let's try names - answer should be 
// ["Abhik", "Ahmed", "John", "Michael", "Nathan F", "Nathan M", "Tony"]
string[] names =
{
    "John",
    "Michael",
    "Abhik",
    "Ahmed",
    "Nathan F",
    "Nathan M",
    "Tony"
};

InsertionSort<string> insertionSortNames = new InsertionSort<string>(names);
string[] sortedNames = insertionSortNames.Sort();

// Loop through the sorted results
Console.Write("[");
for(int i = 0; i < sortedNames.Length; i++)
    Console.Write($"{sortedNames[i]},");
Console.WriteLine("]");