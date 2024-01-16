namespace Abstract_Factory;

/// <summary>
/// <para>
///     Base inteface of product (transport). 
/// </para>
///     Part "B" of product family
/// </summary>
interface IAbstractProductB
{
    /// <summary>
    /// Method will be same  for all the concrete products,
    /// but implementation can be different for each of them.
    /// </summary>
    void TransportAttachement();
}
