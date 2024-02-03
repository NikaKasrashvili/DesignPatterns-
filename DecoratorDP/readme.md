#  "Decorator" design pattern

The Decorator Design Pattern is a structural pattern that allows you to add new behaviors or functionalities to objects dynamically without altering their structure. It involves creating a set of decorator classes that are used to wrap concrete components.

![](https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExZW5qMHZxYWRndGtiMGhnMnF4bG00b2tubWdkOXNibHN4NHhkZzd0NyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/1iw6jEWBEbM9qScAjs/giphy.gif)


:zap: Think of a pizza as your base component. Now, you can add toppings (decorators) like cheese, pepperoni, or mushrooms dynamically without changing the pizza itself. Each added topping enhances the pizza's flavor, but the pizza remains a pizza.




## :octocat: Usage 

Here are some usage examples of the Decorator Design Pattern in various scenarios:

:pushpin: When you need to add or remove functionalities from objects dynamically.

:pushpin: When subclassing to extend functionality isn't practical or when you want to avoid a "class explosion" with too many subclasses.

:pushpin: When you need to add responsibilities to individual objects without affecting other objects of the same class.


## :fire: Implementation 

Steps to Implement the Bridge Design Pattern:

- **Step 1:**  _**Identify the base Component :**_ Define an interface or abstract class, that declares the common operations for base component (_like IPizzaComponent_).

- **Step 2:** _**Implement Concrete Component**_: Create concrete components implementing the base component. (_like "PizzaComponent"_).

- **Step 3:** **Create a base decorator class ** implementing the base component to maintain a reference to the wrapped component.

- **Step 4:** **Create concrete decorators** extending the base decorator class and adding additional functionalities.

- **Step 5**: Use decorators to wrap concrete components dynamically as needed.

![](https://media.tenor.com/HnU6sO1CANwAAAAM/do-you-like-my-decorations-christmas-tree.gif)



___
:pushpin: Best way to understand Decorator Design Pattern by **"Refactoring guru"**  -  [Decorator DP](https://refactoring.guru/design-patterns/decorator     "The best search engine for privacy").
___

