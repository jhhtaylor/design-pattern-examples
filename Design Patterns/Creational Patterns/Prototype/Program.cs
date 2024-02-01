class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Circle circle2 = circle1.Clone() as Circle;
        circle2.Radius = 10;

        Rectangle rectangle1 = new Rectangle(3, 4);
        Rectangle rectangle2 = rectangle1.Clone() as Rectangle;
        rectangle2.Width = 5;

        Console.WriteLine(circle1);  // Output: Circle with radius 5
        Console.WriteLine(circle2);  // Output: Circle with radius 10
        Console.WriteLine(rectangle1);  // Output: Rectangle with width 3 and height 4
        Console.WriteLine(rectangle2);  // Output: Rectangle with width 5 and height 4
    }
}
