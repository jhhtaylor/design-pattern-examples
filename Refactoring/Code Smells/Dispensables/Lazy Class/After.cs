//By addressing the Lazy Class code smell, you either remove unnecessary complexity from your codebase,
//making it leaner and more straightforward, or you ensure that each class justifies its existence
// through meaningful functionality.

//If, instead, you believe the SimpleLogger class could be justified in the future by adding more functionality, you can enhance it

public class EnhancedLogger
{
    public void LogMessage(string message)
    {
        // Example of added functionality: prepend timestamp to messages
        Console.WriteLine($"{DateTime.Now}: {message}");
    }

    public void LogError(string message)
    {
        // Further functionality: Handle error logging differently
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{DateTime.Now}: ERROR: {message}");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        EnhancedLogger logger = new EnhancedLogger();
        logger.LogMessage("Starting application...");
        logger.LogError("An error occurred.");
    }
}