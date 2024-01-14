using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteCreators;

class DollCreator : ToyFactory
{
    public override IToy CreateToy()
    {
        return new Doll();
    }
}
