public interface IAttendanceSystem
{
    public void LoadAttendance(string filePath);
    public void SaveAttendance(string filePath);
    public void AddStudent(string firstName, string lastName, List<DateTime> attendanceDates);
    public void AddStudent(string firstName, string lastName, DateTime attendanceDate);
    public List<IStudent> SortStudentsByLastName();
    public List<IStudent> SelectStudentsByDateRange(DateTime from, DateTime to);
    public Dictionary<string, IStudent> GetStudents();
}