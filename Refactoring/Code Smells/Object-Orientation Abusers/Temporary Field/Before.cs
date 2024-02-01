public class OrderProcessor
{
    private Order order;
    private string shippingAddress;
    private bool isShippingRequired;

    public OrderProcessor(Order order)
    {
        this.order = order;
        this.isShippingRequired = false;
    }

    public void ProcessOrder()
    {
        if (order.Type == OrderType.Physical)
        {
            isShippingRequired = true;
        }
        // Process the order...
    }

    public void SetShippingDetails(string address)
    {
        if (isShippingRequired)
        {
            shippingAddress = address;
        }
    }

    // Other methods...
}

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
