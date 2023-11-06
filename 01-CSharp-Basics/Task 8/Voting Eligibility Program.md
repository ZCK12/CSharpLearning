For Task 8, you'll create a simple program that checks if the user meets certain conditions to be eligible to vote. In this case, the user needs to be at least 18 years old and be a national of a specific country.

Here's how you can structure the program:

1. Prompt the user for their age.
2. Prompt the user for their nationality.
3. Check if the age is greater than or equal to 18 and if the nationality matches the specified country using relational (`>=`) and logical (`&&`) operators.
4. Output a message indicating whether or not the user is eligible to vote.

```csharp
using System;

class Program
{
    static void Main()
    {
        int age;

        while (true)
        {
            // Prompt for and read in the user's age
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                break;
            }
            Console.WriteLine("Please enter a valid age.\n");
        }

        // Prompt for and read in the user's nationality
        Console.Write("Enter your nationality: ");
        string nationality = Console.ReadLine().ToLower();

        // Check if the user is eligible to vote
        if (age >= 18 && nationality == "australian")
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}
```
