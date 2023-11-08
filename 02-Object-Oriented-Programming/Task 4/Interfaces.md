Interfaces in C# are contracts that define a set of methods and properties that implementing classes must contain. They are declared with the `interface` keyword and contain method and property signatures without any implementation details. The purpose of interfaces is to define capabilities that classes should have, without specifying how these capabilities should be implemented.

You use interfaces in C#:

1. **To Define a Contract**: When you want to specify a set of functionalities that a class must implement without dictating the implementation of those functionalities.

2. **For Loose Coupling**: They help in creating systems with loosely coupled components, which can be very beneficial when it comes to testing (like mock objects) or when you need to change the implementation without changing the client code.

3. **For Multiple Inheritance**: Since C# does not support multiple inheritance of classes, interfaces can be used to implement multiple inheritance-like behavior.

4. **To Provide Polymorphism**: Interfaces allow for polymorphic behavior where objects of different classes can be treated as objects of an interface type, providing flexibility in how objects are used.

5. **To Define Interoperability**: They are useful when creating APIs or libraries where you want to define a fixed set of actions that all implementing classes must be able to perform.

6. **For Plug-in Architectures**: When creating extensible applications where users can create plug-ins, interfaces provide a way to guarantee that the plug-ins will contain certain methods.

Consider using interfaces when you want to define the behavior that classes should have without constraining how the classes achieve that behavior. They are a key part of designing robust, scalable, and maintainable code in C#.