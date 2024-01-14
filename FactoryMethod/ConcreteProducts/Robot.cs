namespace FactoryMethod.ConcreteProducts;
class Robot : IToy
{
    public void Make()
    {
        Console.WriteLine("Making a toy robot!");
    }
}