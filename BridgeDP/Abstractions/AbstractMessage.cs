using BridgeDP.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.Abstractions;

/// <summary>
/// Abstraction class: defines the interface
/// </summary>
internal abstract class AbstractMessage
{
    protected IMessageSender? _sender;

    public AbstractMessage(IMessageSender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// abstract method to send a text.
    /// </summary>
    /// <param name="text"></param>
    public abstract void Send(string text);
}
