// Client code
class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle();
        IShape rectangle = new Rectangle();

        Drawing drawing = new Drawing();
        drawing.AddShape(circle);
        drawing.AddShape(rectangle);

        drawing.Draw(); // This will draw both the circle and the rectangle
    }
}