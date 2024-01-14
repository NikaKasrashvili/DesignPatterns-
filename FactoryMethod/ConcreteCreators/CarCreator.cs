using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteCreators;

class CarCreator : ToyFactory
{
    public override IToy CreateToy()
    {
        return new Car();
    }
}
