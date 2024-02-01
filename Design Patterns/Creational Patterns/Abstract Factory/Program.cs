class Program
{
    static void Main(string[] args)
    {
        IGUIFactory factory;

        // You can extend this logic to choose factory based on a configuration or runtime environment
        string os = "Windows"; // Assume this is the OS where the application is running

        if (os == "Windows")
        {
            factory = new WindowsFactory();
        }
        else
        {
            factory = new MacOSFactory();
        }

        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();

        button.Paint();    // Output will depend on which factory is used
        checkbox.Paint();  // Output will depend on which factory is used
    }
}
