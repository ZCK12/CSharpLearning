This is a program that prints the first N numbers in the Fibonacci Sequence.
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the sequence: ");

        if (int.TryParse(Console.ReadLine(), out int count) && count > 0) 
        {
            Console.WriteLine();
            int value1 = 0; 
            int value2 = 1;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}: {value1}");
                value2 = value1 + value2;
                value1 = value2 - value1;
            }
        }
    }
}
```

The update in value1 and value2 implements a neat trick which removes the need for a temporary swap variable.