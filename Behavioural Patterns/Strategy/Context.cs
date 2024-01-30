//Context Class

public class SortedList
{
    private List<int> _list = new List<int>();
    private ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Add(int number)
    {
        _list.Add(number);
    }

    public void Sort()
    {
        _sortStrategy.Sort(_list);
    }
}
