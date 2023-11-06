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
                Console.WriteLine("Invalid number, please enter a valid decimal number.\n");
            }
            else { break;}
        }

        while (true)
        {
            Console.WriteLine("Please enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out d2))
            {
                Console.WriteLine("Invalid number, please enter a valid decimal number.\n");
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