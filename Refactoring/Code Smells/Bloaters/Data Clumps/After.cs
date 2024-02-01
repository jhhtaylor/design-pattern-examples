public class Customer
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

public class Address
{
    public string AddressLine1 { get; private set; }
    public string AddressLine2 { get; private set; }
    public string City { get; private set; }
    public string PostalCode { get; private set; }

    public Address(string addressLine1, string addressLine2, string city, string postalCode)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        PostalCode = postalCode;
    }
}

public class Order
{
    public void CreateOrder(Customer customer, Address address)
    {
        // Use Customer and Address objects to create an order
    }

    public void SendOrderConfirmation(Customer customer)
    {
        // Send an order confirmation email
    }
}

public class CustomerService
{
    public void RegisterComplaint(Customer customer, string complaintDetails)
    {
        // Register a customer complaint
    }
}

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer("John Doe", "johndoe@example.com");
        var address = new Address("123 Main St", "Suite 100", "Metropolis", "12345");

        var order = new Order();
        order.CreateOrder(customer, address);
        order.SendOrderConfirmation(customer);

        var customerService = new CustomerService();
        customerService.RegisterComplaint(customer, "My order arrived late.");
    }
}
