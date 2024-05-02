SOLID Principles:

1- Single Responsibility Principle (SRP): A class should have only one reason to change, meaning it should only do one
   thing. This helps in making classes easier to understand, maintain, and refactor.

2- Open/Closed Principle (OCP): Software entities should be open for extension but closed for modification. This means
   you should be able to add new functionality without changing existing code. You achieve this through inheritance,
   interfaces, and design patterns like the Strategy pattern.

3- Liskov Substitution Principle (LSP): Subtypes should be substitutable for their base types. In simpler terms, this
   means that objects of a superclass should be replaceable with objects of its subclasses without affecting the
   correctness of the program.

4- Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they don't use. Instead
   of having one big interface, break it into smaller, specific interfaces, tailored to the needs of clients.

5- Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules. Both should depend
   on abstractions. Abstractions should not depend on details; details should depend on abstractions. Essentially, this
   means depending on interfaces rather than concrete implementations.

Additional Concepts

- IOC (Inversion of Control):
  In traditional programming, your code is in control. You instantiate objects, call their methods, and manage their
  lifecycle. Inversion of Control means reversing this control. Instead of your code controlling the flow, the framework
  or container controls it. It achieves this by providing hooks or extension points where you plug in your code, and the   framework manages the execution.

- Dependency Injection (DI):
  Dependency Injection is a technique used to implement Inversion of Control. Instead of creating dependencies inside a
  class, you "inject" them from the outside. This makes classes more flexible, reusable, and easier to test because   dependencies can be easily swapped or mocked.

In simpler terms, imagine making a sandwich. Traditionally, you would gather all the ingredients yourself. But with Dependency Injection, someone else provides you with the ingredients. You just assemble them. IOC is like someone else dictating the order in which you assemble the sandwich, and DI is like someone else providing you with the ingredients.
