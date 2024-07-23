using ADO_Task_7_EF;

namespace ADOTask7EF;

public class Teacher
{
    public int TeacherId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EmploymentDate { get; set; }
    public decimal Premium { get; set; }
    public decimal Salary { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public IEnumerable<Group> Groups { get; set; }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}
