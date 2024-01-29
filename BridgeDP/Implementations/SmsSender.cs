namespace BridgeDP.Implementations;

/// <summary>
/// Concrete implementation A: sends Sms.
/// </summary>
internal class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Sms: {message}");
    }
}
