public class DocumentFactory
{
    public IDocument CreateDocument(string type)
    {
        switch (type)
        {
            case "Word":
                return new WordDocument();
            case "PDF":
                return new PdfDocument();
            default:
                throw new ArgumentException("Invalid type", nameof(type));
        }
    }
}
