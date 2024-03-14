namespace ChainOfResponsibilityDP.ConcreteHandlers;

internal class Aragorn : IFellowshipHandler
{
    private IFellowshipHandler _nextHandler;
    public void HandleThreat(string threat)
    {
       

        if (threat.Contains("Orcs"))
        {
            Console.WriteLine("Aragorn battles the Orcs!");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleThreat(threat);
        }
        else
        {
            Console.WriteLine("No one can handle this threat! Sh*t!");
        }
    }

    public void SetNextFellow(IFellowshipHandler handler)
    {
        _nextHandler = handler;
    }
}
