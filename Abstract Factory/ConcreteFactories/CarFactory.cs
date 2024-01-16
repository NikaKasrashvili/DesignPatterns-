using Abstract_Factory.ConcreteProducts;

namespace Abstract_Factory.ConcreteFactories;


// concrete factory implements methods of abstract factory.
class CarFactory : IAbstractTransportFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new Car();
    }

    public IAbstractProductB CreateProductB()
    {
        return new CarWheel();
    }
}
