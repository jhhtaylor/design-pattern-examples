public interface IShapePrototype
{
    IShapePrototype Clone();
}

public class Circle : IShapePrototype
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public IShapePrototype Clone()
    {
        // Shallow Copy: the new object references the same object instances as the original object.
        return this.MemberwiseClone() as Circle;
    }

    public override string ToString()
    {
        return $"Circle with radius {Radius}";
    }
}

public class Rectangle : IShapePrototype
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public IShapePrototype Clone()
    {
        // Shallow Copy: the new object references the same object instances as the original object.
        return this.MemberwiseClone() as Rectangle;
    }

    public override string ToString()
    {
        return $"Rectangle with width {Width} and height {Height}";
    }
}
