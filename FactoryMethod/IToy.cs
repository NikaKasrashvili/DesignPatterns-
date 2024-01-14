namespace FactoryMethod;

// Step 1: Creating an interface (abstract  product) for the toys (concrete products).

/// <summary>
/// The IToy is an interface of products that declares 
/// the operations all concrete products must implement.
/// </summary>
interface IToy
{
    /// <summary>
    /// Operation that makes concrete product (Toy)
    /// </summary>
    void Make();
}
