using System;

namespace InheritLab
{
	// 	Create a class called DiceGame.cs that inherits the methods and attributes from Game.
	class DiceGame : Game
	{
		// Repeat steps 6 to 11 above but change everything to read “Dice” instead of “Cards.” For example: numberOfDice instead of numberOfCards etc.
		
		// Add another int to the DiceGame class called numberOfPlayers. For numberOfPlayers do the following:
		public static int numberOfPlayers;

		// Add a private int called numberOfDice
		private static int numberOfDice;

		//Constructor
		public DiceGame() { }

		// Create an overloaded constructor that takes an int and a string for arguments.
		public DiceGame(int numberOfDice, string name)
		{
			NumberOfDice = numberOfDice; // The int should initialize the numberOfDice(use the property to do this!)
			base.Name = name; // The string should initialize the name property of the base class
		}

		// b) Add the appropriate info to the overloaded constructor so the numberOfPlayers is initialized by the constructor.
		public DiceGame(int numberOfPlayers, int numberOfDice, string name)
		{
			NumberOfPlayers = numberOfPlayers;
			NumberOfDice = numberOfDice;
			base.Name = name;
		}

		// Create a property called NumberOfDice
		public static int NumberOfDice
		{
			get // Getter
			{
				return numberOfDice; // Return Statement
			}
			set // Setter
			{
				if (value >= 0 && value <= 1000) // In the “set” of the property make sure the numberOfDice is never less than 0 or greater than 1000
				{
					numberOfDice = value;
				}
			}
		}

		// a) Create a property
		public static int NumberOfPlayers
		{
			get // Getter
			{
				return numberOfPlayers; // Return Statement
			}
			set // Setter
			{
				if (value >= 0 && value <= 9) // Make sure number of players is never less than 0 and never greater than 9.
				{
					numberOfPlayers = value;
				}
			}
		}

		// Override the StartGame() method so it displays “You are playing “ (name of the game).
		public override void StartGame()
		{
			Console.WriteLine($"You are playing \"{Name}\"");
		}

		// Override the EndGame() method so it displays “The game “ (name of the game) “ is over!”
		public override void EndGame()
		{
			Console.WriteLine($"The game \"{Name}\" is over!");
		}

		// Override the ToString() method so that it returns the info from the base class and appends “with "numberOfDice" dice…” to the end.
		// So, when the ToString() method is called on a CardGame object the display may look like this:
		public override string ToString()
		{
			// c) Add the NumberOfPlayers to the ToString() method so it displays this information as well.
			return $"{base.ToString()} with {numberOfPlayers} players and {NumberOfDice} dice..."; //  “The game is Liar's Dice with 55 dice…”
		}
	}
// Thanks for looking
}
