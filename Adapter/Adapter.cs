namespace AdapterDP;

/// <summary>
/// <strong>Adapter</strong> class that makes <see cref="OldSystem"/> 
/// compatible with <see cref="INewSystem"/> interface.
/// </summary>
internal class Adapter : INewSystem
{
    private readonly OldSystem? _oldSystem;

    public Adapter(OldSystem oldSystem)
    {
        _oldSystem = oldSystem;
    }

    //InewSystem interface implementation.
    public void NewRequest()
    {
        _oldSystem?.Request();
    }

}
