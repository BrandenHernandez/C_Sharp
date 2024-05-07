// DatesTest.cs
// Creating and manipulating the dates object
// VeryAble 9-22-2017

using System;

class DatesTest
{
    static void Main()
    {
        // Prompt for, then read, input
        Console.Write($"\nEnter the month: ");
        int Month = int.Parse(Console.ReadLine());   // Month

        // Prompt for, then read, input
        Console.Write($"\nEnter the day: ");
        int Day = int.Parse(Console.ReadLine());     // Day

        // Prompt for, then read, input
        Console.Write($"\nEnter the year: ");
        int Year = int.Parse(Console.ReadLine()); ;  // Year

        //-----------------------------------------------------------------------------------------------------------------

        // Create an account object and assign it to an account
        Dates date = new Dates(Month, Day, Year);

        // Display the initial balance of each object
        Console.WriteLine(
            $"\n{date.DisplayDate}\n");

        // Thanks for looking
    }
}
