using BridgeDP.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.Abstractions;

internal class LongMessages : AbstractMessage
{

    public LongMessages(IMessageSender sender) : base(sender)
    { }

    public override void Send(string text)
    {
        _sender?.SendMessage($"Long: {text}");
    }
}
