public interface IDocument
{
    void Print();
}

public class WordDocument : IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing Word Document");
    }
}

public class PdfDocument : IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing PDF Document");
    }
}
