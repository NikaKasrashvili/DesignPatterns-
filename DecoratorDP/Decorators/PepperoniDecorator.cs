using DecoratorDP.Components;

namespace DecoratorDP.Decorators
{
    /// <summary>
    /// Concrete Decorator, that can be added on base component;
    /// </summary>
    internal class PepperoniDecorator : BasePizzaDecorator
    {
        public PepperoniDecorator(IPizzaComponent component) : base(component)
        {
        }

        public override string GetDescription()
        {
            return _component.GetDescription() + "plus pepperoni";
        }

        public override double GetCost()
        {
            return _component.GetCost() + 3.6;
        }
    }
}
