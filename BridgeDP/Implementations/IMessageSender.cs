namespace BridgeDP.Implementations;

/// <summary>
/// Implementations interface, often called <strong>"Implementor"</strong>,<br/>
/// defines the actual implementation that abstraction uses.
/// </summary>
internal interface IMessageSender
{
    /// <summary>
    /// Method to send a message.
    /// </summary>
    /// <param name="message"></param>
    void SendMessage(string message);
}
