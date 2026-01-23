// Create an array of strings with student names
// string[] students = new string[8];

// The Manual Very Long and Tiring Way... ewww
// students[0] = "Ahmed";
// students[1] = "Aidan";
// students[2] = "Shashank";
// students[3] = "Shamik";
// students[4] = "Nathan Meyer";
// students[5] = "Dalton D'Angelo";
// students[6] = "Nathaniel Facey";
// students[7] = "Abhik";

// Shorthand way to create an array with pre-defined values 
string[] students =
[
    "Ahmed",
    "Aidan",
    "Shashank",
    "Shamik",
    "Nathan Meyer",
    "Dalton D'Angelo",
    "Nathaniel Facey",
    "Abhik"
];

void PrintStudentNames(string[] names)
{
    // Print the Length
    Console.WriteLine($"The length of students is {names.Length}");

    for(int i = 0; i < names.Length; i++)
        Console.WriteLine($"{names[i]}");
}

PrintStudentNames(students);