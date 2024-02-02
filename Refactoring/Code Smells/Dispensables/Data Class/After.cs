public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    public void SendEmail(string message)
    {
        // Imagine this method actually sends an email.
        Console.WriteLine($"Sending '{message}' to {Email}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Jane Doe",
            Email = "jane.doe@example.com",
            Age = 30
        };

        if (person.IsAdult())
        {
            person.SendEmail("Hello, World!");
        }
    }
}