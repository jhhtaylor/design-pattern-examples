// Client Code

class Program
{
    static void Main(string[] args)
    {
        BookCollection collection = new BookCollection();
        collection.AddBook(new Book("Book 1"));
        collection.AddBook(new Book("Book 2"));
        collection.AddBook(new Book("Book 3"));

        BookIterator iterator = collection.CreateIterator();

        for (Book book = iterator.First(); !iterator.IsDone; book = iterator.Next())
        {
            Console.WriteLine(book.Title);
        }
    }
}
