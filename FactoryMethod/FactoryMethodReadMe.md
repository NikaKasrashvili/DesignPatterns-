#  "FACTORY METHOD" design pattern :convenience_store:


The **Factory Method** design pattern is a creational dp and allows us to define an interface for creating objects of a general base type (superclass), without specifying what subtype exactly will be created.
Objects returned by a factory method are often referred to as **_products_**.


## :octocat: Usage 

In real life, we might have a situation when we need to create objects, but we don't want to worry about the specific details of their creation. For example, in a video game, we might have different characters, and we use a factory to create them without dealing with the complexities of character creation.


> let's imagine you're in a toy factory. In this toy factory, you have different machines that make different types of toys. You have a machine for making cars, another for making dolls, and one for making robots. Now, you, as the boss, don't want to worry about how each toy is made every time you need to produce one. You just want to press a button and get the toy you want. That's where the Factory Design Pattern comes in handy.
> 
> The Factory Design Pattern is like having a special machine (the factory) that knows how to make different types of toys without you having to know all the details about how each toy is made. 
> 
> ![Alt text](https://media3.giphy.com/media/l4EoUs2JFgxnRQ5Zm/giphy.gif?cid=ecf05e47hrwtv9etfhiegnrp10y7uoytfac8s8pd4ubpo4ie&ep=v1_gifs_search&rid=giphy.gif&ct=g) 



## :fire: Pros and Cons of Factory DP :fire: 


The Factory Method design pattern comes with its own set of advantages and disadvantages. Let's explore the pros and cons:

- <strong> :+1: **Flexibility and Extensibility:** </strong> The Factory Method allows for creating objects without specifying the exact class of the object that will be created. This makes it easy to introduce new types of objects without modifying existing code.
- <strong> :+1: **Encapsulation:** </strong>The creation of objects is encapsulated within the factory method, hiding the implementation details from the client code. This promotes a clear separation between the client and the creation logic.
- :+1: <strong>  Subclassing: </strong>It promotes the use of subclasses to alter (change) or extend the creation process. Subclasses can override the factory method to provide a different implementation of object creation.
- :+1: <strong> Dependency Inversion: </strong> The Factory Method allows high-level components to depend on abstractions (like interfaces or abstract classes) rather than concrete implementations.


- :heavy_exclamation_mark::heavy_exclamation_mark:  <strong> Complexity: </strong> Introducing the Factory Method pattern can lead to an increase in the number of classes, especially if there are many types of products. This can make the codebase more complex and harder to understand.
-  :heavy_exclamation_mark::heavy_exclamation_mark:  <strong> Design Overhead: </strong> For simple scenarios, introducing the Factory Method pattern might be overkill. It adds extra layers of abstraction and complexity that may not be necessary in less complex systems.
-  :heavy_exclamation_mark::heavy_exclamation_mark:  <strong> Duplication: </strong> If similar creation logic is needed across multiple factory methods, there might be code duplication. This could happen when multiple factory methods have similar steps in creating objects.




## :key: KEY FACTORS
When using the Factory Method design pattern, there are several key factors to consider to ensure effective implementation:

:zap: **Define an Interface or Abstract Class:** Start by defining an interface or an abstract class that declares the factory method. This interface should represent the common interface for all the products that the factory will create. 

:zap: **Identify the Product Hierarchy:** Clearly define the hierarchy of products (objects) that the factory will be responsible for creating. Each product should implement the interface or extend the abstract class declared in the first step.

:zap: **Implement Concrete Product Classes:** Create concrete classes for each product within the hierarchy. These classes should implement the interface or extend the abstract class defined in the first step.

:zap: **Create the Factory Method:** Implement the factory method in the interface or abstract class. This method will be responsible for creating and returning instances of the concrete products. Subclasses will override this method to provide specific implementations for creating different products.

:zap: **Define Concrete Factories:** Create concrete factory classes that inherit from the interface or abstract class. Each concrete factory will implement the factory method to instantiate specific concrete product classes.

:zap: **Use Dependency Injection (Optional):** Consider using dependency injection to inject the appropriate factory into client classes. This promotes loose coupling and allows for easier testing and swapping of factory implementations.

:zap: **Return type:** The return type should typically be an interface or an abstract class that represents the common interface for all the products that the factory can create. 

___
:rocket: Best way to understand FACTORY METHOD Design Pattern by **"Refactoring guru"**  -  [Factory Method Design Pattern](https://refactoring.guru/design-patterns/factory-method "The best search engine for privacy"). \
:rocket: Another useful article about Factory DP  by **Eduard Ghergu** - [Factory Method PentaBlog](https://www.pentalog.com/blog/design-patterns/factory-method-design-pattern/ "The best search engine for privacy").




![](https://media1.giphy.com/media/XCxcmEQWxDdc8qsd2R/giphy.gif?cid=ecf05e477mbu26k7zxt2v7u6ansk024j4pwy4i9w51bkk81g&ep=v1_gifs_related&rid=giphy.gif&ct=g)