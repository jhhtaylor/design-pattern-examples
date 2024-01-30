//Client Code

class Program
{
    static void Main(string[] args)
    {
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.ProcessData();

        DataProcessor xmlProcessor = new XmlDataProcessor();
        xmlProcessor.ProcessData();
    }
}
