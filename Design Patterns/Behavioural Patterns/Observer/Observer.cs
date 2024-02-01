// Observer Interface and Concrete Observers

public interface IDisplay
{
    void Update(float temperature);
}

public class PhoneDisplay : IDisplay
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone Display: Temperature is " + temperature + " degrees");
    }
}

public class WindowDisplay : IDisplay
{
    public void Update(float temperature)
    {
        Console.WriteLine("Window Display: Temperature is " + temperature + " degrees");
    }
}
