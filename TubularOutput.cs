// Ex. 5.22: Tubular Outputs
// Write an app that uses looping to display the a tabular table

using System;

namespace TabularOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1; // initiate variable

            // Display header
            Console.WriteLine("N\t10*N\t100*N\t1000*N\n");

            // Loop to display the tabular outputs
            while (n != 6)
            {
                Console.WriteLine($"{n}\t{n * 10}\t{n * 100}\t{n * 1000}"); // Equation

                ++n; // increment N
            }

            // Clean up the screen
            Console.Write("\n");
        }
    }
    // Thanks for looking
}
