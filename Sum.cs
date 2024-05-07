// Fig. 6.5: Sum.cs
// Summing integers with the for statement
using System;
class Program
{
   static void Main(string[] args)
   {
        int total = 0; // initialize total

        // total even inegers from 2 through 20
        for (int number = 2; number <= 20; number +=2)
        {
            total += number;
        }

        Console.WriteLine($"Sum is {total}"); // display results
   }
// Thanks for looking
}
