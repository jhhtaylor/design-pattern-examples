public class Email
{
    private string _value;

    public Email(string value)
    {
        if (!IsValidEmail(value))
        {
            throw new ArgumentException("Invalid email format");
        }
        _value = value;
    }

    public static bool IsValidEmail(string email)
    {
        // Simple validation - can be expanded
        return email.Contains("@");
    }

    public override string ToString()
    {
        return _value;
    }
}

public class ZipCode
{
    private string _value;

    public ZipCode(string value)
    {
        if (!IsValidZipCode(value))
        {
            throw new ArgumentException("Invalid zip code format");
        }
        _value = value;
    }

    public static bool IsValidZipCode(string zipCode)
    {
        // Simple validation - can be more specific
        return zipCode.Length == 5 || zipCode.Length == 9;
    }

    public override string ToString()
    {
        return _value;
    }
}

public class Customer
{
    public string Name { get; set; }
    public Email Email { get; set; }
    public ZipCode ZipCode { get; set; }

    public Customer(string name, Email email, ZipCode zipCode)
    {
        Name = name;
        Email = email;
        ZipCode = zipCode;
    }

    // Other methods...
}