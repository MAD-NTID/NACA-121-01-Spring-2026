// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Use LINQ and lambda to count the total numbers that are multiple of 2.
// Display the result

// List<int> numbers = new List<int>
// {
//     1, 2, 3, 4, 5, 6, 7, 8, 9, 10
// };

using System.Collections.Concurrent;

List<int> numbers = new List<int>();
Random random = new Random();

Console.Write("Numbers: ");
for(int i = 0; i < 10; i++){
    numbers.Add(random.Next(0, 100));
    Console.Write(numbers[i] + ",");    
}
Console.WriteLine();

Console.WriteLine("How many even numbers? ");
int totalEvenNumbers = numbers.Count(num => num % 2 == 0);

Console.WriteLine(totalEvenNumbers);
Console.WriteLine();

// Delegate Demo
Func<int, int> square = x => x * x;

Console.WriteLine($"The square of 5: {square(5)}");

Console.WriteLine();

// Transformation Demo
var people = new[]
{
    new { Name = "Agent M", Age = 50},
    new { Name = "Agent L", Age = 30}, 
    new { Name = "Agent X", Age = 25}
};

foreach(var person in people)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

Console.WriteLine($"Age in 5 Years");

// Add 5 years to each person's age
var peopleInFiveYears = people.Select(person => new
{
    person.Name,
    AgeInFiveYears = person.Age + 5
});

foreach(var person in peopleInFiveYears)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.AgeInFiveYears}");
}
Console.WriteLine();

// Filter numbers list and find multiples of 3
var multiples3 = numbers.Where(num => num % 3 == 0);

Console.Write("Multiples of 3: ");
foreach(int number in multiples3)
    Console.Write($"{number},");

Console.WriteLine();

List<Person> peopleList = new()
{
    new Person("Abhik", 18, "ACT", "USA"),
    new Person("Nathaniel F", 19, "ACT", "Jamaica"),
    new Person("Nathaniel M", 25, "SWEN", "Puerto Rico"),
    new Person("Shamik", 37, "ACT", "USA"),
    new Person("Shashank", 21, "ACT", "India"),
    new Person("Ahmed", 44, "ACT", "USA"),
    new Person("Michael", 39, "SWEN", "Puerto Rico"),
    
    // For validation purposes
    new Person("Underage", -100, "CE", "Poland")
};

var nameStartWithS = peopleList.FindAll(
    person => person.Name.StartsWith('S')
);

Console.WriteLine($"Found {nameStartWithS.Count} people with name starting with letter 'S'");

foreach(Person person in nameStartWithS)
    Console.WriteLine(person);

Console.WriteLine();

Console.WriteLine("Greater than 30 years old, group by Country");
var filtered = peopleList
    .FindAll(person => person.Age > 30)    
    .GroupBy(person => person.Country);

foreach(var group in filtered)
{
    Console.WriteLine($"Country: {group.Key}");

    foreach(Person person in group)
        Console.WriteLine(person);  

    Console.WriteLine();
}