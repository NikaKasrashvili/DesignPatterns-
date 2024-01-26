#  "Adapter" design pattern

The Adapter pattern allows incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces by converting the interface of a class into another interface that a client expects.

![](https://media0.giphy.com/media/v1.Y2lkPTc5MGI3NjExcG8wa3N2amd6bWVrNDJtNnRwcnBldzAxYmR4NTdsOWJyazhhd3lhbyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/WOwga1cShSvuw/giphy.gif)

## :octocat: Usage 


Let's imagine we have a device that uses a specific type of plug, but the socket in our wall has a different type of outlet. An adapter is like the plug converter that allows our device to connect to the socket, even though the plug and the socket are originally incompatible.

 To implement Adapter, we need to:
 
- Step 1: **Identify Incompatibility**: Determine the interfaces or classes in your system that are incompatible and need to be adapted to work together.

- step 2:  Define **Target Interface**: Create an interface that represents the expected interface that the client code will interact with. This is often called the "target" interface.
- Step 3: **Implement Adaptee**: Create a class or classes that provide the functionality you want to adapt. These are often referred to as the "adaptee."
- Step 4: Create **Adapter** Class: Implement a new class, the "adapter," that bridges the gap between the target interface and the adaptee. The adapter class should implement the target interface and internally use an instance of the adaptee to delegate calls and perform necessary conversions.
- step 5: Implement Adapter Methods: Inside the adapter class, implement methods that correspond to the target interface's methods. These methods should delegate calls to the adaptee's methods, possibly performing any necessary conversions or adaptations.

![](https://pa1.aminoapps.com/6523/cecb22438ee5db8fe9051603ec81e25160c4640d_hq.gif)


___
:pushpin: Best way to understand ADAPTER Design Pattern by **"Refactoring guru"**  -  [Adapter DP](https://refactoring.guru/design-patterns/adapter     "The best search engine for privacy").
___

