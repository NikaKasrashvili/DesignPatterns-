namespace ChainOfResponsibilityDP.ConcreteHandlers;

internal class Legolas : IFellowshipHandler
{
    private IFellowshipHandler _nextHandler;

    public void HandleThreat(string threat)
    {
        if (threat.Contains("Uruk-hai"))
        {
            Console.WriteLine("Legolas takes down the Uruk-hai!");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleThreat(threat);
        }
        else
        {
            Console.WriteLine("No one can handle this threat!");
        }
    }

    public void SetNextFellow(IFellowshipHandler handler)
    {
        _nextHandler = handler;
    }
}
