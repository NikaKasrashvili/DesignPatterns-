namespace Abstract_Factory.ConcreteProducts;

//concrete product A2
internal class Boat : IAbstractProductA
{
    public void BuildTransport()
    {
        Console.WriteLine("New boat has been created");
    }
}
