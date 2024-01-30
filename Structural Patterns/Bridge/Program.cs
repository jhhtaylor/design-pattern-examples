class Program
{
    static void Main(string[] args)
    {
        IDevice tv = new Tv();
        RemoteControl basicRemote = new BasicRemoteControl(tv);
        basicRemote.TogglePower();

        IDevice radio = new Radio();
        RemoteControl advancedRemote = new AdvancedRemoteControl(radio);
        advancedRemote.TogglePower();
    }
}
