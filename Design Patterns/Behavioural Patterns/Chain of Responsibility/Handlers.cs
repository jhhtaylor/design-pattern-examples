using System;

// Handler
public abstract class SupportHandler
{
    protected SupportHandler _nextHandler;

    public void SetNextHandler(SupportHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void HandleRequest(SupportRequest request);
}

// Concrete Handler 1
public class CallCenterExecutive : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Level <= SupportLevel.Basic)
        {
            Console.WriteLine("Call Center Executive handling request: " + request.Description);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}

// Concrete Handler 2
public class Supervisor : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Level <= SupportLevel.Intermediate)
        {
            Console.WriteLine("Supervisor handling request: " + request.Description);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}

// Concrete Handler 3
public class Manager : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        Console.WriteLine("Manager handling request: " + request.Description);
    }
}

// Request Levels
public enum SupportLevel
{
    Basic,
    Intermediate,
    Advanced
}

// Request
public class SupportRequest
{
    public string Description { get; set; }
    public SupportLevel Level { get; set; }

    public SupportRequest(string description, SupportLevel level)
    {
        Description = description;
        Level = level;
    }
}
