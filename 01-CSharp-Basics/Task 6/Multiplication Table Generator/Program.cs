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