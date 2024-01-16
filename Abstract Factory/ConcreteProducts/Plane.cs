namespace Abstract_Factory.ConcreteProducts;

//concrete product A3
internal class Plane : IAbstractProductA
{
    public void BuildTransport()
    {
        Console.WriteLine("New plane has been created!");
    }
}
