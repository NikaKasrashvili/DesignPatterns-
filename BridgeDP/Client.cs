using BridgeDP.Abstractions;

namespace BridgeDP;

/// <summary>
/// client code should only depend on the Abstraction class.
/// </summary>
internal class Client
{
    public void ClientCode(AbstractMessage abstraction, string text)
    {
        abstraction.Send(text);
    }
}
