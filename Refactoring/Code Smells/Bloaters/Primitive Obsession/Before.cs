public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string ZipCode { get; set; }

    public Customer(string name, string email, string zipCode)
    {
        Name = name;
        Email = email;
        ZipCode = zipCode;
    }

    // Other methods...
}
