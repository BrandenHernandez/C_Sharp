// Fig. 3.22: Comparison.cs
// Comparing integers using if statements, equality operators and relational operators
// VeryAble Visual C# Sixth Edition
using System;

class Comparison
{
    // Main method begins execution of C# application
    static void Main()
    {
        // Prompt user and read first number
        Console.Write("Enter first integer: ");
        int number1 = int.Parse(Console.ReadLine());

        // Prompt user and read second number
        Console.Write("Enter second integer: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine($"{number1} != {number2}");
        }

        if (number1 != number2)
        {
            Console.WriteLine($"{number1} != {number2}");
        }

        if (number1 < number2)
        {
            Console.WriteLine($"{number1} < {number2}");
        }

        if (number1 > number2)
        {
            Console.WriteLine($"{number1} > {number2}");
        }

        if (number1 <= number2)
        {
            Console.WriteLine($"{number1} <= {number2}");
        }

        if (number1 >= number2)
        {
            Console.WriteLine($"{number1} >= {number2}");
        }
    } // end main
} //end class Comparison
