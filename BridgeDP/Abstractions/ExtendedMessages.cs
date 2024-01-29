using BridgeDP.Implementations;

namespace BridgeDP.Abstractions;

internal class ExtendedMessages : AbstractMessage
{
    public ExtendedMessages(IMessageSender sender) : base(sender)
    { }

    public override void Send(string text)
    {
        _sender?.SendMessage(text);
    }
}
