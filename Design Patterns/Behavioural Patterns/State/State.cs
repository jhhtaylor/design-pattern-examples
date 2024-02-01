//State Interface and Concrete States

using System;

// State Interface
public interface IDocumentState
{
    void Publish();
}

// Concrete States
public class Draft : IDocumentState
{
    public void Publish()
    {
        Console.WriteLine("Document is in Draft. Publishing moves it to Moderation.");
    }
}

public class Moderation : IDocumentState
{
    public void Publish()
    {
        Console.WriteLine("Document is in Moderation. Publishing moves it to Published.");
    }
}

public class Published : IDocumentState
{
    public void Publish()
    {
        Console.WriteLine("Document is already Published.");
    }
}

