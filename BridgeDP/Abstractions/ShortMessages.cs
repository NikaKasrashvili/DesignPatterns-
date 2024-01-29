using BridgeDP.Implementations;

namespace BridgeDP.Abstractions;

internal class ShortMessages : AbstractMessage
{
    public ShortMessages(IMessageSender sender) : base(sender)
    { }

    public override void Send(string text)
    {
        _sender?.SendMessage($"Short: {text}");
    }
}
