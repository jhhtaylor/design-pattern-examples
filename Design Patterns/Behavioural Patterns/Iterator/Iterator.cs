// The Iterator Interface and Concrete Iterator

public interface IBookIterator
{
    Book First();
    Book Next();
    bool IsDone { get; }
    Book CurrentItem { get; }
}

public class BookIterator : IBookIterator
{
    private BookCollection _collection;
    private int _current = 0;
    private int _step = 1;

    public BookIterator(BookCollection collection)
    {
        _collection = collection;
    }

    public Book First()
    {
        _current = 0;
        return _collection[_current];
    }

    public Book Next()
    {
        _current += _step;
        if (!IsDone)
            return _collection[_current];
        else
            return null;
    }

    public bool IsDone
    {
        get { return _current >= _collection.Count; }
    }

    public Book CurrentItem
    {
        get { return _collection[_current]; }
    }
}
