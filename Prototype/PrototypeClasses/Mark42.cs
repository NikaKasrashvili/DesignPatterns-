namespace Prototype.PrototypeClasses;

/// <summary>
/// Prototype number 1.
/// </summary>
internal class Mark42 : ICloneableMachine
{
    private readonly string _name = "Mark42";
    private readonly string _type = "Armor";
    private readonly int _height;
    private readonly int _demagePerSecond;

    public Mark42(int height, int demagePerSecond)
    {
        Console.WriteLine($"Creating {_name}.");

        _height = height;
        _demagePerSecond = demagePerSecond;
    }

    //implementing clone method from interface
    public ICloneableMachine Clone()
    {
        // Perform a deep copy* of the object
        return new Mark42(_height, _demagePerSecond);
    }

    public void StartEngine()
    {
        Console.WriteLine($"Hello, my name is {_name} and I'm an {_type},\n" +
                              $" my height is {_height}cm and" +
                              $" my shooting power is equal to {_demagePerSecond} demage per second.\n");
    }
}



//NOTE: deep copy is when you create a new instance for cloned object,
//      so it has it's own referenece that differs from original one's.