#  "BUILDER" design pattern

The **Builder** is a creational design pattern that allows us step-by-step construction of complex objects. Instead of creating an object directly, you use a builder to guide the construction process. This helps when the object you're building has many parts or configurations, allowing you to create different variations easily.

![Alt text](https://i.makeagif.com/media/10-03-2016/BZ9g6s.gif) 


## :octocat: Usage 
Imagine you want to build a house. You have different types of houses with various features like the number of rooms, type of roof, and flooring, and s.o. Instead of creating too many constructors, or create base "house" class and then it's subclasses for every possible variation, we can simply use builder dp, which will involve a 'HouseBuilder' that lets you specify these details step by step.


> To implement all of this, we need to:
> 
> - **Step 1**: Define the product - the complex object _(product - in u.c. "House")_ that you want to build.
> - **Step 2**: Define the builder interface ("_IHouseBuilder_"), that specifies methods
>  for creating the different parts of the Product objects.
> - **Step 3:** Create Concrete builders - Implement interface int concrete Builder classes that provide specific implementations of the building steps ("_HouseBuilder_").
> - **Step 4:** Define Director class to guide the construction process - The director guides the builder on how to build the product step by step. **_It's optional_**, cause client can control builders directly.
> - **Step 5:** Client code - In the client code, create an instance of the builder, and optionally the director. Use the builder's methods to set the configuration of the product. If a director is used, call its methods to construct the product.


In this example, **HouseDirector** guides the construction process, while **HouseBuilder** implements the builder interface ("_IHouseBuilder_") to build the House step by step. This way, we can easily create different types of houses by changing the builder without modifying the client code.

![](https://i.pinimg.com/originals/5d/7c/ce/5d7cced3d4039ffacbbde2fbce516cbc.gif)

## :fire: Problems Solved 
The Builder design pattern solves the problem of constructing complex objects with many configuration options in a clean and readable way. Here are some specific problems addressed by using the Builder pattern:

- **Too Many Constructor Parameters:** When a class has a large number of constructor parameters, it becomes challenging to remember the order or purpose of each parameter. The Builder pattern allows you to construct an object step by step, setting only the parameters you need, making the code more readable.

-  **Avoiding Telescoping Constructors:** Telescoping constructors (constructors with many parameters, leading to various combinations) can become unwieldy. With the Builder pattern, you can use a fluent interface or separate methods to set individual properties, making the code more concise and maintainable.

- **Easier Configuration of Optional Features:** When an object has optional features or parameters, setting them all in a constructor can be cumbersome. With the Builder pattern, you can choose to set only the properties you need, making the configuration process more intuitive.



___
:pushpin: Best way to understand BUILDER Design Pattern by **"Refactoring guru"**  -  [builder design pattern](https://refactoring.guru/design-patterns/builder "The best search engine for privacy").

