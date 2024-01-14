namespace FactoryMethod.ConcreteProducts;

class Doll : IToy
{
    public void Make()
    {
        Console.WriteLine("Making a toy doll!");
    }

}
