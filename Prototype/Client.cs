namespace Prototype;

internal class Client
{
    public ICloneableMachine CloneMachine(ICloneableMachine prototype)
    {
        return prototype.Clone();
    }
}
