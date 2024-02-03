using DecoratorDP.Components;
using DecoratorDP.Decorators;

Console.WriteLine("Testing Decorator design pattern.\n");


//create plain pizza
IPizzaComponent pizzaComponent = new PizzaComponent();
string plainPizzaDescription = pizzaComponent.GetDescription();
double plainPizzaCost = pizzaComponent.GetCost();
Console.WriteLine(plainPizzaDescription + $", cost: {plainPizzaCost}$\n");

//add some cheeze using cheese decorator
IPizzaComponent cheesePizza = new CheeseDecorator(pizzaComponent);
string pizzaWithCheeseDescription = cheesePizza.GetDescription();
double pizzaWithCheeseCost = cheesePizza.GetCost();
Console.WriteLine(pizzaWithCheeseDescription + $", cost: {pizzaWithCheeseCost}$\n");


// add pepperoni to the cheese pizza
IPizzaComponent pepperoniPizza = new PepperoniDecorator(cheesePizza);
string pizzaWithCheeseAndPepperoniDescr = pepperoniPizza.GetDescription();
double pizzaWithCheeseAndPepperoniCost = pepperoniPizza.GetCost();
Console.WriteLine(pizzaWithCheeseAndPepperoniDescr + $", cost: {pizzaWithCheeseAndPepperoniCost}$\n");



Console.WriteLine("________                                    __                \r\n\\______ \\   ____   ____  ________________ _/  |_  ___________ \r\n |    |  \\_/ __ \\_/ ___\\/  _ \\_  __ \\__  \\\\   __\\/  _ \\_  __ \\\r\n |    `   \\  ___/\\  \\__(  <_> )  | \\// __ \\|  | (  <_> )  | \\/\r\n/_______  /\\___  >\\___  >____/|__|  (____  /__|  \\____/|__|   \r\n        \\/     \\/     \\/                 \\/                  ");
