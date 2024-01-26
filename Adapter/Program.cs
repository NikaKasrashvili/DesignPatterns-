using AdapterDP;

Console.WriteLine("Testing Adapter design pattern.");

// Using the old system with the adapter
OldSystem oldSystem = new OldSystem();
INewSystem adapter = new Adapter(oldSystem);

// Using the new system with the adapted old system
NewSystem newSystem = new (adapter);
newSystem.PerformNewRequest();


Console.WriteLine(" \n  _____       .___              __                \r\n  /  _  \\    __| _/____  _______/  |_  ___________ \r\n /  /_\\  \\  / __ |\\__  \\ \\____ \\   __\\/ __ \\_  __ \\\r\n/    |    \\/ /_/ | / __ \\|  |_> >  | \\  ___/|  | \\/\r\n\\____|__  /\\____ |(____  /   __/|__|  \\___  >__|   \r\n        \\/      \\/     \\/|__|             \\/       ");