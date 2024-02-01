class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory = new DocumentFactory();

        IDocument doc1 = factory.CreateDocument("Word");
        doc1.Print(); // Output: Printing Word Document

        IDocument doc2 = factory.CreateDocument("PDF");
        doc2.Print(); // Output: Printing PDF Document
    }
}
