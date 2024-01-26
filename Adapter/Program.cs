using AdapterDP;

Console.WriteLine("Testing Adapter design pattern.");

// Using the old system with the adapter
OldSystem oldSystem = new OldSystem();
INewSystem adapter = new Adapter(oldSystem);

// Using the new system with the adapted old system
NewSystem newSystem = new (adapter);
newSystem.PerformNewRequest();

