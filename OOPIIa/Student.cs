public class Student
{
    private string firstName;
    private string lastName;
    private double gpa;
    private string major;

    public Student() {}

    // this is the constructor of the class
    public Student(string firstName, string lastName, double gpa, string major)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gpa = gpa;
        this.major = major;
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public void setGpa(double gpa)
    {
        this.gpa = gpa;
    }

    public double getGpa()
    {
        return gpa;
    }

    public void setMajor(string major)
    {
        // Setter methods allow you to do validations
        // Something you can't do if using class variables alone
        if(string.IsNullOrEmpty(major))
            major = "Not Defined";

        this.major = major;
    }

    public string getMajor()
    {
        return major;
    }
}