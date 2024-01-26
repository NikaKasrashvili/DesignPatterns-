namespace AdapterDP;

/// <summary>
///  Existing class with an incompatible <see cref="IOldSystem"/> interface. <br/>
///  It's called <strong>  "Adaptee". </strong>
/// </summary>
internal class OldSystem : IOldSystem
{
    public void Request()
    {
        Console.WriteLine("Old System Request");
    }
}
