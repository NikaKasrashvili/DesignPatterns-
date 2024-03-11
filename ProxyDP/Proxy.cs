namespace ProxyDP;

/// <summary>
/// Proxy class, that implements identical interface as real subject class.
/// </summary>
class Proxy : ISubject
{
    private RealSubject _realSubject;


    public void Request()
    {
        // Lazy initialization: create the real subject only when necessary
        if (_realSubject == null)
        {
            Console.WriteLine("Proxy: Creating RealSubject instance.");
            _realSubject = new RealSubject();
        }

        // Proxy delegates work to the real subject
        _realSubject.Request();
    }
}
