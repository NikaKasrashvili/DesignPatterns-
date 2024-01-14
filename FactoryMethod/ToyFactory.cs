namespace FactoryMethod;


// Step 3: Creating a ToyFactory that knows how to make toys

/// <summary>
/// <para>
/// The Creator class that declares <strong> factory method <em>(Create Toy)</em> </strong>, 
/// which is supposed to return an object of a Product class. 
/// </para>
/// The Creator's subclasses usually provide
/// the implementation of this method.
/// </summary>
abstract class ToyFactory
{
    /// <summary>
    /// Factory method of <em> ToyFactory Creator </em> class.
    /// </summary>
    /// <returns> An object of a product class </returns>
    public abstract IToy CreateToy();


    /// <summary>
    /// Call the factory method to create a Product object.
    /// </summary>
    public void CallFactoryMethod()
    {
        IToy product = CreateToy();
        product.Make();

    }
}


