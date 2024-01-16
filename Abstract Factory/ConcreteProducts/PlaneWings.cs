namespace Abstract_Factory.ConcreteProducts;

//concrete product B3
internal class PlaneWings : IAbstractProductB
{
    public void TransportAttachement()
    {
        Console.WriteLine("Wings attached!");
    }
}
