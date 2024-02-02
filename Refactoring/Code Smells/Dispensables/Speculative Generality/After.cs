public class Work
{
    public void DoWork()
    {
        Console.WriteLine("Doing work");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Work work = new Work();
        work.DoWork();
    }
}