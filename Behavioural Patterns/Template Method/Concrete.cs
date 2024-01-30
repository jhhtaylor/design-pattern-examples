//Concrete Subclasses

public class CsvDataProcessor : DataProcessor
{
    protected override void ProcessDataCore()
    {
        Console.WriteLine("Processing CSV data...");
    }
}

public class XmlDataProcessor : DataProcessor
{
    protected override void ProcessDataCore()
    {
        Console.WriteLine("Processing XML data...");
    }
}
