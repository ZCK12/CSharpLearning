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