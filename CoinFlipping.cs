// Ex. 7.29: CoinTossing.cs
/* Write an app that simulates coin tossing.
 * Count the number of times each toss shows per side
 */
using System;

class CoinTossing
{
	static void Main(string[] args)
	{

		int frequencyHeads = 0; // Count of Heads
		int frequencyTails = 0; // Count of Tails

		// Coin toss when user selects the "Toss Coin" option
		// prompt user for input to toss coin or not
		Console.Write("Toss coin? (1 = Yes, 2 = No): ");
		int start = int.Parse(Console.ReadLine());

		if (start == 1) //Toss Coin
		{
			// Flip coin 10,000 times
			for (int flip = 1; flip <=10000; ++flip)
			{
				int face = 0; // Initialize variable

				if (Flip() == true)
					{ face = 1; }
				else
					{ face = 2; }

				// Count number of flips per side
				switch (face)
				{
					case 1:
						++frequencyHeads; // Increment Heads count
						break;
					case 2:
						++frequencyTails; // Increment Tails count
						break;
				}
			}
			// Console Write
			Console.WriteLine("\nSide\tFrequency");
			Console.WriteLine($"Heads:\t{frequencyHeads}\nTails:\t{frequencyTails}\n");
		}

		else Console.Write("\nMaybe next time.\n");
		
	}

	// Method Flip w/no args and return per side
	private static bool Flip()
	{
		Random side = new Random(); // Random number generator
		int face = 1 + side.Next(0, 2); // 1 Heads; 2 Tails

		bool heads = true;
		bool tails = false;
		bool result = false;

		if (face == 1)
		{ result = heads; }
		else if (face == 2)
		{ result = tails; }

		return result;
	}
	// Thanks for looking
}
