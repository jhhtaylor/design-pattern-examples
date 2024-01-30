//Visitor Interface and Concrete Visitor

// Visitor Interface
public interface IComputerPartVisitor
{
    void Visit(Computer computer);
    void Visit(Keyboard keyboard);
    void Visit(Monitor monitor);
}

// Concrete Visitor
public class HardwareDiagnostics : IComputerPartVisitor
{
    public void Visit(Computer computer)
    {
        Console.WriteLine("Diagnosing Computer.");
    }

    public void Visit(Keyboard keyboard)
    {
        Console.WriteLine("Diagnosing Keyboard.");
    }

    public void Visit(Monitor monitor)
    {
        Console.WriteLine("Diagnosing Monitor.");
    }
}
