Polymorphism is one of the core concepts in object-oriented programming, including C#. It comes from the Greek words "poly" (many) and "morph" (form) and refers to the ability of one interface to be used for different underlying forms (data types).

**Overview of Polymorphism:**

- **Ad-hoc Polymorphism**: Achieved through method overloading and operator overloading.
- **Subtype Polymorphism**: This is usually what is meant by polymorphism in the context of OOP, where a derived class can be treated as if it were an instance of its base class, most commonly seen with method overriding.
- **Parametric Polymorphism**: Achieved through generics, where code is written without mention of any specific type and thus can be used transparently with any number of new types.

**Implications for C# Program Structure:**

1. **Reusable Code**: Polymorphism allows methods to be written that can operate on objects of different classes. Base classes or interfaces can be defined with virtual methods, and derived classes can override these methods with specific implementations.

2. **Loose Coupling**: With polymorphism, C# programs can be designed to use references to base classes so that the code can work with any subclass. This makes the system more modular and easier to understand and maintain.

3. **Extensibility**: Systems designed with polymorphism can be easily extended by creating new classes that fit the expected interface. Existing code doesn't need to change to accommodate new types.

4. **Interchangeability**: Objects of different but related types can be treated the same way. For instance, a method that accepts a parameter of type `Shape` can work with any subclass such as `Circle`, `Rectangle`, etc.

5. **Dynamic Binding**: Polymorphism enables dynamic binding (or late binding), where the method that gets called isn’t determined until runtime. This is key in many design patterns, like the Strategy or Command patterns, where the concrete strategy or command is not known at compile-time.


In C# programming, polymorphism is typically implemented using:

- `virtual` and `override` keywords for method overriding.
- `interface` implementations where different classes implement the same interface.
- `abstract` classes and methods which define a common base with no implementation for certain methods, expecting derived classes to provide specific behavior.

When you design C# programs with polymorphism in mind, you aim for a structure that is flexible, modular, and adaptable to change, which is especially important as applications grow in complexity.