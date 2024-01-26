namespace AdapterDP;

// InewSystem interface is implemented into adapter class,
//not in NewSystem class.
internal class NewSystem
{
    private INewSystem _newSystem;

    public NewSystem(INewSystem newSystem)
    {
        _newSystem = newSystem;
    }

    /// <summary>
    /// Method to call <strong> NewRequest </strong> method 
    /// from <see cref="INewSystem"/> interface.
    /// </summary>
    public void PerformNewRequest()
    {
        Console.WriteLine("New System: this is new system request.");
        _newSystem.NewRequest();
    }
}
