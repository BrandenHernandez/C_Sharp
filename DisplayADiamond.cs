// Ex.6.23: DisplayingADiamond.cs
// Write an app that displays a diamond shape using one astrick statement
using System;

class DisplayingADiamond
{
     static void Main(string[] args)
     {
        // Top -----------------------------------------------------------------------------------------
        int top = 4; // Variable

        for (int k = 1; k <= 5; k++)
        {
            for (int i = 1; i <= top; i++)
            {
                space();
            }
            
            top--; // Post decrement

            for (int i = 1; i <= 2 * k - 1; i++)
            {
                write();
            }
            // Next Line
            next();
        }
        // Bottom --------------------------------------------------------------------------------------
        int bottom = 1; // Change Variable

        for (int k = 1; k <= 5 - 1; k++)
        {
            for (int i = 1; i <= bottom; i++)
            {
                space();
            }

            bottom++; // Post increment

            for (int i = 1; i <= 2 * (5 - k) - 1; i++)
            {
                write();
            }
            // Next Line
            next();
        }
     }
    // Methods -----------------------------------------------------------------------------------------

    private static void write() // Astricks method
    {
        Console.Write("*"); // Single astrisk statment
    }

    private static void space() // Spaces method
    {
        Console.Write(" "); // Single space statment
    }

    private static void next() // NextLine method
    {
        Console.WriteLine(""); // Single nextLine statment
    }
// Thanks for looking
}
