Let's create a program that will act as a basic profile creator for a user. It will ask the user for several pieces of information, store them in variables, and then print out a summary.

```csharp
using System;

class Program
{
    static void Main()
    {
        // Ask for first name and last name
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();

        // Ask for age
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask for favorite number
        Console.Write("What's your favorite number? ");
        double favoriteNumber = Convert.ToDouble(Console.ReadLine());

        // Ask if they love C#
        Console.Write("Do you love C#? (yes/no): ");
        bool lovesCSharp = Console.ReadLine().Trim().ToLower() == "yes";

        // Print the summary
        Console.WriteLine("Profile Summary:");
        Console.WriteLine($"Name: {firstName} {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Favorite Number: {favoriteNumber}");
        Console.WriteLine($"Loves C#: {lovesCSharp}");
    }
}
```

For a real application, you would want to add error checking to handle incorrect inputs gracefully. For the sake of this exercise, you can assume that the user always inputs data in the correct format.

### New Concepts:
- [[Primitive Data Types]]
- [[In-line operations|In-line comparison and assignment]]
