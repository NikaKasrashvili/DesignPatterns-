namespace Adapter;

/// <summary>
/// <strong>Adapter</strong> class that makes <see cref="OldSystem"/> compatible with <see cref="INewSystem"/>.
/// </summary>
internal class Adapter : INewSystem
{
    private OldSystem? _oldSystem;

    public Adapter(OldSystem oldSystem)
    {
        _oldSystem = oldSystem;
    }

    //new system method interface implementation
    public void NewRequest()
    {
        _oldSystem?.Request();
    }
  
}
