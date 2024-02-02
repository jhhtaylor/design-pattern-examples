public class Customer
{
    private string Name { get; set; }
    private string Address { get; set; }

    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }

    // Public method to encapsulate customer details access
    public string GetCustomerDetails()
    {
        return $"{Name} living at {Address}";
    }
}


public class Order
{
    private readonly Customer customer;
    public decimal Amount { get; set; }

    public string GenerateOrderSummary()
    {
        // Use the encapsulated method in Customer
        return $"Order for {customer.GetCustomerDetails()} is ${Amount}.";
    }
}


public class Program
{
    public static void Main()
    {
        Customer customer = new Customer("John Doe", "123 Elm Street");
        Order order = new Order(customer, 99.99m);
        Console.WriteLine(order.GenerateOrderSummary());
    }
}