public interface IStudent
{
    public string? FirstName { get; }
    public string? LastName { get; }
    public void AddAttendance(DateTime date);
    public List<DateTime> AttendanceDates { get; }
}