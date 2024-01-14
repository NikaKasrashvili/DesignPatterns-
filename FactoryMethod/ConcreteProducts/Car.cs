namespace FactoryMethod.ConcreteProducts;


// Step 2: Implement different types of toys
class Car : IToy
{
    public void Make()
    {
        Console.WriteLine("Making a toy car!");
    }

}
