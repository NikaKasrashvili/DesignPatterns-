namespace Abstract_Factory;

// we can declare also abstract class instead of Abstract Factory Interface.

/// <summary>
/// Abstract Factory Interface for transport factory, 
/// which declares methods that return abstract products
/// </summary>
interface IAbstractTransportFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();

}
