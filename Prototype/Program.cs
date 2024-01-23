using Prototype;
using Prototype.PrototypeClasses;

Console.WriteLine("Processing of Prototype design pattern.\n");

// Creating a prototype (original object)
Console.WriteLine("Starting creating machines.\n");

Mark42 originalMark42 = new Mark42(183, 5);
WarMachine originalWarMachine = new WarMachine("goverment", 120);


// Creating a client
Client client = new Client();

// Creating a new object by cloning the prototype
ICloneableMachine clonedMark42 = client.CloneMachine(originalMark42);
ICloneableMachine clonedWarMachine = client.CloneMachine(originalWarMachine);


originalMark42.StartEngine();
clonedMark42.StartEngine();

originalWarMachine.StartEngine();
clonedWarMachine.StartEngine();



Console.WriteLine("__________                __          __                         \r\n\\______   \\_______  _____/  |_  _____/  |_ ___.__.______   ____  \r\n |     ___/\\_  __ \\/  _ \\   __\\/  _ \\   __<   |  |\\____ \\_/ __ \\ \r\n |    |     |  | \\(  <_> )  | (  <_> )  |  \\___  ||  |_> >  ___/ \r\n |____|     |__|   \\____/|__|  \\____/|__|  / ____||   __/ \\___  >\r\n                                           \\/     |__|        \\/");