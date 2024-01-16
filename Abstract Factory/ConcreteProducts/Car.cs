namespace Abstract_Factory.ConcreteProducts;

//concrete product A1
internal class Car : IAbstractProductA
{
    public void BuildTransport()
    {
        Console.WriteLine("Car has been created!.");
    }
}
