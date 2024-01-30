//Strategy Interface and Concrete Strategies

using System;
using System.Collections.Generic;

// Strategy Interface
public interface ISortStrategy
{
    void Sort(List<int> data);
}

// Concrete Strategy 1
public class BubbleSortStrategy : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Sorting using Bubble Sort");
        // Implement Bubble sort...
    }
}

// Concrete Strategy 2
public class QuickSortStrategy : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Sorting using Quick Sort");
        // Implement Quick sort...
    }
}
