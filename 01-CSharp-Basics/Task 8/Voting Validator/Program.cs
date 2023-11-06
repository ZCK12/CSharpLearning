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
