public class Person
{
    public string? Name { get; private set; }
    public int Age { get; private set; }
    public string? Major { get; private set; }
    public string? Country { get; private set; }

    public Person(string? name, int age, string? major, string? country)
    {
        Name = name;
        Age = age >= 0 ? age : 0;
        Major = major;
        Country = country;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}