using Abstract_Factory;
using Abstract_Factory.ConcreteFactories;

Console.WriteLine("Starting Abstract factory design pattern testing.\n" +
    "Result should be a products of one family (car, plane or boat).\n ");

// choose which type of transport to produce

Console.WriteLine("Factory: Please, enter what type of transport to produce.");
var transportType = Console.ReadLine()?.ToLower();

Console.WriteLine($"Client: I want you to make a {transportType} for me\n");

switch (transportType)
{
    case "car":
        CreateProduct(new CarFactory());
        break;

    case "boat":
        CreateProduct(new BoatFactory());
        break;

    case "plane":
        CreateProduct(new PlaneFactory());
        break;

    default:
        Console.WriteLine("Sorry, we cant produce such type of transport,\n");
        break;
}


// method for creating concrete products according to concrete factory type.
void CreateProduct(IAbstractTransportFactory concreteFactory)
{
    var concreteProductA = concreteFactory.CreateProductA();
    var concreteProductB = concreteFactory.CreateProductB();

    concreteProductA.BuildTransport();
    concreteProductB.TransportAttachement();
}

Console.WriteLine($"Producing {transportType} has been finished!");



//abstract factory
Console.WriteLine("   _____ ___.             __                        __    \r\n  /  _  \\\\_ |__   _______/  |_____________    _____/  |_  \r\n /  /_\\  \\| __ \\ /  ___/\\   __\\_  __ \\__  \\ _/ ___\\   __\\ \r\n/    |    \\ \\_\\ \\\\___ \\  |  |  |  | \\// __ \\\\  \\___|  |   \r\n\\____|__  /___  /____  > |__|  |__|  (____  /\\___  >__|   \r\n        \\/    \\/     \\/                   \\/     \\/       \r\n___________              __                               \r\n\\_   _____/____    _____/  |_  ___________ ___.__.        \r\n |    __) \\__  \\ _/ ___\\   __\\/  _ \\_  __ <   |  |        \r\n |     \\   / __ \\\\  \\___|  | (  <_> )  | \\/\\___  |        \r\n \\___  /  (____  /\\___  >__|  \\____/|__|   / ____|        \r\n     \\/        \\/     \\/                   \\/             \r\n                                                          \r\n                                                     ");