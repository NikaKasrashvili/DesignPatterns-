namespace Prototype.PrototypeClasses;

/// <summary>
/// Prototype number 2. 
/// </summary>
internal class WarMachine : ICloneableMachine
{
    private readonly string _name = "War Machine";
    private readonly string _type = "Mark II armor type machine";
    private readonly string _owner;
    private readonly int _demagePerSecond;


    public WarMachine(string owner, int demagePerSecond)
    {
        Console.WriteLine($"Creating {_name}.\n");

        _owner = owner;
        _demagePerSecond = demagePerSecond;
    }

    public ICloneableMachine Clone() => new WarMachine(_owner, _demagePerSecond);
    
    public void StartEngine()
    {
        Console.WriteLine($"Hello, my name is {_name} and I'm a {_type},\n" +
                              $"my owner is {_owner} and" +
                              $" my shooting power is equal to {_demagePerSecond} demage per second\n");
    }
}
