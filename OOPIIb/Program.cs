// Let's create student objects for each of you
using System.Diagnostics;

Student ahmed = new Student("Ahmed", "Sharif", 3.5, "ICS");

// ahmed.firstName = "Ahmed";
// ahmed.lastName = "Sharif";
// ahmed.gpa = 3.5;
// ahmed.major = "ICS";

Student[] classroom = new Student[7];

Student nathanielF = new Student("Nathaniel", "Facey", 3.5, "ICS");
Student nathanielM = new Student("Nathan", "Meyer", 3.5, "");
Student shamik = new Student("", "Chakraborty", 3.5, "ICS");
Student shashank = new Student("Shashank", "", 3.5, "ICS");
Student abhik = new Student("Abhik", "Chakraborty", -10, "ICS");
Student michael = new Student();
michael.FirstName = "Michael";
michael.LastName = "Berrios";
michael.Gpa = 10;
michael.Major = "Software Engineering";

// Add ahmed to the classroom
classroom[0] = ahmed;
classroom[1] = nathanielF;
classroom[2] = nathanielM;
classroom[3] = shamik;
classroom[4] = shashank;
classroom[5] = abhik;
classroom[6] = michael;

for(int i = 0; i < classroom.Length; i++)
{
    try
    {
        Student student = classroom[i];

        Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
        Console.WriteLine($"GPA: {student.Gpa}\nMajor: {student.Major}");
        Console.WriteLine();
    } 
    catch(NullReferenceException nfe)
    {
        Console.WriteLine(nfe.Message);
    }
}

for(int i = 0; i < classroom.Length; i++)
{
    Console.WriteLine($"Old GPA for '{classroom[i].FirstName}' - {classroom[i].Gpa}");
    Console.Write($"Enter the GPA to update '{classroom[i].FirstName}' gpa: ");
    double gpa = double.Parse(Console.ReadLine());

    classroom[i].Gpa = gpa;

    Console.WriteLine($"'{classroom[i].FirstName}' GPA is: {classroom[i].Gpa}");
    // This clears the prompt if you want a fresh console.
    Console.Clear();
}

