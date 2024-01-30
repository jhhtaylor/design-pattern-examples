using System;

// Subject Interface
public interface IImage
{
    void Display();
}

// RealSubject
public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk(_fileName);
    }

    private void LoadFromDisk(string fileName)
    {
        Console.WriteLine($"Loading {fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_fileName}");
    }
}

// Proxy
public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_fileName);
        }
        _realImage.Display();
    }
}