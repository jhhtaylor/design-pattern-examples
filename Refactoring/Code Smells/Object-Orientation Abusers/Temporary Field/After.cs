public class Order
{
    public OrderType Type { get; set; }
    // Other order properties...
}

public enum OrderType
{
    Physical,
    Digital
}

public interface IOrderProcessor
{
    void ProcessOrder();
}

public class PhysicalOrderProcessor : IOrderProcessor
{
    private Order order;
    private string shippingAddress;

    public PhysicalOrderProcessor(Order order, string shippingAddress)
    {
        this.order = order;
        this.shippingAddress = shippingAddress;
    }

    public void ProcessOrder()
    {
        // Process physical order with shipping
    }
}

public class DigitalOrderProcessor : IOrderProcessor
{
    private Order order;

    public DigitalOrderProcessor(Order order)
    {
        this.order = order;
    }

    public void ProcessOrder()
    {
        // Process digital order without shipping
    }
}

class Program
{
    static void Main(string[] args)
    {
        Order physicalOrder = new Order { Type = OrderType.Physical };
        IOrderProcessor physicalProcessor = new PhysicalOrderProcessor(physicalOrder, "123 Main St");
        physicalProcessor.ProcessOrder();

        Order digitalOrder = new Order { Type = OrderType.Digital };
        IOrderProcessor digitalProcessor = new DigitalOrderProcessor(digitalOrder);
        digitalProcessor.ProcessOrder();
    }
}

