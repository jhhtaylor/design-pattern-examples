//Adapter
public class PrinterAdapter : IPrinter
{
    private readonly LegacyPrinter _legacyPrinter;

    public PrinterAdapter(LegacyPrinter legacyPrinter)
    {
        _legacyPrinter = legacyPrinter;
    }

    public void Print(string content)
    {
        string legacyFormatContent = ConvertToLegacyFormat(content);
        _legacyPrinter.PrintDocument(legacyFormatContent);
    }

    private string ConvertToLegacyFormat(string content)
    {
        // Convert modern format content to legacy format
        // For simplicity, let's assume it's just a string conversion
        return $"Converted to legacy: {content}";
    }
}
