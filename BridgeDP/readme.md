#  "Bridge" design pattern

The Bridge Design Pattern is a structural pattern that decouples an abstraction from its implementation so that the two can vary independently. This pattern is useful when you want to avoid a permanent binding between an abstraction and its implementation.

![](https://img.wattpad.com/263308366e3e0b00b7564d2741727d4ff73915aa/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f776174747061642d6d656469612d736572766963652f53746f7279496d6167652f774b476f4b57793768354e4a2d773d3d2d313038333639373538332e313638373835353131643839343839643834303737373331363138352e676966)

Let's break it down:

:round_pushpin: **Abstraction**: This is a high-level layer (interface or abstraction), that defines the methods that clients can use. It doesn't have the implementation details, but delegates it's work to implementation layer.

:round_pushpin: **Implementor**: This is the interface that defines the actual implementation that the abstraction uses.

:round_pushpin: **Concrete Abstraction:** These are concrete classes that extend the abstraction and implement its methods.

:round_pushpin: **Concrete Implementor:** These are concrete classes that implement the implementor interface.


## :octocat: Usage 


Think of your electronic devices like smartphones and TVs. The remote control serves as the **abstraction**, providing buttons for various actions like power on/off, volume control, and channel selection. The actual device (smartphone or TV) is the implementor, which interprets these commands and performs the necessary actions. You can switch between devices (implementations) seamlessly with the same remote control (abstraction). Similarly, in software, the Bridge pattern allows you to switch between different implementations without changing the high-level abstraction.

![](https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExaDdmcWd2bWdpYW8xM2dleng2MjU4ZTlhYWJibTJvN3VwOTZweDRhYSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/8yQkI4Yecqn6/giphy.gif)

Here are some usage examples of the Bridge Design Pattern in various scenarios:

>:computer: **GUI Toolkit:**
> In a GUI toolkit, you might have different platforms (like Windows, macOS, Linux) and different GUI components (like buttons, text fields). The Bridge pattern can be used to separate the platform-specific code from the generic GUI components. The platform-specific code would be the implementor, and the GUI components would be the abstraction. This allows you to easily add support for new platforms without changing the GUI components.
> ___
> :floppy_disk: **Database Abstraction:**
In a database abstraction layer, you might have different databases (like MySQL, PostgreSQL, SQLite) and different types of queries (like SELECT, INSERT, UPDATE). The Bridge pattern can be used to separate the database-specific code (implementor) from the generic query interface (abstraction). This allows you to switch between different databases without changing the query interface.
>___
> :e-mail: **Messaging Systems:**
In a messaging system, you might have different messaging protocols (like SMTP, HTTP, MQTT) and different message formats (like JSON, XML, binary). The Bridge pattern can be used to separate the messaging protocols (implementor) from the message formats (abstraction). This allows you to switch between different protocols and formats without changing the messaging system itself.
![](https://y.yarn.co/dd8e1c8c-4eab-4ef6-9fb7-5e704d28bf0b_text.gif)

## :fire: Implementation 

Steps to Implement the Bridge Design Pattern:

- **Step 1:** Identify **Abstraction** (like _AbstractMessage_) and **Implementor** (like _IMessageSender_): Determine the high-level abstraction and the separate implementor interface.

- **Step 2:** Create **Implementor** Classes: Implement concrete implementor classes that conform to the implementor interface (like "_SmsSender_" and "_EmailSender_").

- **Step 3:** Create **Abstraction Classes**: Implement abstraction classes that have a reference to the implementor interface (like "_LongMessages_" and "_ShortMessages_").

- **Step 4:** Implement **Client** Code: Use the abstraction and implementor objects in client code, providing flexibility to switch implementations dynamically.

___
:pushpin: Best way to understand BRIDGE Design Pattern by **"Refactoring guru"**  -  [Bridge DP](https://refactoring.guru/design-patterns/bridge     "The best search engine for privacy").
___

