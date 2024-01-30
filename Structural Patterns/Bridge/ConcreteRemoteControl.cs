public class BasicRemoteControl : RemoteControl
{
    public BasicRemoteControl(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        // Basic power toggle implementation
    }

    // Other basic interactions
}

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        // Advanced power toggle implementation
    }

    // Other advanced interactions
}
