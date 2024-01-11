#  "SINGLETON" design pattern

![Alt text](https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExZGM0YWVkNGRxY2xnb3QxaHF2c29tZmo5ZnZ6ZjBscWhoN2g0aG44ZiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/bT2lokItWQKwE/giphy.gif)

## :octocat: Usage 

What is the use of Singletons?

Singleton is a <strong>creational DP </strong> and is often used  when we need to have a single object that is responsible for some job, and it's shared by the whole application (*part of <em>Global state</em>).

> For example, Singleton can be used for logging service to ensure that all parts of application share the same logging instance.
> We don't want to have multiple objects that all try to access the same file. 
> Also, we can use a Singleton for managing a database connection to ensure that application uses a single database connection instance.

___

To understand it better, let's imagine a country where there is only one President. The President is responsible for making important decisions, representing the country, and managing various affairs.

Now, let's draw parallels (All of them are **Advantages** of this pattern) with the Singleton pattern: 
- <em><strong> Single Instance:</em></strong> 
  - There is only one President at any given time. This aligns with the Singleton pattern, where a class has only one instance.
- <em><strong> Global Point of Access: </em></strong> 
  - The President's Office serves as a global point of access for the entire country to interact with the President. Similarly, the Singleton pattern provides a single point of access to a particular instance throughout the application.
- <em><strong>Lazy Initialization: </em></strong> 
	- The President is elected and assumes office when needed. This aligns with lazy initialization in the Singleton pattern, where the instance is created only when it is first requested.
- <em><strong>Global State Management: </em></strong> 
	- The President's Office manages important state affairs for the entire country, such as making decisions, representing the country, and overseeing various functions. Similarly, the Singleton pattern is useful for managing global state and resources in an application.
- <em><strong>Thread Safety: </em></strong> 
    - The President's responsibilities are handled in a structured and organized manner, ensuring that decisions are made in a controlled environment. This is akin to implementing thread safety in the Singleton pattern to handle multiple threads accessing the instance concurrently.


## :fire: Cons of Singleton :fire: 


The Singleton design pattern, like any design pattern, has both advantages and disadvantages. Here are some cons of using the Singleton pattern:

- <strong> :earth_africa: GLOBAL STATE: </strong> Introduces a global state to the application, which can lead to tight coupling and reduce the testability of components. In short, the global state means that every class may access it, use it and possibly modify it.
- <strong> :rotating_light: TESTABILITY: </strong>Singleton instances can be difficult to test in isolation because they are often tightly integrated with other parts of the application.
- :pencil: <strong>  HARD TO EXTEND AND MODIFY: </strong>Singleton pattern can make it harder to extend and modify the codebase since it tightly couples the code to a specific instance.
- :couple: <strong> VIOLATES SINGLE RESPONSIBILITY  PRINCIPLE: </strong> If a Singleton is used to manage multiple responsibilities, it can violate the Single Responsibility Principle (one class should have only one reason to change). But the pattern solves two problems at the time: 1) Ensure that a class has just a single instance.  2) Provides a global access point to that instance. 
- <strong> :lock: CONCURRENCY AND LOCKING: </strong> Implementing a thread-safe Singleton can involve additional complexity, such as locking mechanisms, which may impact performance.




## :pushpin: Best Practices 
- **Consider Alternatives:** Evaluate whether a Singleton is the best solution for your specific use case. Sometimes dependency injection or other design patterns may be more suitable.
- **Dependency Injection:** Consider using dependency injection to provide instances where they are needed. Dependency injection can offer better testability and flexibility.
- **Minimize Global State:** If using a Singleton, try to minimize the global state it manages. Keeping the Singleton focused on one responsibility improves maintainability.
- **Use with Caution:** Use the Singleton pattern with caution, and only when truly necessary. Overuse of Singleton can lead to a rigid and inflexible design.


:zap: Best way to understand Singleton Design Pattern by "Refactoring guru"  -  [Singleton Design Pattern](https://refactoring.guru/design-patterns/singleton "The best search engine for privacy").

