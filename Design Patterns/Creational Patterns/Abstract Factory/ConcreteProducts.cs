public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Windows style.");
    }
}

public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in MacOS style.");
    }
}

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Windows style.");
    }
}

public class MacOSCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in MacOS style.");
    }
}
