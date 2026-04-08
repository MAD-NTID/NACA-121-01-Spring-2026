using System.Diagnostics;

// Use this array to do various time complexity
string[] students = new string[5];
students[0] = "Marissa";
students[1] = "Jenny";
students[2] = "Tony";
students[3] = "John"; 
students[4] = "Peter";

Stopwatch peterInOOneStopWatch = new Stopwatch();

peterInOOneStopWatch.Start();

string peter = students[4]; //  << this is O(1) because we know where Peter is

peterInOOneStopWatch.Stop();

Console.WriteLine("O(1): We know Peter's position");
Console.WriteLine($"{peterInOOneStopWatch.ElapsedMilliseconds}ms | {peterInOOneStopWatch.ElapsedTicks}ticks | {peterInOOneStopWatch.Elapsed}");   
Console.WriteLine();

Stopwatch findPeterStopWatch = new Stopwatch();

findPeterStopWatch.Start();

for(int i = 0; i < students.Length; i++)
    if(students[i] == "Peter")
        break;

findPeterStopWatch.Stop();

Console.WriteLine("O(n): Find Peter using a loop");
Console.WriteLine($"{findPeterStopWatch.ElapsedMilliseconds}ms | {findPeterStopWatch.ElapsedTicks}ticks | {findPeterStopWatch.Elapsed}");   
Console.WriteLine();

// Simulate Classrooms, and find Peter
string[,] classrooms = new string[2,5];
classrooms[0, 0] = "Marissa";
classrooms[0, 1] = "Jenny";
classrooms[0, 2] = "Tony";
classrooms[0, 3] = "John"; 
classrooms[0, 4] = "June"; 

classrooms[1, 0] = "Marissa";
classrooms[1, 1] = "Jenny";
classrooms[1, 2] = "Tony";
classrooms[1, 3] = "John"; 
classrooms[1, 4] = "Peter"; //  << Peter He's in the second classroom, in the last chair

Stopwatch peterInONSquareStopWatch = new Stopwatch();

peterInONSquareStopWatch.Start();

for(int classroom = 0; classroom < classrooms.GetLength(0); classroom++)
    for(int student = 0; student < classrooms.GetLength(1); student++)
        if(classrooms[classroom, student] == "Peter")
            break;

peterInONSquareStopWatch.Stop();
Console.WriteLine("O(n^2): We Look for Peter in Different Classrooms");
Console.WriteLine($"{peterInONSquareStopWatch.ElapsedMilliseconds}ms | {peterInONSquareStopWatch.ElapsedTicks}ticks | {peterInONSquareStopWatch.Elapsed}");   
Console.WriteLine();