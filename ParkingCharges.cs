// Ex. 7.8: ParkingCharges.cs
// Write an app that calculates and displays the parking charge for each customer.
// Display the charge for the current customer and should calculate and display the running total.
// Veryable -October Friday the 13th, 2017 TMCC
using System;

class ParkingCharge
{
	static void Main(string[] args)
	{
		// $2.00 minimum fee for up to 3 hours
		// Plus .50c/hour each hour, or part thereof, afterwards
		// Maximum charge of $10.00 in 24 hours

		double charges = 2.00; // Minimum
		double fee = 0.50; // Each hour thereafter, or part thereof
		double time = 0; // // Starting the timer
		double totalCost = 0; // Total charges
		double currentCost = 0; // Charges

		// Ask for number of cars in garage

		Console.Write("Enter the number of cars parked yesterday: ");
		int NUMBER_OF_CARS = int.Parse(Console.ReadLine());

		// Enter hours parked for each customer

		for (int count = 1; count <= NUMBER_OF_CARS; count++)
		{
			Console.Write("\nEnter hours parked for car #" + count + ": ");
			time = double.Parse(Console.ReadLine());
			currentCost = CalculateCharges(time, charges, fee); //most recent customer
			totalCost += currentCost; //Running total

			// Per customer
			Console.WriteLine($"\tRecent customer paid: {currentCost:C}");
		}

		
		// Calculate and display running total for all customers

		Console.WriteLine($"\nYesterday's receipts total: {totalCost:C}\n");

	}

	// Method CalculateCharges to determine the charge for each customer

	public static double CalculateCharges(double time, double charges, double fee)
	{
		double total = 0; // Charges

		if (time <= 3) // First 3 hours
		{
			total = charges; // $2.00
		}

		else if (time > 3 && time < 24) // After 3 hours but less than 24
		{
			total = charges + (time * fee - 1.5); // Calculate charge per hour plus the initial $2
		}
		
		else if (time >= 24) // If maxed out at 24 hours
		{
			total = 10.00; // Charge max at $10
		}

		return total;
	}
// Thanks for looking
}
