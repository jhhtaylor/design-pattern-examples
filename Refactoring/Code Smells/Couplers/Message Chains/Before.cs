public class School
{
    public Department Department { get; set; }
}

public class Department
{
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
}

public class Teacher
{
    public string Name { get; set; }
}

public class Program
{
    public void Main()
    {
        School school = new School();
        // Assume school.Department is properly initialized
        string teacherName = school.Department.Teachers.FirstOrDefault()?.Name;
    }
}