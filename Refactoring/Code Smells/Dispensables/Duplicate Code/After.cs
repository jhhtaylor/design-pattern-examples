public static class EmailValidator
{
    public static bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}

public class Customer
{
    public string Email { get; set; }

    public bool ValidateEmail()
    {
        return EmailValidator.IsValidEmail(Email);
    }
}

public class Supplier
{
    public string Email { get; set; }

    public bool ValidateEmail()
    {
        return EmailValidator.IsValidEmail(Email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer { Email = "customer@example.com" };
        Console.WriteLine(customer.ValidateEmail()); // True or False based on validation

        var supplier = new Supplier { Email = "supplier@example.com" };
        Console.WriteLine(supplier.ValidateEmail()); // True or False based on validation

    }
}
