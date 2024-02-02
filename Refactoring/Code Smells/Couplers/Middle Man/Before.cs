public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }

    public void TakeBreak()
    {
        Console.WriteLine($"{Name} is taking a break.");
    }
}

public class EmployeeManager
{
    private Employee employee;

    public EmployeeManager(Employee employee)
    {
        this.employee = employee;
    }

    public void Work()
    {
        employee.Work();
    }

    public void TakeBreak()
    {
        employee.TakeBreak();
    }
}