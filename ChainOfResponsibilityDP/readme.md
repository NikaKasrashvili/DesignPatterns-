#  "Chain of Responsibility" design pattern

The Chain of Responsibility pattern is a behavioral design pattern where a request is passed through a chain of handlers. Each handler has the capability to either handle the request or pass it to the next handler in the chain. The request travels through the chain until it is handled or until it reaches the end of the chain.


![](https://garrettzecker.files.wordpress.com/2016/02/fellowship.gif)

> In **"The Lord of the Rings,**" the Fellowship exemplifies the Chain of Responsibility pattern by distributing the burden of Frodo's quest among its members, allowing them to support and rely on each other as they face the challenges of their journey.

> - _**(Frodo Baggins)**_:
Frodo is entrusted with the responsibility of destroying the One Ring. He becomes the primary handler of this task.
> - _**The Fellowship:**_
The Fellowship is formed to support Frodo in his quest. Each member of the Fellowship contributes in their own way, forming a chain of responsibility to aid Frodo in his mission.
> - - _**Gandalf:**_ Initially, Gandalf takes the lead in guiding Frodo and the Fellowship, providing wisdom and magical support.
> -  - _**Aragorn:**_ As the heir to the throne of Gondor and a skilled warrior, Aragorn takes on the responsibility of protecting Frodo and leading the Fellowship when Gandalf falls in Moria.
> - - _**Legolas, Gimli, and Boromir:**_ They each contribute their skills in combat and provide support to the Fellowship as they journey towards Mordor.
> - and s.o.



## :octocat: Usage 

When to use "Chain of Responsibility" design pattern?! when :

:pushpin: You want to decouple senders and receivers of a request.

:pushpin: There are multiple objects that can handle a request, and the handler isn't known a priori.

:pushpin: You want to allow multiple objects to handle a request without explicitly specifying the receiver.

 You also may need to use it in scenarios like:
- Event handling systems where multiple listeners can handle an event.
- Logging systems where logs need to pass through multiple filters.
- Authorization systems where requests need to be processed by multiple layers of permission checks.

![](https://i.pinimg.com/originals/6c/a8/64/6ca86417bd74c408d9c6491325bf652c.gif)

## :fire: Implementation 

Steps to Implement the Chain of Responsibility Design Pattern:

- **Step 1:**  Identify the different types of handlers that will be part of the chain.

- **Step 2:** Create an interface for the handlers defining the method to handle requests and set the next handler.

- **Step 3:** Implement concrete handler classes that implement the handler interface.

- **Step 4:** In each concrete handler, implement the logic to handle requests and decide whether to pass the request to the next handler.

- **Step 5**: Set the next handler in each concrete handler.

- **Step 6**: Instantiate the handlers and set the chain by linking them together.

- **Step 7**: Send requests to the first handler in the chain.





___
:pushpin: Best way to understand Chain of Responsibility Design Pattern by **"Refactoring guru"**  -  [Chain of Responsibility DP](https://refactoring.guru/design-patterns/chain-of-responsibility     "The best search engine for privacy").
___

