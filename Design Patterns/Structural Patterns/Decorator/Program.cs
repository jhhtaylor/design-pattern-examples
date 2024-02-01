// Client code
class Program
{
    static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.Description}: ${coffee.Cost()}");

        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.Description}: ${coffee.Cost()}");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.Description}: ${coffee.Cost()}");
    }
}