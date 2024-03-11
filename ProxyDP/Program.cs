// See https://aka.ms/new-console-template for more information
using ProxyDP;

Console.WriteLine("Testing Proxy dp..\n");

// Client code uses the Proxy instead of the RealSubject
ISubject proxy = new Proxy();
proxy.Request();



Console.WriteLine("\n__________                                               \r\n\\______   \\_______  _______  ______.__.                  \r\n |     ___/\\_  __ \\/  _ \\  \\/  <   |  |                  \r\n |    |     |  | \\(  <_> >    < \\___  |                  \r\n |____|     |__|   \\____/__/\\_ \\/ ____|                  \r\n                              \\/\\/                       \r\n________                .__                              \r\n\\______ \\   ____   _____|__| ____   ____                 \r\n |    |  \\_/ __ \\ /  ___/  |/ ___\\ /    \\                \r\n |    `   \\  ___/ \\___ \\|  / /_/  >   |  \\               \r\n/_______  /\\___  >____  >__\\___  /|___|  /               \r\n        \\/     \\/     \\/  /_____/      \\/                \r\n__________         __    __                              \r\n\\______   \\_____ _/  |__/  |_  __________________  ____  \r\n |     ___/\\__  \\\\   __\\   __\\/ __ \\_  __ \\_  __ \\/    \\ \r\n |    |     / __ \\|  |  |  | \\  ___/|  | \\/|  | \\/   |  \\\r\n |____|    (____  /__|  |__|  \\___  >__|   |__|  |___|  /\r\n                \\/                \\/                  \\/ \r\n                                                       ");