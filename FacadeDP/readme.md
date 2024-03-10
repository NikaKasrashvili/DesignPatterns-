#  "FACADE" design pattern

The Facade Design Pattern is a structural design pattern that provides a simplified interface to a complex system of classes, interfaces, or subsystems. It hides the complexities of the underlying system and provides a single interface to interact with it. This pattern promotes loose coupling between client code and the subsystems by providing a unified interface, making it easier to use and understand.

![](https://media4.giphy.com/media/l2JdSlA1a1zKVAyze/giphy.gif?cid=ecf05e47fszttqdghkn7qrbf31u1akie5m7acb7hq55ay21v&ep=v1_gifs_related&rid=giphy.gif&ct=g)

:zap:  **Real-life Examples:** 
- Computer Startup: When you turn on your computer, you interact with a simplified interface (power button) that internally performs complex operations to start various subsystems like the CPU, memory, and peripherals.
- Home Entertainment System: A remote control for a home theater system provides a simple interface to control various complex subsystems such as the TV, sound system, and DVD player.



## :octocat: Usage 

Here are some usage examples of the Facade Design Pattern in various scenarios:

:pushpin: Use the Facade pattern when you need to provide a simple interface to a complex system or set of interfaces.

:pushpin: Use it to reduce dependencies between client code and subsystems, promoting loose coupling.

:pushpin: Use it to improve code readability and maintainability by encapsulating complex logic behind a single interface.


## :fire: Implementation 

Steps to Implement the Facade Design Pattern:

- **Step 1:**  Identify a complex system with multiple subsystems.

- **Step 2:** Create a Facade class that encapsulates the interactions with these subsystems.

- **Step 3:** Inside the Facade class, instantiate and manage instances of the subsystems.

- **Step 4:** Define methods in the Facade class to provide a simplified interface to the client code.

- **Step 5**: Client code should interact only with the Facade class, hiding the complexities of the subsystems.





___
:pushpin: Best way to understand Facade Design Pattern by **"Refactoring guru"**  -  [Facade DP](https://refactoring.guru/design-patterns/facade     "The best search engine for privacy").
___

