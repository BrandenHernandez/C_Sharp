// Ex. 3.25: Multiples.cs
/* Write an app that reads two integers, determines whether the first is a multiple of the second and display the results. */
// VeryAble Visual C# Sixth Edition
using System;

class Multiple
{
    // Main method begins execution of C# application
    static void Main()
    {
        // Prompt user and read first number
        Console.Write("Enter first integer: ");
        int number1 = int.Parse(Console.ReadLine()); // assign input to variable

        // Prompt user and read second number
        Console.Write("Enter second integer: ");
        int number2 = int.Parse(Console.ReadLine()); // assign input to variable

        bool multiple = (number1 % number2 == 0);

        Console.WriteLine($"\n{number1} is a mulitple of {number2}. True or False? \n{multiple}.\n");

    } // end main
} //end class Comparison
