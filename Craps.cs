//// Craps class simulates the dice game Craps
// VeryAble 11-16-2017
using System;

namespace craps
{
    class Craps
    {

        // Create random number generator for use in method RollDice
        private static Random randomNumbers = new Random();

        // Enumeration with constants that represent the game status
        private enum Status { Continue, Won, Lost}

        // Keep track of game plays
        private static int counter = 0;

        // Enumeration with constants that represent common rolls of the dice
        private enum DiceNames
        {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,
            YoLeven = 11,
            BoxCars = 12
        }

        // Place one game of Craps
        static void Main(string[] args)
        {
            int starter = 0; // Variable for the first scored point
            int myPoint = 0; // Point if no win or loss on first roll
            int response = 0; //Initiate variable for response

            Console.WriteLine("Menu:\n1:Start\n2:Quit\n3:Instructions\n");
            Console.Write("---> "); // Where they enter
            string option = Console.ReadLine(); // Place response into variable

            // Exceptions
            try
            {
                response = Int32.Parse(option); // Convert string response to integer in variable
            }
            catch (FormatException)
            {
                Console.WriteLine("\nPlease choose a number (1-3) fom the menu...\n"); // Catch all letters 
            }

            // Begin
            if (response == 1) // Start the game with instructions
            {
                // Instructions
                Console.Write("\nINSTRUCTIONS:\t(press enter to continue)\n" + "\nYou will roll two dice. Each die has six faces, which contain one, two, three, four, five, and six spots, respectively.");

                // Press enter to continue
                Console.ReadLine();

                Console.Write("After the dice have come to rest, the sum of the spots on the two upward faces is calculated. ");

                // Press enter to continue
                Console.ReadLine();

                Console.Write("If the sum is 7 or 11 on the first throw, you win. \nIf the sum is 2, 3, or 12 on the first throw (called \"craps\"), you lose (i.e. \"the house\" wins). ");

                // Press enter to continue
                Console.ReadLine();

                Console.Write("If the sum is 4, 5, 6, 8, 9, or 10 on the first throw, that sum becomes your \"point.\" ");

                // Press enter to continue
                Console.ReadLine();

                Console.Write("To win, you must continue rolling the dice until you \"make your point\" (i.e. roll that same point value). " +
                    "\nYou lose by rolling a 7 before making your point.\n");
            }

            while (response != 2)
            {
                
                switch (response) // Check response as to various options
                {
                    case 1: // Start
                        Console.WriteLine("\nReady to begin?\n");
                        Console.ReadLine();

                        // GameStatus can contain Continue, Won, or Lost
                        Status gameStatus = Status.Continue;

                        int sumOfDice = RollDice(); // First roll of the dice
                        
                        // Determine game status and point based on the first roll
                        switch ((DiceNames)sumOfDice)
                        {
                            case DiceNames.Seven: // Win with 7 on the first roll
                            case DiceNames.YoLeven: // Win with 11 on the first roll
                                gameStatus = Status.Won;
                                break;
                            case DiceNames.SnakeEyes: // Lose with 2 on the first roll
                            case DiceNames.Trey: // Lose with 3 on the first roll
                            case DiceNames.BoxCars: // Lose with 12 on the first roll
                                gameStatus = Status.Lost;
                                break;
                            default: // Did not win or lose, so remember point
                                gameStatus = Status.Continue; // The game is continuing
                                starter = myPoint = sumOfDice; // Remember the point
                                Console.WriteLine($"\nYour point is {myPoint}");
                                Console.ReadLine();
                                break;
                        }

                        // While game is not complete
                        while (gameStatus == Status.Continue) // Game is not won or lost
                        {
                            sumOfDice = RollDice(); // Roll the dice again

                            // Determine game status
                            if (sumOfDice == myPoint) // Win by making points
                            {
                                if (sumOfDice == starter)
                                {
                                    Console.WriteLine("\tYou did it!");
                                }
                                gameStatus = Status.Won; // Winner
                            }
                            else
                            {
                                // Lose by rolling 7 more points
                                if (sumOfDice == (int)DiceNames.Seven)
                                {
                                    gameStatus = Status.Lost;
                                }
                            }
                            Console.ReadLine();
                        }

                        // Display won or lost message
                        if (gameStatus == Status.Won)
                        {
                            Console.WriteLine("\n\tYou win!\tWinner Winner Chicken Dinner!!\n");

                            // Press enter to continue
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nYou loses.\n");
                        }

                        break;
                    case 2: // Exit
                        Console.WriteLine("\nGoodbye.\n");
                        break;
                    case 3: // Help
                            // Instructions
                        Console.Write("\nINSTRUCTIONS:\t(press enter to continue)\n" + "\nYou will roll two dice. Each die has six faces, which contain one, two, three, four, five, and six spots, respectively.");

                        // Press enter to continue
                        Console.ReadLine();

                        Console.Write("After the dice have come to rest, the sum of the spots on the two upward faces is calculated. ");

                        // Press enter to continue
                        Console.ReadLine();

                        Console.Write("If the sum is 7 or 11 on the first throw, you win. \nIf the sum is 2, 3, or 12 on the first throw (called \"craps\"), you lose (i.e. \"the house\" wins). ");

                        // Press enter to continue
                        Console.ReadLine();

                        Console.Write("If the sum is 4, 5, 6, 8, 9, or 10 on the first throw, that sum becomes your \"point.\" ");

                        // Press enter to continue
                        Console.ReadLine();

                        Console.Write("To win, you must continue rolling the dice until you \"make your point\" (i.e. roll that same point value). " +
                            "\nYou lose by rolling a 7 before making your point.\n \n");
                        break;
                }

                Console.WriteLine("Menu:\n1:Continue\n2:Exit\n3:Help\n");
                Console.Write("---> "); // Where they enter
                option = Console.ReadLine(); // Place response into variable
                
                // Exceptions will continue with last option chosen
                try
                {
                    response = Int32.Parse(option); // Convert string response to integer in variable
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease choose a number (1-3) fom the menu...\n"); // Catch all letters
                }
            }

            // Else
            Console.WriteLine("\nGoodbye.\n");
        }

        // Roll dice, calculate sum and display results
        static int RollDice()
        {
            // Pick random die value
            int die1 = randomNumbers.Next(1, 7); // First die roll
            int die2 = randomNumbers.Next(1, 7); // Second die roll

            int sum = die1 + die2; // Sum of die values

            // Display results of this roll
            Console.Write($"You rolled a {die1} and {die2} which equal {sum}");

            // Increase roll counter
            ++counter; 
            
            if (counter == 1)
            {
                // Find game names of sum
                switch (sum)
                {
                    case 7: // Win with 7 on the first roll
                        Console.Write(" a.k.a. Lucky number Sleven!\n");
                        break;
                    case 11: // Win with 11 on the first roll
                        Console.Write(" a.k.a. YoLeven!\n");
                        break;
                    case 2: // Lose with 2 on the first roll
                        Console.Write(" a.k.a. SnakeEyes\n");
                        break;
                    case 3: // Lose with 3 on the first roll
                        Console.Write(" a.k.a. Trey\n");
                        break;
                    case 12: // Lose with 12 on the first roll
                        Console.Write(" a.k.a. BoxCars\n");
                        break;
                    default: // everything else
                        Console.WriteLine(" "); // Next Line
                        break;
                }
            }

            //Return statement
            return sum; // Return sum of the dice
        }
    }
// Thanks for looking
}
