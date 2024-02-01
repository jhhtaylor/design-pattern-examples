//Abstract Class with the Template Method

using System;

public abstract class DataProcessor
{
    // Template Method
    public void ProcessData()
    {
        ReadData();
        ProcessDataCore();
        WriteData();
    }

    // Concrete implementation of Read and Write steps
    protected void ReadData()
    {
        Console.WriteLine("Reading data...");
    }

    protected void WriteData()
    {
        Console.WriteLine("Writing data...");
    }

    // Abstract step that subclasses will implement
    protected abstract void ProcessDataCore();
}
