using ChainOfResponsibilityDP;
using ChainOfResponsibilityDP.ConcreteHandlers;

#region Console

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Explanation:\nIn this example, we model the Fellowship of the Ring using the Chain of Responsibility pattern. " +
    "\nEach member of the Fellowship (Gandalf, Aragorn, Legolas) is a " +
    "\n handler responsible for handling specific threats encountered during their journey." +
    "\n\nGandalf: Handles the threat of the Balrog." +
    "\nAragorn: Handles the threat of Orcs." +
    "\nLegolas: Handles the threat of Uruk-hai." +
    "\nIf a threat matches the expertise of a member, they handle it." +
    "\nOtherwise, they pass it to the next member in the chain until it's handled or until there are no more members left to handle it. " +
    "\nThis mirrors the way the Fellowship operates in Tolkien's novels, " +
    "\nwhere each member contributes their skills to overcome various challenges \nthey face on their quest to destroy the One Ring.");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n - - Start testing of chain responsibility design pattern...");
Console.ForegroundColor = ConsoleColor.White;
#endregion

// Creating the fellowship
IFellowshipHandler gandalf = new Gandalf();
IFellowshipHandler aragorn = new Aragorn();
IFellowshipHandler legolas = new Legolas();

// Seting chain of handlers.
// It can be written in one line, but because of return type(void) in our case,
//    we have to write then on different lines. :( 
gandalf.SetNextFellow(aragorn);
aragorn.SetNextFellow(legolas);


// Handling threats : always start from the begining of chain!!!
gandalf.HandleThreat("Balrog appears!");
gandalf.HandleThreat("Orcs attack!");
gandalf.HandleThreat("Uruk-hai sighted!");
gandalf.HandleThreat("Nazgûl are coming!");


Console.WriteLine("\n_________ .__           .__                 _____                                     \r\n\\_   ___ \\|  |__ _____  |__| ____     _____/ ____\\                                    \r\n/    \\  \\/|  |  \\\\__  \\ |  |/    \\   /  _ \\   __\\                                     \r\n\\     \\___|   Y  \\/ __ \\|  |   |  \\ (  <_> )  |                                       \r\n \\______  /___|  (____  /__|___|  /  \\____/|__|                                       \r\n        \\/     \\/     \\/        \\/                                                    \r\n                                                   ._____.   .__.__  .__  __          \r\n_______   ____   ____________   ____   ____   _____|__\\_ |__ |__|  | |__|/  |_ ___.__.\r\n\\_  __ \\_/ __ \\ /  ___/\\____ \\ /  _ \\ /    \\ /  ___/  || __ \\|  |  | |  \\   __<   |  |\r\n |  | \\/\\  ___/ \\___ \\ |  |_> >  <_> )   |  \\\\___ \\|  || \\_\\ \\  |  |_|  ||  |  \\___  |\r\n |__|    \\___  >____  >|   __/ \\____/|___|  /____  >__||___  /__|____/__||__|  / ____|\r\n             \\/     \\/ |__|               \\/     \\/        \\/                  \\/     \r\n________                .__                                                           \r\n\\______ \\   ____   _____|__| ____   ____                                              \r\n |    |  \\_/ __ \\ /  ___/  |/ ___\\ /    \\                                             \r\n |    `   \\  ___/ \\___ \\|  / /_/  >   |  \\                                            \r\n/_______  /\\___  >____  >__\\___  /|___|  /                                            \r\n        \\/     \\/     \\/  /_____/      \\/                                             \r\n__________         __    __                                                           \r\n\\______   \\_____ _/  |__/  |_  ___________  ____                                      \r\n |     ___/\\__  \\\\   __\\   __\\/ __ \\_  __ \\/    \\                                     \r\n |    |     / __ \\|  |  |  | \\  ___/|  | \\/   |  \\                                    \r\n |____|    (____  /__|  |__|  \\___  >__|  |___|  /                                    \r\n                \\/                \\/           \\/                                     \r\n                                                                                      \r\n                                                                                      \r\n                                                                        ");