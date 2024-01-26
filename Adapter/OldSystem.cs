namespace AdapterDP;

/// <summary>
///  Existing system with an incompatible interface. <br/>
///  It's called <strong>  "Adaptee". </strong>
/// </summary>
internal class OldSystem
{
    /// <summary>
    /// "Request" method from <see cref="OldSystem"/> class.
    /// </summary>
    public void Request()
    {
        Console.WriteLine("Old System Request");
    }
}
