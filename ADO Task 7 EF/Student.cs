﻿using ADOTask7EF;

namespace ADO_Task_7_EF;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}