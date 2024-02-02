using DecoratorDP.Components;

namespace DecoratorDP.Decorators;

/// <summary>
/// Concrete Decorator, that can be added on base component;
/// </summary>
internal class CheeseDecorator : BasePizzaDecorator
{
    public CheeseDecorator(IPizzaComponent component) : base(component)
    {
    }

    public override string GetDescription()
    {
        return _component.GetDescription() + " with parmezzani cheese";
    }

    public override double GetCost()
    {
        return _component.GetCost() + 2.5; // Additional cost for cheese
    }
}
