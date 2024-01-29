using BridgeDP;
using BridgeDP.Abstractions;
using BridgeDP.Implementations;

Console.WriteLine("Testing Bridge design pattern.\n");

Client client = new Client();

// Create instances of concrete implementations: EmailSender and SmsSender
IMessageSender emailSender = new EmailSender();
IMessageSender smsSender = new SmsSender();

AbstractMessage abstraction;

// send text via email.
abstraction = new ExtendedMessages(emailSender);    
client.ClientCode(abstraction, "That's one small step for man, one giant leap for mankind.");


// send text via sms.
abstraction = new ExtendedMessages(smsSender);
client.ClientCode(abstraction, "Booo!\n");



