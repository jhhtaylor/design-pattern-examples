public class Customer
{
    public string Email { get; set; }

    public bool ValidateEmail()
    {
        return Email.Contains("@") && Email.Contains(".");
    }
}

public class Supplier
{
    public string Email { get; set; }

    public bool ValidateEmail()
    {
        return Email.Contains("@") && Email.Contains(".");
    }
}
