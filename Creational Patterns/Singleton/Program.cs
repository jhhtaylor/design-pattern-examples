class Program
{
    static void Main(string[] args)
    {
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        singleton1.DoSomething(); // Output: Doing something...

        // Check if both instances are the same
        Console.WriteLine(singleton1 == singleton2); // Output: True
    }
}
