public interface IDocument
{
    void Open();
}

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word document");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF document");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel document");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDocument document = new WordDocument(); // Can be replaced with any IDocument implementation
        document.Open();

        // To open a different type of document, simply instantiate a different class
        document = new PdfDocument();
        document.Open();
    }
}
