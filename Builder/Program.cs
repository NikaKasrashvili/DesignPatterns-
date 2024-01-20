
using Builder;
using Builder.ConcreteBuilders;

//Client Code.
Console.WriteLine("Processing of Builder design pattern.");

HouseDirector director = new HouseDirector();
HouseBuilder builder = new HouseBuilder();
director.HouseBuilder = builder;

//create modern house.
Console.WriteLine("Create modern house:");

director.BuildModernHouse();
var modernHouse = builder.BuildHouse().ListParts();

Console.WriteLine(modernHouse);

//create house with balcony
Console.WriteLine("House with balcony:");
director.BuildBalconyHouse();
var balconyHouse = builder.BuildHouse().ListParts();

Console.WriteLine(balconyHouse);

// Create house without Director class
Console.WriteLine("Create Custom house:");
builder.SetFlooringType("carpet");
builder.BuildBalcony();
builder.SetRooms(10);

var customHouse = builder.BuildHouse().ListParts();

Console.Write(customHouse);



Console.WriteLine("__________      .__.__       .___            \r\n\\______   \\__ __|__|  |    __| _/___________ \r\n |    |  _/  |  \\  |  |   / __ |/ __ \\_  __ \\\r\n |    |   \\  |  /  |  |__/ /_/ \\  ___/|  | \\/\r\n |______  /____/|__|____/\\____ |\\___  >__|   \r\n        \\/                    \\/    \\/     ");