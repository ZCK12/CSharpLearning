For task 6, we’ll focus on further solidifying your understanding of loops in C#. We will combine loops with some of the concepts you've already learned like conditional statements and input validation.

Write a console application that generates a multiplication table for numbers. Your application should:

1. Ask the user to enter a number.
2. Validate the input to make sure it's a positive integer.
3. Ask the user for the range of the multiplication table (i.e., up to what number it should multiply).
4. Generate and display the multiplication table for the number up to the specified range.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to multiply: ");

        if (!int.TryParse(Console.ReadLine(), out int multiplier))
        {
            Console.WriteLine("Invalid input, please enter a whole number");
        } else if (multiplier < 0)
        {
            Console.WriteLine("Invalid input, number must be positive");
        }
        else
        {
            Console.WriteLine($"How many times should {multiplier} be multiplied? ");

            if (!int.TryParse(Console.ReadLine(), out int count))
            {
                Console.WriteLine("Invalid input, please enter a whole number");
            } else if (count < 1)
            {
                Console.WriteLine("Invalid input, number must be greater than 0");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{multiplier} x {i} = {multiplier*i}");
                }
            }
        }

    }
}
```

