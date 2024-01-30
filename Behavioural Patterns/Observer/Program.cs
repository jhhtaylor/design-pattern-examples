// Client Code

class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        PhoneDisplay phoneDisplay = new PhoneDisplay();
        WindowDisplay windowDisplay = new WindowDisplay();

        weatherStation.AddObserver(phoneDisplay);
        weatherStation.AddObserver(windowDisplay);

        weatherStation.Temperature = 30.0f; // This will automatically update the displays

        weatherStation.RemoveObserver(windowDisplay);

        weatherStation.Temperature = 25.0f; // This will update only the phone display
    }
}
