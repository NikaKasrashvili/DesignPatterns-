using Singleton;

Console.WriteLine("Testing Singleton Design Pattern\n");

// method to create Singleton instance.
static void CreateSingletonInstance()
{
    SingletonClass singletonInstance = SingletonClass.GetInstance();
    Console.WriteLine($"Singleton instance ID: {SingletonClass.Id}");
}



Thread createInstanceForThread1 = new Thread(() =>
{
    CreateSingletonInstance();
});

Thread createInstanceForThread2 = new Thread(() =>
{
    CreateSingletonInstance();
});


// start execution of threads.
createInstanceForThread1.Start();
createInstanceForThread2.Start();

// Instruct main thread to wait for the completion of threads before proceeding further.
// The main thread will be blocked until threads finish their execution.
createInstanceForThread1.Join();
createInstanceForThread2.Join();

Console.WriteLine(
            "\n If Id's are the same, then singleton works fine"
        );


//booo
Console.WriteLine(" \n _________.__               .__          __                 \r\n /   _____/|__| ____    ____ |  |   _____/  |_  ____   ____  \r\n \\_____  \\ |  |/    \\  / ___\\|  | _/ __ \\   __\\/  _ \\ /    \\ \r\n /        \\|  |   |  \\/ /_/  >  |_\\  ___/|  | (  <_> )   |  \\\r\n/_______  /|__|___|  /\\___  /|____/\\___  >__|  \\____/|___|  /\r\n        \\/         \\//_____/           \\/                 \\/ \r\n    .___            .__                                      \r\n  __| _/____   _____|__| ____   ____                         \r\n / __ |/ __ \\ /  ___/  |/ ___\\ /    \\                        \r\n/ /_/ \\  ___/ \\___ \\|  / /_/  >   |  \\                       \r\n\\____ |\\___  >____  >__\\___  /|___|  /                       \r\n     \\/    \\/     \\/  /_____/      \\/                        \r\n__________         __    __                                  \r\n\\______   \\_____ _/  |__/  |_  ___________  ____             \r\n |     ___/\\__  \\\\   __\\   __\\/ __ \\_  __ \\/    \\            \r\n |    |     / __ \\|  |  |  | \\  ___/|  | \\/   |  \\           \r\n |____|    (____  /__|  |__|  \\___  >__|  |___|  /           \r\n                \\/                \\/           \\/        ");
