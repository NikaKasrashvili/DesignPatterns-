using Abstract_Factory.ConcreteProducts;

namespace Abstract_Factory.ConcreteFactories;

// concrete factory implements methods of abstract factory.
class PlaneFactory : IAbstractTransportFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new Plane();
    }

    public IAbstractProductB CreateProductB()
    {
        return new PlaneWings();
    }
}
