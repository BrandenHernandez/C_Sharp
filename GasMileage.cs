/* Gas Mileage 
 Input miles driven, and gallons used, for each tank.
 Calculate and display MPG obtained for each tankful;
 display the combined MPG for all tankfuls up to this point.
 Use READLINE method and sentinel-controlled iteration. */

using System;


class GasMileage
{
   static void Main(string[] args)
   {
        // initialization phase
        int miles = 0; // initialize miles
        int totalMiles = 0; // initialize sum of miles
        int gallons = 0; // initialize gallons
        int totalGallons = 0; // initialize sum of gallons
        int counter = 1; // keep track of tanks

        // progressing phase ---------------------------------------------------------------------------
        Console.Write(
            "At anytime, enter -1 for both, to stop inputs and display combined MPG for all tankfuls.\n"
            ); // display instructions

        // loop until sentinel value is read from the user
        while (miles != -1)
        {
                // prompt for input and read gas from user
                Console.Write($"\nEnter miles driven for tank {counter}: ");
                miles = int.Parse(Console.ReadLine());

                // prompt for input and read gallons from user
                Console.Write($"Enter gallons used for tank {counter}: ");
                gallons = int.Parse(Console.ReadLine());

                // Caluclate miles per gallon (MPG)
                double average = (double)miles / gallons;

                // display current tank's MPG
                Console.Write($"Tank number {counter} had {average} miles per gallon.\n");

            if (miles != -1)
            {
                //  sum up the total for each
                totalMiles = totalMiles + miles; // add miles to the total count
                totalGallons = totalGallons + gallons; // add gallons to the total count
            }

            // display total up to this point
            Console.WriteLine($"Total thus far is {totalMiles} miles and {totalGallons} gallons");

                // increment counter
                counter = ++counter; // increments counter by 1
        }

        // terminate phase  ---------------------------------------------------------------------------
        // calculate total miles per gallon
        if (totalMiles != 0)
        {
            if (totalGallons != 0)
            {
                // use number with decimal point to calculate average of MPG
                double totalAverage = (double)totalMiles / totalGallons;

                // display the total and average (with two digits of precision)
                Console.WriteLine(
                    $"\nTotal number of miles driven is {totalMiles},"
                    + $" while total numbers of gallons used is {totalGallons}.");
                Console.WriteLine($"\nYour average MPG is {totalAverage:F}\n");
            }
        }
        else // nothing was entered, so output error message
        {
            Console.WriteLine("\nNothing was entered dummy. Please try again");
        }
    }
    // Thanks for looking
}
