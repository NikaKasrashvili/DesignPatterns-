#  "PROTOTYPE" design pattern

The **Prototype** design pattern is a creational design pattern that deals with creating objects by copying an existing object, known as the **_prototype_**. 

>Think of a photocopy machine as an analogy. Instead of drawing the same picture again and again, you make a copy of an existing drawing using the photocopy machine. The original drawing is like the prototype, and the copied drawings are like the objects created through the prototype.

Instead of creating new objects using a constructor, we can clone an existing object, making the process more efficient.



## :octocat: Usage 


Let's imagine Tony Stark using the **Prototype** pattern to create different versions of Iron Man costumes. Each version may have slight variations, and rather than starting from scratch each time, Tony can use a prototype to clone and modify as needed.

![Alt text](https://i.gifer.com/7rZa.gif) 

 To implement all of this, we need to:
 
- Step 1: Define the **Prototype** **Interface** (_ICloneableMachine_): Create an interface that declares a "clone" method in it for cloning objects.
- Step 2: Create **Concrete Prototype Classes** and Implement the prototype interface in concrete classes that represent the objects you want to clone.
- Step 3: Create a **Client** (Tony Stark's Lab) Class: Write a client class that uses the prototype to create new objects by cloning.


In this example, the Prototype pattern is applied to Iron Man suits. Tony Stark can create various versions of the suits (Mark 42, War Machine, etc.) by cloning prototypes. The Assemble method represents the additional assembly logic specific to each suit. This approach allows Tony to efficiently create and customize Iron Man suits in his workshop.

![](https://i.pinimg.com/originals/d1/48/0f/d1480f5b80b9903dcd63bedfc048a8a0.gif)




___
:pushpin: Best way to understand PROTOTYPE Design Pattern by **"Refactoring guru"**  -  [Prototype DP](https://refactoring.guru/design-patterns/prototype "The best search engine for privacy").
___

