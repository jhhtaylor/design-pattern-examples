public class EmailSender
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending Email to {to}: {subject}");
        // Implementation details...
    }
}

public class SmsSender
{
    public void SendMessage(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
        // Implementation details...
    }
}
