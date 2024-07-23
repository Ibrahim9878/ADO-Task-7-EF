using ADO_Task_7_EF;

namespace ADOTask7EF;

public class Faculty
{
    public int FacultyId { get; set; }
    public string Name { get; set; }
    public IEnumerable<Student> Students { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
