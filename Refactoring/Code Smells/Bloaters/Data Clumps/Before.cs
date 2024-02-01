public class Order
{
    public void CreateOrder(string customerName, string customerEmail, string addressLine1, string addressLine2, string city, string postalCode)
    {
        // Use customer information to create an order
    }

    public void SendOrderConfirmation(string customerName, string customerEmail)
    {
        // Send an order confirmation email
    }

    // Other methods that use customerName, customerEmail, addressLine1, addressLine2, city, postalCode
}

public class CustomerService
{
    public void RegisterComplaint(string customerName, string customerEmail, string complaintDetails)
    {
        // Register a customer complaint
    }

    // Other methods that use customerName and customerEmail
}
