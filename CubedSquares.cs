// Ex. 3.29: CubedSquares.cs
/* Write an app that calculates the squares and cubes of the numbers
 * from 0-10 and display the resulting values in table format.*/
// VeryAble Visual C# Sixth Edition
using System;

class CubedSquares
{
    // Main method begins execution of C# application
    static void Main()
    {

        int zero = 0;
        int one = 1;
        int two = 2;
        int three = 3;
        int four = 4;
        int five = 5;
        int six = 6;
        int seven = 7;
        int eight = 8;
        int nine = 9;
        int ten = 10;

        Console.WriteLine("\nnumber\tsqaure\tcube");
        Console.WriteLine($"0\t{zero * zero}\t{zero * zero * zero}"); //0
        Console.WriteLine($"1\t{one * one}\t{one * one * one}"); //1
        Console.WriteLine($"2\t{two * two}\t{two * two * two}"); //2
        Console.WriteLine($"3\t{three * three}\t{three * three * three}"); //3
        Console.WriteLine($"4\t{four * four}\t{four * four * four}"); //4
        Console.WriteLine($"5\t{five * five}\t{five * five * five}"); //5
        Console.WriteLine($"6\t{six * six}\t{six * six * six}"); //6
        Console.WriteLine($"7\t{seven * seven}\t{seven * seven * seven}"); //7
        Console.WriteLine($"8\t{eight * eight}\t{eight * eight * eight}"); //8
        Console.WriteLine($"9\t{nine * nine}\t{nine * nine * nine}"); //9
        Console.WriteLine($"10\t{ten * ten}\t{ten * ten * ten}\n"); //10

    } // end main
} //end class Comparison
