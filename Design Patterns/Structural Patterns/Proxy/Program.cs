class Program
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("test_image.jpg");

        // Image will be loaded only on demand
        Console.WriteLine("Image will be displayed now");
        image.Display(); // Loading happens here
    }
}
