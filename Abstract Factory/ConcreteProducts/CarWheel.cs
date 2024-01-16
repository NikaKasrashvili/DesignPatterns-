namespace Abstract_Factory.ConcreteProducts;

//concrete product B1
internal class CarWheel : IAbstractProductB
{
    public void TransportAttachement()
    {
        Console.WriteLine("Added wheels to the car");
    }
}
