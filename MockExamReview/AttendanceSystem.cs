using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

public class AttendanceSystem : IAttendanceSystem
{
    private Dictionary<string, IStudent> students;

    public AttendanceSystem()
    {
        students = []; // << Initialize the dictionary
    }

    public void AddStudent(string firstName, string lastName, List<DateTime> attendanceDates)
    {
        // We have a list of DateTime attendanceDates for the students, so simply add the two by calling AddStudent for each attendance date
        foreach(DateTime dateTime in attendanceDates)
            AddStudent(firstName, lastName, dateTime);
        
    }

    public void AddStudent(string firstName, string lastName, DateTime attendanceDate)
    {
        // Add a student and create a List<DateTime> for that students
        // Let FirstName+LastName be the Key
        string key = Student.CreateKey(firstName, lastName);

        // Check if the student does not exist
        if(!students.ContainsKey(key))
            // Add the student object to the dictionary keyed by firstName + lastName
            students[key] = new Student(firstName, lastName);

        // Add the attendance date for that student
        students[key].AddAttendance(attendanceDate);
    }

    public Dictionary<string, IStudent> GetStudents()
    {
        return students;
    }

    public void LoadAttendance(string filePath)
    {
        // Check for file existence
        if(File.Exists(filePath))
            students = []; 

        // using(StreamReader sr = new(filePath))
        // {
            
        // } // << after this, it's automatically closed :)

        using(TextFieldParser parser = new TextFieldParser(filePath))
        {
            // Tells the parser that we are seeking values delimited with a character
            parser.TextFieldType = FieldType.Delimited;

            // Provide the delimited character
            parser.SetDelimiters(",");

            // Skip the first row/line (header)
            bool header = true;

            // Run the parser while is not the end of the file
            while(!parser.EndOfData)
            {
                // Skips the header
                if(header)
                {
                    header = false;
                    parser.ReadFields(); // << similar to "ReadLine()"
                    continue;
                }

                // Automatically splits columns for you, no need to split manually with ","
                string[] fields = parser.ReadFields();

                string firstName = fields[0];
                string lastName = fields[1];

                // From index 2 and ahead are attendance dates
                // Create a temp student object
                Student student = new(firstName, lastName);

                // Add the attendance dates
                for(int i = 2; i < fields.Length; i++)
                {
                    student.AddAttendance(DateTime.Parse(fields[i]));
                }

                // Finally, add the student to the dictionary to complete the "load" process
                string key = Student.CreateKey(firstName, lastName);
                students[key] = student;
            }
        }
    }

    public void SaveAttendance(string filePath)
    {
        // Check for file existence
        string json = JsonConvert.SerializeObject(
            students.Values, Formatting.Indented
        );

        File.WriteAllText(filePath, json);
    }

    public List<IStudent> SelectStudentsByDateRange(DateTime from, DateTime to)
    {
        List<IStudent> studentsByDateRange = students.Values.Where(
            student => student.AttendanceDates.Any(
                date => date >= from && date <= to
            )
        ).ToList();

        return studentsByDateRange;
    }

    public List<IStudent> SortStudentsByLastName()
    {
        // Sorth students by their lastname Time Complexity 0(n^2)
        List<IStudent> sorted = students.Values.ToList<IStudent>();

        for(int i = 1; i < sorted.Count; i++)
        {
            IStudent current = sorted[i];

            int j = i - 1;

            while(j >= 0 && string.Compare(sorted[j].LastName, current.LastName) > 0)
            {
                sorted[j + 1] = sorted[j];
                j--;
            }

            sorted[j + 1] = current;
        }

        return sorted;
    }
}