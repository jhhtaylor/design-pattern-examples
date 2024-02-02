public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int sum = calculator.Add(5, 3);
        Console.WriteLine($"Sum: {sum}");

    }
}