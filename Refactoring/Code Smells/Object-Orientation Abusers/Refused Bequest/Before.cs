public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }

    // Other bird-related methods...
}

public class Eagle : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Eagle is soaring high");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins cannot fly!");
    }
}
