public class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { 
            if(string.IsNullOrEmpty(value))
                value = "Name Unknown";

            name = value;
        }
    }

    private int year;
    public int Year
    {
        get { return year; }
        set { 
            if(value >= 1 && value <= 4)
                value = 1;
            
            year = value; 
        }
    }
       
    public Student(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public string DoHomework()
    {
        return "Doing Homework";
    }

    public string DoHomework(int howMany)
    {
        return $"Doing {howMany} Homeworks";
    }

    public override string ToString()
    {
        string toString = $"Class: {base.ToString()}\n" +
        $"Name: {name}\n" +
        $"Year: {year}";

        return toString;
    }
}