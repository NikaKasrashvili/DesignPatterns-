using FactoryMethod.ConcreteProducts;

namespace FactoryMethod.ConcreteCreators;

class RobotCreator : ToyFactory
{
    public override IToy CreateToy()
    {
        return new Robot();
    }
}
