// See https://aka.ms/new-console-template for more information
using FacadeDP;

Console.WriteLine("Testing Facade Design pattern.\n");

//Using Facade design pattern, client don't need to initialize each system and call its functions

//Only thing client needs is to initialize CarFacade type object and call it's function,
//that unites all the systems that is needed to start the process.

CarFacade car = new CarFacade();
car.StartCar();

Console.WriteLine("___________                         .___                 \r\n\\_   _____/____    ____ _____     __| _/____             \r\n |    __) \\__  \\ _/ ___\\\\__  \\   / __ |/ __ \\            \r\n |     \\   / __ \\\\  \\___ / __ \\_/ /_/ \\  ___/            \r\n \\___  /  (____  /\\___  >____  /\\____ |\\___  >           \r\n     \\/        \\/     \\/     \\/      \\/    \\/            \r\n________                .__                              \r\n\\______ \\   ____   _____|__| ____   ____                 \r\n |    |  \\_/ __ \\ /  ___/  |/ ___\\ /    \\                \r\n |    `   \\  ___/ \\___ \\|  / /_/  >   |  \\               \r\n/_______  /\\___  >____  >__\\___  /|___|  /               \r\n        \\/     \\/     \\/  /_____/      \\/                \r\n__________         __    __                              \r\n\\______   \\_____ _/  |__/  |_  __________________  ____  \r\n |     ___/\\__  \\\\   __\\   __\\/ __ \\_  __ \\_  __ \\/    \\ \r\n |    |     / __ \\|  |  |  | \\  ___/|  | \\/|  | \\/   |  \\\r\n |____|    (____  /__|  |__|  \\___  >__|   |__|  |___|  /\r\n                \\/                \\/                  \\/");