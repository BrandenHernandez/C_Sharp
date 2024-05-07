// Fig. 3.14: Addition.cs
// Displaying the sum of two nubers input from the keyboard
// VeryAble Visual C# Sixth Edition
using System;

class Addition
{
    // Main method begins execution of C# application
    static void Main()
    {
        int number1; // declare first number to add
        int number2; // declare second number to add
        int sum;     // declare sum of numbers 1 & 2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter socond integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2; // add numbers together

        Console.WriteLine($"Sum is {sum}"); // display the sum
    } // end Main
} // end class Addition
