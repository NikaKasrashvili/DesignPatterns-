namespace Abstract_Factory;

// Concrete products should implement abstract products interfaces.

/// <summary>
/// <para>
///     Base inteface of product (transport). 
/// </para>
///     Part "A" of product family
/// </summary>
interface IAbstractProductA
{
    /// <summary>
    /// Method will be same  for all the concrete products,
    /// but implementation can be different for each of them.
    /// </summary>
    void BuildTransport();
}
