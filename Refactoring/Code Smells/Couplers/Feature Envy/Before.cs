public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

public class Order
{
    private readonly Customer customer;
    public decimal Amount { get; set; }

    public Order(Customer customer, decimal amount)
    {
        this.customer = customer;
        Amount = amount;
    }

    public string GenerateOrderSummary()
    {
        return $"Order for {customer.Name} living at {customer.Address} is ${Amount}.";
    }
}
