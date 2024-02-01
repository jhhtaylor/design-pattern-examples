public interface IFlyable
{
    void Fly();
}

public abstract class Bird
{
    // Common bird-related methods
}

public class Eagle : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Eagle is soaring high");
    }
}

public class Penguin : Bird
{
    // Penguin-specific methods
}

class Program
{
    static void Main(string[] args)
    {
        List<Bird> birds = new List<Bird> { new Eagle(), new Penguin() };

        foreach (var bird in birds)
        {
            if (bird is IFlyable flyableBird)
            {
                flyableBird.Fly();
            }
            else
            {
                Console.WriteLine($"{bird.GetType().Name} cannot fly.");
            }
        }
    }
}
