public interface IWork
{
    void DoWork();
}

public class ConcreteWork : IWork
{
    public void DoWork()
    {
        Console.WriteLine("Doing concrete work");
    }
}

public class FutureWork : IWork
{
    public void DoWork()
    {
        // Future work implementation, never used
    }
}

public class MoreFutureWork : IWork
{
    public void DoWork()
    {
        // More future work implementation, never used
    }
}
