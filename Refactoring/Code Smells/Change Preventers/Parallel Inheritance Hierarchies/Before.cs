// Employee hierarchy
public abstract class Employee
{
    public abstract void Work();
}

public class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Writing code");
    }
}

public class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Managing team");
    }
}

// Parallel EmployeeBenefits hierarchy
public abstract class EmployeeBenefits
{
    public abstract void ApplyBenefits();
}

public class DeveloperBenefits : EmployeeBenefits
{
    public override void ApplyBenefits()
    {
        Console.WriteLine("Applying developer benefits");
    }
}

public class ManagerBenefits : EmployeeBenefits
{
    public override void ApplyBenefits()
    {
        Console.WriteLine("Applying manager benefits");
    }
}
