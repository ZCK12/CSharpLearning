Now that you're becoming more comfortable with C#, let's create a simple console-based calculator. This program will use arithmetic operators and also give you a chance to refine your input validation techniques.

Here's what the calculator should do:

1. Prompt the user to enter two numbers.
2. Ask the user to choose an operation (addition, subtraction, multiplication, division).
3. Perform the operation on the two numbers.
4. Display the result.
5. Handle division by zero as a special case.

```csharp
using System;

class Program
{
    static void Main()
    {
        double d1;
        double d2;

        while (true)
        {
            Console.WriteLine("Please enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out d1))
            {
                Console.WriteLine("Please enter a valid decimal number.\n");
            }
            else { break;}
        }

        while (true)
        {
            Console.WriteLine("Please enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out d2))
            {
                Console.WriteLine("Please enter a valid decimal number.\n");
            }
            else { break;}
        }

        bool valid = false;
        while (!valid)
        {
            Console.WriteLine("Please enter an operand to apply: ");
            string operand = Console.ReadLine();
            
            valid = true;
            switch (operand) {
                case "+":
                    Console.WriteLine($"{d1} {operand} {d2} = {d1 + d2}");
                    break;

                case "-":
                    Console.WriteLine($"{d1} {operand} {d2} = {d1 - d2}");
                    break;

                case "*":
                    Console.WriteLine($"{d1} {operand} {d2} = {d1 * d2}");
                    break;

                case "/":
                    if (d2 != 0)
                    {
                        Console.WriteLine($"{d1} {operand} {d2} = {d1 / d2}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                case "%":
                    Console.WriteLine($"{d1} {operand} {d2} = {d1 % d2}");
                    break;
                
                default:
                    Console.WriteLine("Please enter a valid operand (+, -, *, /, %)");
                    valid = false; 
                    break;
            }
        }
    }
}
```

