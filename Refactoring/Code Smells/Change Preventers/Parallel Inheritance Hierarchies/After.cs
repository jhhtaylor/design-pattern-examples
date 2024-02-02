public abstract class Employee
{
    public abstract void Work();
    public abstract void ApplyBenefits();
}

public class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Writing code");
    }

    public override void ApplyBenefits()
    {
        Console.WriteLine("Applying developer benefits");
    }
}

public class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Managing team");
    }

    public override void ApplyBenefits()
    {
        Console.WriteLine("Applying manager benefits");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Developer(),
            new Manager()
        };

        foreach (var employee in employees)
        {
            employee.Work();
            employee.ApplyBenefits();
        }
    }
}
