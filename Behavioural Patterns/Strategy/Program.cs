//Client Code

class Program
{
    static void Main(string[] args)
    {
        SortedList sortedList = new SortedList();

        sortedList.Add(1);
        sortedList.Add(3);
        sortedList.Add(2);

        // Set strategy to Bubble Sort
        sortedList.SetSortStrategy(new BubbleSortStrategy());
        sortedList.Sort();

        // Change strategy to Quick Sort
        sortedList.SetSortStrategy(new QuickSortStrategy());
        sortedList.Sort();
    }
}
