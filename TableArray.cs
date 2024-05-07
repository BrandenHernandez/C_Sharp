/*Create a new console application that will use a 2 dimensional array. 
 * The array should be of type "int" and have 10 rows and 12 columns.
 * Pass the array to a method called "InitializeArray" and initialize each element with a random number between 1 and 1000. 
 * Then pass the array to a method called "SumArray" and display the sum of all the values in the array using Console.WriteLine(). 
 * Then pass the array to a third method called "DisplayArray". 
 * "DisplayArray" should display the array in a table format. 
 * There should be 10 rows and 12 columns.*/
using System;

namespace TableArray
{
	class TableArray
	{
		static void Main(string[] args)
		{
			int[,] array = new int[10,12]; // The array should be of type "int" and have 10 rows and 12 columns

			InitializeArray(array); // Random Numbers
            SumArray(InitializeArray(array)); // Add together
            DisplayArray(InitializeArray(array)); // Display table
		}
		// -------------------------------------------------------------------------
		private static int[,] InitializeArray(int[,] array) // Pass the array to a method called "InitializeArray"

		{
			Random rand = new Random(); //Random number

            for (int counter1 = 0; counter1 < 10;  ++counter1) // Outer loop
			{
				for (int counter2 = 0; counter2 < 12; ++counter2) // Nested loop
				{
					array[counter1, counter2] = rand.Next(1, 1000); // Initialize each element with a random number between 1 and 1000. 
				}
			}
			return array; // Return the array to use for other methods
		}
		// -------------------------------------------------------------------------
		private static void SumArray(int[,] array) // Then pass the array to a method called "SumArray"
		{
			int total = 0; // Initialize variable

			foreach (var number in array) // ForEach loop
			{
				total += number; // Add number to the total variable
			}
            
            // Display total
			Console.WriteLine($"The total is {total}\n"); // Display the sum of all the values in the array using Console.WriteLine().
		}
		// -------------------------------------------------------------------------
		private static void DisplayArray(int[,] array) // Then pass the array to a third method called "DisplayArray".
		{

            for (int first = 0; first < 10; first++) // Outer loop
            {
                for (int second = 0; second < 12; second++) // Nested loop
                {
                    Console.Write($"{array[first, second]}\t"); // "DisplayArray" should display the array in a table format. 
                }
                
                // Next line
                Console.WriteLine("");
            }
		}
	}
// Thanks for looking
}
