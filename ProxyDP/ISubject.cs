namespace ProxyDP;

/// <summary>
///  Interface that declares common operations for both RealSubject and Proxy
/// </summary>

interface ISubject
{
    /// <summary>
    /// method of <see cref="ISubject"/> interface, 
    /// which will be implemented into real subject class.
    /// </summary>
    void Request();
}
