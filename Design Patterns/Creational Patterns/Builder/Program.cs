class Program
{
    static void Main(string[] args)
    {
        var builder = new ConcreteHouseBuilder();
        var director = new HouseDirector();

        // Build a luxury house
        director.ConstructLuxuryHouse(builder);
        House luxuryHouse = builder.GetHouse();
        Console.WriteLine(luxuryHouse);

        // Reset the builder and build a simple house
        builder = new ConcreteHouseBuilder();
        director.ConstructSimpleHouse(builder);
        House simpleHouse = builder.GetHouse();
        Console.WriteLine(simpleHouse);
    }
}
