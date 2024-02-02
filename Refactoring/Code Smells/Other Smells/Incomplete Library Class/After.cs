//To extend the functionality without modifying the original JsonSerializer,
//you can create a decorator or a subclass that adds pretty-print functionality:

public class PrettyPrintJsonSerializer : JsonSerializer
{
    public string SerializePretty(object obj)
    {
        var basicJson = base.Serialize(obj);
        return PrettyPrint(basicJson); // Assume PrettyPrint is a method that formats JSON
    }

    private string PrettyPrint(string json)
    {
        // Implementation of pretty printing
        return $"Pretty: {json}"; // Simplified for example
    }
}

public class JsonSerializerDecorator
{
    private readonly JsonSerializer jsonSerializer;

    public JsonSerializerDecorator(JsonSerializer jsonSerializer)
    {
        this.jsonSerializer = jsonSerializer;
    }

    public string SerializePretty(object obj)
    {
        var basicJson = jsonSerializer.Serialize(obj);
        return PrettyPrint(basicJson);
    }

    private string PrettyPrint(string json)
    {
        // Implementation of pretty printing
        return $"Pretty: {json}"; // Simplified for example
    }
}

public class Program
{
    public void Main()
    {
        var myObject = new { Name = "Alice", Age = 30 };

        // Using Subclassing
        var prettySerializerSubclass = new PrettyPrintJsonSerializer();
        Console.WriteLine(prettySerializerSubclass.SerializePretty(myObject));

        // Using Decorator
        var jsonSerializer = new JsonSerializer();
        var prettySerializerDecorator = new JsonSerializerDecorator(jsonSerializer);
        Console.WriteLine(prettySerializerDecorator.SerializePretty(myObject));
    }
}