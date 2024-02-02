public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Processing logic...
        Console.WriteLine("Order processed"); // Suppose this is a log statement.
    }
}

public class InventoryManager
{
    public void UpdateInventory(Product product)
    {
        // Inventory update logic...
        Console.WriteLine("Inventory updated"); // Another log statement.
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(PaymentDetails paymentDetails)
    {
        // Payment processing logic...
        Console.WriteLine("Payment processed"); // Yet another log statement.
    }
}
