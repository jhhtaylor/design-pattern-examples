using System;
using System.Collections.Generic;

// Component
public interface IShape
{
    void Draw();
}

// Leaf
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Another Leaf
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

// Composite
public class Drawing : IShape
{
    private List<IShape> _shapes = new List<IShape>();

    public void AddShape(IShape shape)
    {
        _shapes.Add(shape);
    }

    public void RemoveShape(IShape shape)
    {
        _shapes.Remove(shape);
    }

    public void Draw()
    {
        Console.WriteLine("Drawing...");
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }
}