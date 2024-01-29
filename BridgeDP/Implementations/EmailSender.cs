namespace BridgeDP.Implementations;

/// <summary>
/// Concrete implementation B: sends Email.
/// </summary>
internal class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
