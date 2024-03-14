namespace ChainOfResponsibilityDP;

/// <summary>
/// Handler interface 
/// </summary>
internal interface IFellowshipHandler
{
    /// <summary>
    /// Method for executing a request
    /// </summary>
    /// <param name="threat"></param>
    void HandleThreat(string threat);
    /// <summary>
    /// Method of <see cref="IFellowshipHandler"/>
    /// that builds the chain of handlers
    /// </summary>
    /// <param name="fellow"></param>
    void SetNextFellow(IFellowshipHandler handler);
}
