public enum DocumentType
{
    Word,
    Pdf,
    Excel
}

public class Document
{
    public DocumentType Type { get; set; }

    public void Open()
    {
        switch (Type)
        {
            case DocumentType.Word:
                Console.WriteLine("Opening Word document");
                break;
            case DocumentType.Pdf:
                Console.WriteLine("Opening PDF document");
                break;
            case DocumentType.Excel:
                Console.WriteLine("Opening Excel document");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
