namespace FactoryMethod.ConcreteProducts;

class Doll : IToy
{
    public void SomeMethod()
    {
        Console.WriteLine("Making a toy doll!");
    }

}
