public class Singleton
{
    // Static variable that holds the single instance
    private static Singleton instance = null;

    // Lock object for thread safety
    private static readonly object lockObject = new object();

    // Private constructor so that no instances can be created externally
    private Singleton() { }

    // Public static method to get the instance of the class
    public static Singleton GetInstance()
    {
        // Double-check locking to ensure thread safety
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }

        return instance;
    }

    // Instance method
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
