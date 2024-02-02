public class SalaryCalculator
{
    // Calculates monthly salary
    // Parameters:
    // baseSalary: The base salary of the employee
    // bonusPercentage: The percentage of the bonus to apply
    // deduction: Deductions to apply
    public decimal CalculateSalary(decimal baseSalary, decimal bonusPercentage, decimal deduction)
    {
        // Calculate bonus
        decimal bonus = baseSalary * (bonusPercentage / 100);

        // Apply deduction
        decimal salary = baseSalary + bonus - deduction;

        // Return the final salary
        return salary;
    }
}
