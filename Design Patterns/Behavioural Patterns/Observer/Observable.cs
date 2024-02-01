// Observable (Subject) Interface and Concrete Observable

using System;
using System.Collections.Generic;

public interface IWeatherStation
{
    void AddObserver(IDisplay display);
    void RemoveObserver(IDisplay display);
    void NotifyObservers();
}

public class WeatherStation : IWeatherStation
{
    private List<IDisplay> _observers = new List<IDisplay>();
    private float _temperature;

    public float Temperature
    {
        get { return _temperature; }
        set
        {
            _temperature = value;
            NotifyObservers();
        }
    }

    public void AddObserver(IDisplay display)
    {
        _observers.Add(display);
    }

    public void RemoveObserver(IDisplay display)
    {
        _observers.Remove(display);
    }

    public void NotifyObservers()
    {
        foreach (IDisplay observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}
