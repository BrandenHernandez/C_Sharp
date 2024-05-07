// (FormatException) FormatException.cs
/* Create an app that inputs miles driven and gallons used, and calculates miles per gallon.
 * The example should use exception handling to process the FormatExceptions that occur
 * when converting the input strings to double. If invalid data is entered, display a message
 * informing the user.
 */using System;

namespace FormatExceptions
{
	class FormatEx
	{
		// Enumeration with constants that represent the game status
		private enum Status { Continue, End, Repeat}

		static void Main(string[] args)
		{
			// Variables
			var miles = 0.00;
			var gallons = 0.00;
			var result = 0.00;
			Console.ForegroundColor = ConsoleColor.Yellow;

			// Let's begin
			Status appStatus = Status.Continue;

			// ---------------------------------------------------------------------------------------------------------------
			while (appStatus == Status.Continue || appStatus == Status.Repeat)
			{
				try
				{
					// Prompt user for miles
					Console.WriteLine("Please enter miles driven: \n");
					miles = double.Parse(Console.ReadLine());

					if (miles == 0.00)
					{
						Console.WriteLine("You didn't drive any miles?? O_o");
						appStatus = Status.Repeat;
					}
					else { appStatus = Status.Continue; }

					Console.WriteLine(); // New Line

					// Prompt user for gallons
					Console.WriteLine("Please enter gallons used: \n");
					gallons = double.Parse(Console.ReadLine());

					if (gallons == 0.00)
					{
						Console.WriteLine("You didn't use any gallons?? O_o");
						appStatus = Status.Repeat;
					}
					else { appStatus = Status.Continue; }
				}
				catch (FormatException fe)
				{
					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

					Console.WriteLine($"\nCrash Report: {fe.Message}\n");
					Console.WriteLine("Try entering the gallons and miles in actual numbers...\n");
					appStatus = Status.Repeat;

					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

				}
				catch (Exception ex)
				{
					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

					Console.WriteLine($"\nCrash Report: {ex.Message}.\n");
					appStatus = Status.Repeat;

					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");
					
				}

				// End loop
				if (appStatus == Status.Continue)
				{
					appStatus = Status.End;
				}
			}

			// ---------------------------------------------------------------------------------------------------------------

			try
				{
					// Math into result variable
					result = miles / gallons;
				}
				catch (DivideByZeroException dbze)
				{
					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

					Console.WriteLine($"\nCrash Report: {dbze.Message}\n");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

					Console.WriteLine($"\nCrash Report: {ex.Message}.\n");
				}

				// ---------------------------------------------------------------------------------------------------------------

				finally
				{
					// Output
					Console.WriteLine($"\n---------------------------------------------------------------------------------------------------------------\n");

					Console.WriteLine($"\n{gallons} Gallons per {miles} Miles = {result} miles per gallon(MPG). \n");

				}
		}
	}
// Thanks for looking
}
