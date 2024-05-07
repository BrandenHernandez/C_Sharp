// Declare an array of strings with the size of 12. Insert 12 different strings into the array. 
// In a foreach loop display the contents of the array to the console.

using System;


namespace ForEachString
{
	class ForEachString
	{
		static void Main(string[] args)
		{
			string sentence = null;
			string[] array = { "A", "foreach", "loop", "displays", "the", "contents", "of", "the", "array", "to", "the", "console." };

			foreach (string words in array)
			{
				sentence += words + " ";
			}

			Console.WriteLine($"{sentence}\n");
		}
	}
// Thanks for looking
}
