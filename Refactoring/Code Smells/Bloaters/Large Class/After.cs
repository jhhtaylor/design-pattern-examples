public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Department { get; set; }

    public Employee(string name, int id, string department)
    {
        Name = name;
        Id = id;
        Department = department;
    }

    // Methods related to employee details
}

public class PayrollManager
{
    public decimal CalculatePayroll(Employee employee)
    {
        // Calculate and return payroll for the given employee
        return 0; // Simplified
    }

    // Other payroll-related methods
}

public class PerformanceReviewManager
{
    public void PerformAnnualReview(Employee employee)
    {
        // Perform annual review for the given employee
    }

    // Other performance review-related methods
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John Doe", 12345, "Software Development");

        PayrollManager payrollManager = new PayrollManager();
        decimal payroll = payrollManager.CalculatePayroll(employee);

        PerformanceReviewManager reviewManager = new PerformanceReviewManager();
        reviewManager.PerformAnnualReview(employee);

        // Now, each class has a single responsibility and the system is more modular and maintainable.
    }
}
