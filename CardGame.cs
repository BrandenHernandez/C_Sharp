using System;

namespace InheritLab
{
	// Add a class to the project called CardGame.cs 
	// Have it inherit the methods and attributes from "Game"
	class CardGame : Game, IShuffle // Add an Interface to your project called “IShuffle”.
	{
		// Add a private int called numberOfCards
		private int numberOfCards;

		// Create a property called NumberOfCards
		public int NumberOfCards
		{
			get // Getter
			{
				return numberOfCards; // Return Statement
			}
			set // Setter
			{
				if (value >= 0 && value <= 1000) // In the “set” of the property make sure the numberOfCards is never less than 0 or greater than 1000
				{
					numberOfCards = value;
				}
			}
		}

		// Create an overloaded constructor that takes an int and a string for arguments.
		public CardGame(int numberOfCards, string name)
		{
			NumberOfCards = numberOfCards; // The int should initialize the numberOfCards(use the property to do this!)
			base.Name = name; // The string should initialize the name property of the base class
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

		// Override the ToString() method so that it returns the info from the base class and appends “ “with numberOfCards cards…” to the end.
		// So, when the ToString() method is called on a CardGame object the display may look like this:
		public override string ToString()
		{
			return $"The game is \"{Name}\" with {NumberOfCards} cards..."; //  “The game is Solitaire with 52 cards…”
		}

		// Implement the ShuffleCards method in the proper derived class. 
		// Use a loop to display the word “Shuffle…” equal to the number of times that the int passed to the method indicates.
		public void ShuffleCards(int times)
		{
			for (int x = 0; x < times; ++x)
			{
				Console.WriteLine("Shuffle...");
			}
		}
	}
	// Thanks for looking
}
