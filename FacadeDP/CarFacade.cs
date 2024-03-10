using FacadeDP.SubSystems;

namespace FacadeDP;

/// <summary>
/// Facade class
/// </summary>
internal class CarFacade
{
    private EngineSystem _engineSystem;
    private FuelInjectorSystem _fuelInjectorSystem;
    private IgnitionSystem _ignitionSystem;

    #region Constructor

    public CarFacade()
    {
        _engineSystem = new EngineSystem();
        _fuelInjectorSystem = new FuelInjectorSystem();
        _ignitionSystem = new IgnitionSystem();
    }
    #endregion

    public void StartCar()
    {
        _engineSystem.Start();
        _fuelInjectorSystem.InjectFuel();
        _ignitionSystem.Ignite();

        Console.WriteLine("Car started!");
    }
}
