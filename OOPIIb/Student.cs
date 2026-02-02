public class Student
{
    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        set { 
            if(string.IsNullOrEmpty(value))
                value = "Not Defined";

            firstName = value; 
        }
    }
    
    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set { 
            if(string.IsNullOrEmpty(value))
                value = "Not Defined";

            lastName = value; 
        }
    }

    private double gpa;
    public double Gpa
    {
        get { return gpa; }
        set { 
            if(!(value >= 0 && value <= 4))
                value = 0;

            gpa = value; 
        }
    }
        
    private string major;
    public string Major
    {
        get { return major; }
        set { 
            if(string.IsNullOrEmpty(value))
                value = "Not Defined";

            major = value; 
        }
    }
    

    public Student() {}

    // this is the constructor of the class
    public Student(string firstName, string lastName, double gpa, string major)
    {
        FirstName = firstName;
        LastName = lastName;
        Gpa = gpa;
        Major = major;
    }
}