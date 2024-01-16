namespace Abstract_Factory.ConcreteProducts;


//concrete product B2
internal class BoatSail : IAbstractProductB
{
    public void TransportAttachement()
    {
        Console.WriteLine("Boat now has sail. Congrats!!!");
    }
}
