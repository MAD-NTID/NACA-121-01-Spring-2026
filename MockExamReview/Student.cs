using System.Runtime.InteropServices;

public class Student : IStudent
{
    public string? FirstName { get; private set; }

    public string? LastName { get; private set; }

    public List<DateTime> AttendanceDates { get; private set; }

    public Student(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        AttendanceDates = []; // << initialize an empty list
    }

    public void AddAttendance(DateTime date)
    {
        AttendanceDates.Add(date);
    }

    public static string CreateKey(string firstName, string lastName)
    {
        return $"{firstName}-{lastName}";
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}