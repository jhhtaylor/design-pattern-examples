// Client Code

class Program
{
    static void Main(string[] args)
    {
        Light light = new Light();
        ICommand turnOn = new TurnOnLightCommand(light);
        ICommand turnOff = new TurnOffLightCommand(light);

        RemoteControl remote = new RemoteControl();

        // Turn on the light
        remote.SetCommand(turnOn);
        remote.PressButton();

        // Turn off the light
        remote.SetCommand(turnOff);
        remote.PressButton();
    }
}
