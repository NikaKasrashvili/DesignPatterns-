namespace FactoryMethod.ConcreteProducts;
class Robot : IToy
{
    public void SomeMethod()
    {
        Console.WriteLine("Hi, my name is R2D2.");
    }
}