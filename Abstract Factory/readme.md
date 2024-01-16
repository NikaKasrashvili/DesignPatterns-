#  "ABSTRACT FACTORY" design pattern

The **Abstract Factory** design pattern is a creational dp and allows us to provides an interface for creating families of related or dependent objects.

![Alt text](https://24.media.tumblr.com/96aac8c2da5d1dc5d0f656ecfe24c37f/tumblr_mgf0nhnJzK1rknrf9o1_500.gif) 


## :octocat: Usage 

Alright, let's imagine you're in a transport factory! We have different types of transports to produce: cars, planes, and boats. Now, imagine that each type of transport has its own special parts, like wheels for cars, wings for planes, and sails for boats.

Now, the Abstract Factory design pattern is like a base machine that helps us make all these different transports without getting confused. Instead of having one machine for cars, another for planes, and another for boats, we have one base machine that can create the parts needed for all types of transports.


> To implement all of this, we need to:
>1. Abstract Class or Interface for **Abstract Factory** ("_IAbstractTransportFactory_").
>
>2. **Concrete Factories**, that implement abstract factory interface ("_CarFactory_", "_BoatFactory_", 
"_PlaneFactory_").
>
>3. **Abstract products** - Interfaces for all the products, that  each of concrete factory produce ("_IAbstractProductA_", "_IAbstractProductB_"). 
>
>4. **Concrete products** - implementing interface of abstract products ("_Car_", "_CarWheel_", "_Boat_", "_BoatSail_", "_Plane_", "_PlaneWings_").


In this example, _IAbstractTransportFactory_ is our base machine, and each concrete factory (e.g., CarFactory, PlaneFactory, BoatFactory) knows how to create a specific type of products.


## :fire: Abstract Factory vs. Factory Method: :fire: 


-  **Abstract Factory** is like a super factory that creates other factories. It provides an interface for creating families of related or dependent objects. In our example, Base Transport Factory is an abstract factory.

-  **Factory Method**, on the other hand, is more focused on creating one type of object. It defines an interface for creating an object, but the choice of the concrete class to be instantiated is deferred to the subclasses. In the example, the **_CreateProductA_** and **_CreateProductB_** method in each concrete factory serves as a factory method.





___
:pushpin: Best way to understand ABSTRACT FACTORY Design Pattern by **"Refactoring guru"**  -  [Abstract factory design pattern](https://refactoring.guru/design-patterns/abstract-factory "The best search engine for privacy").

