using FactoryMethod.ConcreteCreators;
using FactoryMethod.ConcreteProducts;

namespace FactoryMethod;

class Client
{
    public void Main()
    {
        Console.WriteLine("Factory: [lease, provide which toy you want to make");
        string toy = Console.ReadLine().ToLower();

        switch (toy)
        {
            case "car":
                Console.WriteLine("Client: create a car toy!");
                ClientCode(new CarCreator());
                break;

            case "doll":
                Console.WriteLine("Client: create a toy Doll!");

                //same code as above - in order to show what does ClientCode(new DollCreator) do.
                ToyFactory dollFactory = new DollCreator();
                dollFactory.CallFactoryMethod();
                break;
            
            case "robot":
                Console.WriteLine("Client: create a toy Robot!");
                ClientCode(new RobotCreator());
                break;
            
            default:
                Console.WriteLine("Sorry, we cant produce such type of toy");
                break;
        }
    }

    /// <summary>
    /// <para>  
    ///     The client code works with an instance of a concrete creator. 
    /// </para>
    /// </summary>
    /// <param name="concreteCreator">pass any creator's
    /// subclass</param>
    public void ClientCode(ToyFactory concreteCreator)
    {
        concreteCreator.CallFactoryMethod();

    }
}
