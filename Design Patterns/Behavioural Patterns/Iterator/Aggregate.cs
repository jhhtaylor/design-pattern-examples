//The Aggregate Interface and Concrete Aggregate

using System.Collections.Generic;

public interface IBookCollection
{
    BookIterator CreateIterator();
}

public class BookCollection : IBookCollection
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public int Count
    {
        get { return _books.Count; }
    }

    public Book this[int index]
    {
        get { return _books[index]; }
    }

    public BookIterator CreateIterator()
    {
        return new BookIterator(this);
    }
}
