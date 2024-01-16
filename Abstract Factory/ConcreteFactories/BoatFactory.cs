using Abstract_Factory.ConcreteProducts;

namespace Abstract_Factory.ConcreteFactories;

// concrete factory implements methods of abstract factory.
class BoatFactory : IAbstractTransportFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new Boat();
    }

    public IAbstractProductB CreateProductB()
    {
        return new BoatSail();
    }
}
