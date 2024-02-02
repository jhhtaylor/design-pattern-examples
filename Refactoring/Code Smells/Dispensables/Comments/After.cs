public class SalaryCalculator
{
    public decimal CalculateMonthlySalary(decimal baseSalary, decimal bonusRate, decimal deductions)
    {
        decimal bonusAmount = CalculateBonus(baseSalary, bonusRate);
        return CalculateNetSalary(baseSalary, bonusAmount, deductions);
    }

    private decimal CalculateBonus(decimal baseSalary, decimal bonusRate)
    {
        return baseSalary * (bonusRate / 100);
    }

    private decimal CalculateNetSalary(decimal baseSalary, decimal bonusAmount, decimal deductions)
    {
        return baseSalary + bonusAmount - deductions;
    }
}
