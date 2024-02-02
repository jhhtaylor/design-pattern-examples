public class Logger
{
    public static void Log(string message)
    {
        // Centralized logging logic
        Console.WriteLine(message); // This could be changed to file logging, etc.
    }
}

public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Processing logic...
        Logger.Log("Order processed");
    }
}

public class InventoryManager
{
    public void UpdateInventory(Product product)
    {
        // Inventory update logic...
        Logger.Log("Inventory updated");
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(PaymentDetails paymentDetails)
    {
        // Payment processing logic...
        Logger.Log("Payment processed");
    }
}

//Now, if you need to change the logging from console output to file output
//or include additional information in every log message, you only need to modify the Logger.Log method:

public class Logger
{
    public static void Log(string message)
    {
        // Change logging to file
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}
