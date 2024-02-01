//Client code
class Program
{
    static void Main(string[] args)
    {
        LegacyPrinter legacyPrinter = new LegacyPrinter();
        IPrinter printerAdapter = new PrinterAdapter(legacyPrinter);

        // The client uses the adapter just like a modern printer
        printerAdapter.Print("Hello, World!");
    }
}
