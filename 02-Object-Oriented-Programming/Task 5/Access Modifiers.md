C# provides several access modifiers to control the visibility and accessibility of classes and members (like fields, properties, methods). Here's a brief overview:

1. **public**: No restrictions on access level. Members declared public can be accessed from any other code in the same assembly or another assembly that references it. Use this when you want your member to be accessible from everywhere.

2. **private**: Access is limited to the containing type. This is the most restrictive access level and is used to hide the member from anything outside the class it is declared in. Use private to encapsulate details that should not be accessible to anything other than the class itself.

3. **protected**: Access is limited to the containing class or types derived from the containing class. Use protected when you want to allow a class's inheritors to use or override a member.

4. **internal**: Access is limited to the current assembly. It's like public but restricted to the current assembly, meaning no access from another assembly. Use internal when you want to allow access to members within the same assembly but not outside of it.

5. **protected internal**: Access is limited to the current assembly or types derived from the containing class. This is a combination of protected and internal where the member can be accessed from derived classes or any class within the same assembly.

6. **private protected**: Access is limited to the containing class or types derived from the containing class within the current assembly. This is a more restrictive version of protected internal, where the access is limited to derived classes in the same assembly.