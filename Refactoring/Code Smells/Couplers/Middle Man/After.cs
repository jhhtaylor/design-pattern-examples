//The solution is to remove the EmployeeManager if it's not adding significant value and let clients interact with Employee directly:

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

public class Program
{
    public void Main()
    {
        Employee employee = new Employee { Name = "John Doe", Age = 30 };
        employee.Work();
        employee.TakeBreak();
    }
}
