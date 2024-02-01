public interface IMessageSender
{
    void SendMessage(string recipient, string subject, string message);
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending Email to {recipient}: {subject}");
        // Implementation for sending an email
    }
}

public class SmsSender : IMessageSender
{
    // Adjusting parameters to fit the interface. Subject can be ignored or used differently for SMS.
    public void SendMessage(string phoneNumber, string subject, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
        // Implementation for sending an SMS
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IMessageSender> messageSenders = new List<IMessageSender>
        {
            new EmailSender(),
            new SmsSender()
        };

        foreach (var sender in messageSenders)
        {
            sender.SendMessage("recipient@example.com", "Hello", "This is a message.");
        }
    }
}
