namespace ProxyDP;

/// <summary>
/// Real subject class, that implements <see cref="ISubject"/> interface method.
/// </summary>
class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling request.");
    }
}
