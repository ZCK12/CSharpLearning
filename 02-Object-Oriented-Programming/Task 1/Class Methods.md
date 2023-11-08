Class methods in C#, also known simply as methods, are blocks of code that perform actions. They are defined within a class and can do almost anything: calculate values, initiate actions, read or write data, create objects, and so forth. Here's a brief overview of key points about class methods:

### Defining Methods

A method in a C# class is defined with an access modifier, a return type, a name, and parameters (if any). Here's the syntax:
```csharp
public returnType MethodName(parameterList)
{
    // Method body
}
```

- **Access Modifier**: Determines the visibility of the method to other classes (`public`, `private`, `protected`, `internal`, `protected internal`).
- **Return Type**: Specifies the type of value the method returns. If no value is returned, the return type is `void`.
- **Method Name**: The name of the method, following C# naming conventions.
- **Parameters**: Optional list of arguments that the method expects when it is called.

### Calling Methods

To call a method, you use the dot (`.`) operator on an instance of the class (or the class name for static methods) followed by the method name and any necessary arguments.

### Static vs Instance Methods

- **Instance Methods**: These operate on instances of a class. They have access to instance fields and properties.
- **Static Methods**: These belong to the class itself rather than any particular object. They can only access static members of the class.

### Method Overloading

You can have multiple methods in the same class with the same name but different parameter lists. This is known as overloading. The compiler differentiates them by their signature (method name and parameter types).

### Methods with Variable Number of Arguments

Methods can be defined to accept a variable number of arguments using the `params` keyword.

### In summary 

Methods are fundamental to the operation of classes in C#, encapsulating code for reuse and functionality, and they are a core part of implementing behaviors in object-oriented programming.