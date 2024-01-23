namespace Prototype;

internal class Client
{
    public ICloneableMachine CreateShape(ICloneableMachine prototype)
    {
        return prototype.Clone();
    }
}
