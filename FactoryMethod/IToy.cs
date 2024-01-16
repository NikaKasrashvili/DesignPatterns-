namespace FactoryMethod;

// Step 1: Creating an interface (abstract  product) for the toys (concrete products).

/// <summary>
/// The IToy is an interface of products that declares 
/// the operations all concrete products must implement.
/// </summary>
interface IToy
{
    /// <summary>
    /// Operation of abstract product that will be altered (cahnged) in concrete products.
    /// </summary>
    void SomeMethod();
}
