// Let's create student objects for each of you
Student ahmed = new Student("Ahmed", "Sharif", 3.5, "ICS");

// ahmed.firstName = "Ahmed";
// ahmed.lastName = "Sharif";
// ahmed.gpa = 3.5;
// ahmed.major = "ICS";

Student[] classroom = new Student[6];

Student nathanielF = new Student("Nathaniel", "Facey", 3.5, "ICS");
Student nathanielM = new Student("Nathan", "Meyer", 3.5, "ICS");
Student shamik = new Student("Shamik", "Chakraborty", 3.5, "ICS");
Student shashank = new Student("Shashank", "Beligere", 3.5, "ICS");
Student abhik = new Student("Abhik", "Chakraborty", 3.5, "ICS");

// Add ahmed to the classroom
classroom[0] = ahmed;
classroom[1] = nathanielF;
classroom[2] = nathanielM;
classroom[3] = shamik;
classroom[4] = shashank;
classroom[5] = abhik;

for(int i = 0; i < classroom.Length; i++)
{
    try
    {
        Student student = classroom[i];

        Console.WriteLine($"Name: {student.firstName} {student.lastName}");
        Console.WriteLine($"GPA: {student.gpa}\nMajor: {student.major}");
        Console.WriteLine();
    } 
    catch(NullReferenceException nfe)
    {
        
    }
}