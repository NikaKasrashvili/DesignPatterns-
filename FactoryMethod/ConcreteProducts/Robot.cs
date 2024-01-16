namespace FactoryMethod.ConcreteProducts;
class Robot : IToy
{
    public void SomeMethod()
    {
        Console.WriteLine("Making a toy robot!");
    }
}