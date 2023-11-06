using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your favourite number: ");
        int favNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you love C#? (yes/no): ");
        bool isFavourite = Console.ReadLine().Trim().ToLower() == "yes";

        Console.WriteLine("Profile Summary:");
        Console.WriteLine($"Name: {firstName} {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Favorite Number: {favNumber}");
        Console.WriteLine($"Loves C#: {isFavourite}");
    }
}