// Ex. 3.17: Math.cs
/* Write an app that inputs three integers from the user and displays the 
 * sum, average, product, and determine smallest and largest of the numbers. */
// VeryAble Visual C# Sixth Edition
using System;

class Math
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

        // Prompt user and read third number
        Console.Write("Enter third integer: ");
        int number3 = int.Parse(Console.ReadLine()); // assign input to variable

        // Addition
        int sum = number1 + number2 + number3; // add numbers together

        Console.WriteLine($"\nSum is {sum}"); // display the sum

        // Average

        int average = sum / 3; // Find the avaerage by adding the numbers -n then dividing by -n

        Console.WriteLine($"Average is {average}");

        // Product

        int product = number1 * number2 * number3;

        Console.WriteLine($"Product is {product}");

        // Smallest to Largest

        // if greater than

        if (number1 > number2) // if 1 is bigger than 2
        {
            Console.Write($"{number1} > {number2}");
        }

        if (number2 > number3) // and if 2 is bigger than 3
        {
            Console.WriteLine($" > {number3}");
        }

        //else if equal to

        if (number1 == number2)
        {
            Console.WriteLine($"{number1} is equals to {number2}"); // if 1 equals 2
        }

        if (number2 == number3)
        {
            Console.WriteLine($"{number2} is equal to {number3}"); // if 2 equals 3
        }

        // else if less than

        if (number1 < number2)
        {
            Console.Write($"{number1} < {number2}"); // if 1 is less than 2
        }

        if (number2 < number3)
        {
            Console.WriteLine($" < {number3}"); // if 2 is less than 3
        }

    } // end main
} //end class Comparison
