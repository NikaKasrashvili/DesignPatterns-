#  "PROXY" design pattern

The Proxy Design Pattern provides a surrogate or placeholder for another object to control access to it. It is used to create a representative object that controls access to another object, which may be remote, expensive to create, or in need of securing.


> Imagine you're staying at a luxury hotel. Instead of directly accessing certain services like booking a restaurant or arranging transportation, you communicate with the concierge. The concierge acts as a proxy, handling your requests and interacting with the appropriate services on your behalf. In this analogy:
> 
![](https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExczl0Yjd0enR5cjd0cjl6M2MzZzV4anl2ZWp2aWIxcmQ5bDBjdm9wMyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/xT0xev72goowcsULMA/giphy.gif)


## :octocat: Usage 

Here are some usage examples of the Proxy Design Pattern in various scenarios:

:pushpin: **Remote Object Access:** Use a proxy when you need to access a remote object.

:pushpin: **Resource Management:** Use a proxy when you need to control access to a resource that is expensive to create or in limited supply.

:pushpin: **Security:** Use it to improve code readability and maintainability by encapsulating complex logic behind a single interface.

:pushpin: **Logging/Performance Monitoring:** Use a proxy to add logging or performance monitoring without modifying the real subject.

In other words, use the **Proxy Design Pattern** when you want to control access to an object, either to add additional functionality or to manage resource usage.

It's particularly useful in scenarios where you want to defer the creation of an object until it's actually needed, or when you need to add security measures or logging without modifying the original object  (''**_A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object_** '').

![](https://media0.giphy.com/media/IeKgCDlpTqRQbZEhBF/giphy.gif?cid=ecf05e47qwd35de64vrqkqh1cqhza0isy8j5ijngc100l17r&ep=v1_gifs_related&rid=giphy.gif&ct=g)

## :fire: Implementation 

Steps to Implement the Proxy Design Pattern:

- **Step 1:**  Identify the interface that both the real subject and the proxy will implement.

- **Step 2:** Create a real subject class that implements the interface.

- **Step 3:** Create a proxy class that also implements the interface and holds a reference to the real subject.

- **Step 4:** Implement the proxy methods to control access to the real subject, adding any necessary logic (lazy initialization, security checks, etc.).

- **Step 5**: Use the proxy class in place of the real subject wherever needed.





___
:pushpin: Best way to understand Proxy Design Pattern by **"Refactoring guru"**  -  [Proxy DP](https://refactoring.guru/design-patterns/proxy     "The best search engine for privacy").
___

