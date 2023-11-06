For task 4, let's create a simple C# console application that determines if a number entered by the user is positive, negative, or zero. This will involve taking input from the user, converting that input into a numerical value, and then using conditional statements to check the number and provide the appropriate output.
```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Give me a number: ");

            string userInput = Console.ReadLine();

            if (userInput.Trim().ToLower() == "quit")
            {
                break;
            }

            if (double.TryParse(userInput, out double num))
            {
                if (num > 0)
                {
                    Console.WriteLine($"The number {num} is positive.\n");
                }
                else if (num < 0)
                {
                    Console.WriteLine($"The number {num} is negative.\n");
                }
                else
                {
                    Console.WriteLine($"The number {num} is zero.\n");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid number.\n");
            }
        }
    }
}
```

#### In this Program:
- We use a [[For Loop|for loop]] to repeatedly ask the user for an input number.
- We use a [[The Break Statement|break statement]] to terminate the loop immediately when the use wants to quit.
- We use `double.TryParse` to attempt to parse the user's input into a double. It's a safe way to handle user input because it will not throw an exception if the input is not a valid number. Instead, it returns `false`.
- The `out double number` part is an out parameter that `TryParse` will fill with the parsed number if successful.
- Inside the `if` block, we check whether the number is greater than, less than, or equal to zero and print out the corresponding message.
