// Client code
class Program
{
    static void Main(string[] args)
    {
        string document = "AAZZBBZB";
        char[] chars = document.ToCharArray();

        CharacterFactory factory = new CharacterFactory();
        int pointSize = 10; // External state

        // For each character use a flyweight object
        foreach (char c in chars)
        {
            pointSize++;
            Character character = factory.GetCharacter(c);
            character.Display(pointSize);
        }
    }
}