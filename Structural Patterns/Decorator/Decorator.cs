using System;

// Component
public interface ICoffee
{
    string Description { get; }
    double Cost();
}

// Concrete Component
public class SimpleCoffee : ICoffee
{
    public string Description => "Simple Coffee";

    public double Cost()
    {
        return 2.0;
    }
}

// Decorator
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string Description => _coffee.Description;

    public virtual double Cost()
    {
        return _coffee.Cost();
    }
}

// Concrete Decorator
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string Description => _coffee.Description + ", with milk";

    public override double Cost()
    {
        return _coffee.Cost() + 0.5;
    }
}

// Another Concrete Decorator
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string Description => _coffee.Description + ", with sugar";

    public override double Cost()
    {
        return _coffee.Cost() + 0.3;
    }
}