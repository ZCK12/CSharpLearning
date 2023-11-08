Encapsulation is one of the four fundamental OOP concepts; the others are abstraction, polymorphism, and inheritance. In C#, encapsulation is used to restrict access to an object’s internal state and functionality. This is achieved by:

1. **Making fields private**: This prevents external entities from accessing the internal data of the class directly.
2. **Using methods or properties to access data**: Public methods or properties provide controlled access to the private data. These accessors (getters) and mutators (setters) can include validation logic to ensure data integrity.

Encapsulation provides several benefits in program design:

- **Data Hiding**: Only the necessary details are exposed while the internal implementation details are hidden. This prevents external interference and misuse of the object's internal state.
- **Loose Coupling**: Classes can be considered as separate entities with their own scopes and responsibilities. Changes in one class do not ripple through to others.
- **Increased Flexibility and Maintenance**: Internal changes to a class can be made without affecting other parts of the program that rely on the class. This makes the program more flexible and easier to maintain.
- **Control over Data**: By encapsulating the data, you can control what data is editable and what is read-only from outside the class.
- **Enhanced Testing**: Encapsulation often leads to a clearer, more organized design that is easier to test because each part of the program can be tested independently.

In C#, encapsulation informs design in such a way that each class is a well-defined capsule with specific public operations that it can perform. It becomes a self-contained module with its own responsibilities. This not only helps in creating a robust system by protecting objects from invalid states but also enhances the clarity and readability of the code, making it easier to understand, debug, and modify.