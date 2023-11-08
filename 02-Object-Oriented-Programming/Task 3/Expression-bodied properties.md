Expression-bodied members in C# are a syntactic feature that allows for more concise representation of members that can be implemented with a single expression. They use the `=>` syntax, which is sometimes referred to as a "lambda arrow", but in the context of expression-bodied members, it's used to define the body of the member. This feature was introduced in C# 6.

**Overview of Expression-bodied Syntax:**

- **Methods**: Instead of writing a method with a block of code, you can use an expression-bodied method if the method consists of a single statement that can be expressed as an expression.
- **Properties**: Getters and setters of properties can be simplified if they are simply returning a value or assigning a value without additional logic.
- **Constructors and Finalizers**: C# 7.0 extended expression-bodied members to constructors and finalizers, which can be used when their implementation is just one expression.
- **Indexers**: Just like properties, indexers can have their getters and setters simplified into single expressions.

**Use Cases:**

1. **Simple Property Getters/Setters**:
```csharp
public string Name
{
    get => _name;
    set => _name = value ?? throw new ArgumentNullException(nameof(value));
}
```

2. **Single-Expression Methods**:
```csharp
public double Square(double num) => num * num;
```

3. **Single-Line Constructors**:
```csharp
public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));
```

4. **Single-Expression Finalizers**:
```csharp
~Person() => Console.WriteLine("Finalizer called");
```

5. **Indexers**:
```csharp
public string this[int index] => _names[index];
```

**Advantages:**

- **Conciseness**: Reduces the boilerplate code, making it easier to read and write simple members.
- **Clarity**: Clearly indicates that the member does nothing more than return a value or execute a simple expression.
- **Maintainability**: Simplifies refactoring and understanding of code where the logic is straightforward.

Expression-bodied members are best used when the implementation is simple and fits in a single line of code. They keep the focus on the work being done rather than the ceremony of the method or property syntax. However, for more complex members with multiple statements or a need for clearer debugging, traditional block-bodied syntax is preferred.