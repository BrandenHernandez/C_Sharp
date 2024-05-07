/*  Declare an array of doubles with the size of 25. 
 *  Pass the array to a method called InitializeArray. 
 *  In this method give all of the doubles in the array a value that is not equal to the default value. 
 *  Then pass the array to another method called DisplayArray. 
 *  In this array display all of the values to the console using a for loop.*/

using System;

class DisplayAnArray
{
	static void Main(string[] args)
	{
		// Create array
		var array = new double[25]; // Declare an array of doubles with the size of 25

		// Initialize array
		InitializeArray(array); // Pass the array to a method called InitializeArray

		// Display array
		DisplayArray(array); // Pass the array to another method called DisplayArray
	}

// ------------------------------------------------------------------------------------------------------------------------------------------------

	// Initialize method
	private static void InitializeArray(double[] array)
	{
		for (var counter = 0; counter < array.Length; ++counter)
		{
			array[counter] = counter * 4 + 1; // In this method give all of the doubles in the array a value that is not equal to the default value
		}
	}

	// Display method
	private static void DisplayArray(double[] array)
	{
		for (var counter = 0; counter < array.Length; ++counter)
		{
			Console.WriteLine($"The elements in {counter + 1} are {array[counter]}"); // Display all of the values to the console using a for loop
		}
	}
// Thanks for looking
}
