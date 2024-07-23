using ADOTask7EF;

namespace ADO_Task_7_EF;

public class Group
{
    public int GroupId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public int Year { get; set; }
    public IEnumerable<Student> Students { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
