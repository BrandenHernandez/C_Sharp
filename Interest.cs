// Fig. 6.6: Interest.cs
// Compound-interest calculations with for.
using System;

class Interest
{
    static void Main(string[] args)
    {
        decimal principal = 1000; // initialize amount before interest
        double rate = 0.05; // interest rate

        // display header
        Console.WriteLine("  Year         Amount on deposite");

        // Calculate amount on deposite for each of ten years
        for (int year = 1; year <= 10; ++year)
        {
            // calculate new amount for specified year
            decimal amount = principal *
                ((decimal)Math.Pow(1.0 + rate, year));

            // Display the year and the amount
            Console.WriteLine($"{year,4}{amount,20:C}");
        }
    }
// Thanks for looking
}
