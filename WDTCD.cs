// Ex. 6.26: What Does This Code Do (WDTCD.cs)
/* Create a small app to display the 3 nested for loops. 
 * Create a second set of nested for loops that display the same * 
 * but change 5, 3, and 4 to three other int values of your choice */
using System;

class WDTCD
{
    static void Main(string[] args)
    {

        // ---------------------------------------------------------------------------------------------

        for (int i = 1; i <=5; ++i)
        {
            for (int j = 1; j <=3; ++j)
            {
                for (int k = 1; k <= 4; ++k)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // ---------------------------------------------------------------------------------------------

        for (int i = 1; i <= 6; ++i)
        {
            for (int j = 1; j <= 2; ++j)
            {
                for (int k = 1; k <= 10; ++k)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
// Thanks for looking
}
