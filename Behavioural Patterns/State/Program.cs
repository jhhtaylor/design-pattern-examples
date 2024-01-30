//Client Code

class Program
{
    static void Main(string[] args)
    {
        Document document = new Document(new Draft());

        // Current state: Draft
        document.Publish(); // Changes state to Moderation

        // Current state: Moderation
        document.Publish(); // Changes state to Published

        // Current state: Published
        document.Publish(); // Already Published, no state change
    }
}
