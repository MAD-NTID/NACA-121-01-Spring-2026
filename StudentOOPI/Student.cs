public class Student
{
    public string firstName;
    public string lastName;
    public double gpa;
    public string major;

    // this is the constructor of the class
    public Student(string firstName, string lastName, double gpa, string major)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gpa = gpa;
        this.major = major;
    }
}