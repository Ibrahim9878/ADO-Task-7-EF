namespace ADOTask7EF;

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public decimal Financing { get; set; }
    public IEnumerable<Teacher> Teachers { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
