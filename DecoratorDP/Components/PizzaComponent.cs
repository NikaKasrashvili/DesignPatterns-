namespace DecoratorDP.Components;

/// <summary>
/// Concrete Component: default implementation of <see cref="IPizzaComponent"/> methods.
/// </summary>
internal class PizzaComponent : IPizzaComponent
{
   public string GetDescription()
    {
        return "Plain pizza";
    }

    public double GetCost()
    {
        return 5.0; // Base cost for plain pizza
    }
}

