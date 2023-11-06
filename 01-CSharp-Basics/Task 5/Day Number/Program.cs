using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a day number between 1-7: ");
            if (!int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                Console.WriteLine("Invalid input, please enter a number.\n");
            }
            else if (1 > dayNumber | dayNumber > 7)
            {
                Console.WriteLine("Number must be between 1-7 inclusive.\n");
            }
            else
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine($"Day {dayNumber} is a Monday.\n");
                        break;

                    case 2:
                        Console.WriteLine($"Day {dayNumber} is a Tuesday.\n");
                        break;

                    case 3:
                        Console.WriteLine($"Day {dayNumber} is a Wednesday.\n");
                        break;

                    case 4:
                        Console.WriteLine($"Day {dayNumber} is a Thursaday.\n");
                        break;

                    case 5:
                        Console.WriteLine($"Day {dayNumber} is a Friday.\n");
                        break;

                    case 6:
                        Console.WriteLine($"Day {dayNumber} is a Saturday.\n");
                        break;

                    default:
                        Console.WriteLine($"Day {dayNumber} is a Sunday.\n");
                        break;
                }
            }
        }
    }
}