namespace FactoryMethod.ConcreteProducts;


// Step 2: Implement different types of toys
class Car : IToy
{
    public void SomeMethod()
    {
        Console.WriteLine("I'm a car and I can drive!");
    }

}
