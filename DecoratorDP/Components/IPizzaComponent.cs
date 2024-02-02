namespace DecoratorDP.Components;

/// <summary>
/// <strong>Component</strong> Interface : 
/// defines operations that can be altered by decorators.
/// </summary>
internal interface IPizzaComponent
{
    /// <summary>
    /// Method to get description.
    /// </summary>
    /// <returns></returns>
    string GetDescription();
    /// <summary>
    /// Method to get cost of additional decorators and base product.
    /// </summary>
    /// <returns></returns>
    double GetCost();
}
