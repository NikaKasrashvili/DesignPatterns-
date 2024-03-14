namespace ChainOfResponsibilityDP.ConcreteHandlers;

internal class Gandalf : IFellowshipHandler
{
    private IFellowshipHandler _nextHandler;

    public void HandleThreat(string threat)
    {
        #region Console threat

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{threat}");
        Console.ForegroundColor = ConsoleColor.White;
        #endregion

        if (threat.Contains("Balrog"))
        {
            Console.WriteLine("Gandalf fights the Balrog!");
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
