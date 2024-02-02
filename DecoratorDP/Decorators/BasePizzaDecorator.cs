using DecoratorDP.Components;

namespace DecoratorDP.Decorators;

/// <summary>
/// Base decorator class
/// </summary>
internal class BasePizzaDecorator : IPizzaComponent
{
    protected IPizzaComponent _component;

    public BasePizzaDecorator(IPizzaComponent component)
    {
        _component = component;
    }


    // making implemented methods virtual,
    // because they should be overriden
    // in concrete decorator classes.
    public virtual double GetCost()
    {
        return _component.GetCost();
    }

    public virtual string GetDescription()
    {
        return _component.GetDescription();
    }
}
