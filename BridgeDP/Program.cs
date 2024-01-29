using BridgeDP;
using BridgeDP.Abstractions;
using BridgeDP.Implementations;

Console.WriteLine("Testing Bridge design pattern.\n");

Client client = new Client();

// Create instances of concrete implementations: EmailSender and SmsSender
IMessageSender emailSender = new EmailSender();
IMessageSender smsSender = new SmsSender();

AbstractMessage abstraction;

string shortMessage = "Boooo!";
string longMessage = "That's one small step for man, one giant leap for mankind.\n";

// send short and long text via email.
abstraction = new ShortMessages(emailSender);    
client.ClientCode(abstraction, shortMessage);

abstraction = new LongMessages(emailSender);
client.ClientCode(abstraction, longMessage);


// send text via sms.
abstraction = new ShortMessages(smsSender);
client.ClientCode(abstraction, shortMessage);

abstraction = new LongMessages(smsSender);
client.ClientCode(abstraction, longMessage);



//booo!
Console.WriteLine("__________        .__    .___              \r\n\\______   \\_______|__| __| _/ ____   ____  \r\n |    |  _/\\_  __ \\  |/ __ | / ___\\_/ __ \\ \r\n |    |   \\ |  | \\/  / /_/ |/ /_/  >  ___/ \r\n |______  / |__|  |__\\____ |\\___  / \\___  >\r\n        \\/                \\/_____/      \\/");