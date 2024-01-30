using System;

// Element Interface
public interface IComputerPart
{
    void Accept(IComputerPartVisitor visitor);
}

// Concrete Elements
public class Keyboard : IComputerPart
{
    public void Accept(IComputerPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Monitor : IComputerPart
{
    public void Accept(IComputerPartVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Computer : IComputerPart
{
    IComputerPart[] parts;

    public Computer()
    {
        parts = new IComputerPart[] { new Keyboard(), new Monitor() };
    }

    public void Accept(IComputerPartVisitor visitor)
    {
        foreach (var part in parts)
        {
            part.Accept(visitor);
        }
        visitor.Visit(this);
    }
}
