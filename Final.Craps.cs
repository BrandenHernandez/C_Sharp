/* PLACE ALL MENUS INTO A SINGLE METHOD!
    *(10 pts.) Demonstration and use should not exceed 10 minutes.
    *(10 pts.) All values in the program should be stored in variables. For instance if you need to use the number 10, it should be an int variable that has been initialized previously. Or if you need to use a sentence, it should be a string variable that was created previously.
    *(30 pts.) Somewhere in the program there needs to be an if/else, a switch construct, a for loop, and either a while or a do/while loop.
    *(10 pts.) You need to use a single dimensional array to store and display some part of the program.
    *(10 pts.) You need to use a multi-dimensional array to store and display some part of the game as well.
    *(30 pts.) You will need to use at least 1 additional class other than the class with the main method. The class needs to contain at least 3 different private members (variable/attribute) and public getter and setter properties for those members. You can add as many other methods as you want to the class as well, but you must show the default constructor and an overloaded constructor. (Feel free to use as many classes as you wish for other parts of the program!)
    *(25 pts.) There should be at least 3 methods included in the main class.
    *(5 pts.) Use the Random class somewhere to create and use a Random number.
    *(10 pts.) Use a static variable and a static method to access and change that variable somewhere in the code.
    *(10 pts.) The output for the program should be appropriate for its usage and must at least display the information in both arrays and information from or about the class that is created.
*/
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CrapsGame
{
    class Craps
    {
        // Variables -------------------------------------------------------------------------------------------------------------

        // Create random number generator for use in method RollDice
        private static Random randomNumbers = new Random(Guid.NewGuid().GetHashCode()); // Seeded random constructor

        // Enumeration with constants that represent the game status
        private enum Status { Continue, Won, Lost }

        // Maintain game status
        private static Status gameStatus = Status.Continue;

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

        private static int die1 = 0; // Initialize variable for first die
        private static int die2 = 0; // Initialize variable for second die
        private static int sum = 0; // Initialize variable for the sum of both dice
        private static int starter = 0; // Variable for the first scored point
        private static int myPoint = 0; // Point if no win or loss on first roll
        private static int response = 0; //Initiate variable for response
        private static int credit = 0; // Current credits
        private static int bet = 0; // Betting credits
        private static int wins = 0; // Initialize variable for wins
        private static int loses = 0; // initialize variable for loses
        private static string option = null; // To catch response from menus in string format

        public static void Main()
        {
            // // To display negative currencies (Thank you)
            NumberFormatInfo noParens = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1;

            // Dressing up the screen
            Console.Title = "Craps"; // Window title
            Console.BackgroundColor = ConsoleColor.Black; // Background
            Console.ForegroundColor = ConsoleColor.Yellow; // Text Color

            // populate a List of ints
            var earnings = new List<int>(); // Single dynamic array

            // Player Info --------------------------------------------------------------------------------------------------------

            // Prompt for, then read, input
            Console.Write($"\nPlease enter your first name: ");
            string firstName1 = Console.ReadLine();

            // Prompt for, then read, input
            Console.Write($"\nPlease enter your last name: ");
            string lastName1 = Console.ReadLine();

            // Create a player object and assign it to a player  -----------------------------------------------------------------
            Player player1 = new Player(firstName1, lastName1);

            // Display players names -----------------------------------------------------------------------------------------------
            Console.WriteLine($"\nHello {player1.Name}!\n");

            // Beginning -----------------------------------------------------------------------------------------------------------
            Menu(); // Display Menu

            // Begin
            if (response == 1) // Yes
            {
                Instructions(); // Start the game with Instructions method
            }
            else if (response == 2) // No
            {
                // Special Menu (Not repeated)
                Console.WriteLine("\nHow about now?\n1:Yes\n2:No\n3:Quit\n"); 
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
            else if (response == 3) // Quit
            {
                Console.WriteLine("\nMaybe another time then.");
            }

            // ------------------------------------------------- GAME ---------------------------------------------------------------------------
            
            while (response != 2 && response != 3) // Conditional AND
            {
                switch (response) // Check response as to various options
                {
                    case 1: // Yes
                        Menu(); // Display Menu

                        // Start Game -----------------------------------------------------------------------------------------------
                        if (response == 1) // Yes
                        {

                            // GameStatus can contain Continue, Won, or Lost
                            gameStatus = Status.Continue;

                            string nfi = credit.ToString("C0", noParens); // Creates negative format
                            Console.WriteLine($"\nCurrent credits equal {nfi}\n");
                            Console.WriteLine("\nHow much would you like to bet? ");
                            Console.Write("---> $"); // Where they enter their bet
                            string betting = Console.ReadLine(); // Place response into variable

                            // Exceptions will continue with last option chosen
                            try
                            {
                                bet = Int32.Parse(betting); // Convert string response to integer in variable
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nWe'll use your last betting price...\n"); // Catch all letters
                            }

                            Console.WriteLine($"\nYou're betting {bet:C}\n");

                            // Press enter to continue
                            Console.ReadLine();
                            counter = 0; // Fresh dice roll
                            int sumOfDice = RollDice(); // First roll of the dice

                            // Determine game status and point based on the roll
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

                            // Display won or lost message and add or subtract credits
                            if (gameStatus == Status.Won)
                            {
                                credit += bet; // Add bet to current credits

                                nfi = credit.ToString("C0", noParens); // Creates negative format
                                Console.WriteLine("\n\tYou win!\tWinner Winner Chicken Dinner!!\n");
                                Console.WriteLine($"You have {nfi} in credits");

                                earnings.Add(credit); // Add credit to earnings List
                                ++wins;

                                // Press enter to continue
                                Console.ReadLine();
                            }
                            else if (gameStatus == Status.Lost)
                            {
                                Console.WriteLine("\nYou lose.\n");
                                credit -= bet; // Subtract bet from current credits

                                nfi = credit.ToString("C0", noParens); // Creates negative format
                                Console.WriteLine($"You have {nfi} in credits");

                                earnings.Add(credit); // Add credit to earnings List
                                ++loses;
                            }

                            break; // From nested case
                        }
                        // Outer If/Else
                        else if (response == 2) // No
                        {
                            Console.WriteLine("\nMaybe Next Time");
                        }
                        else // Quit
                        {
                            Console.WriteLine($"\nGoodbye {player1.Name}.\n");
                        }

                        break; // From outter case
                    case 2: // Exit
                        Console.WriteLine($"\nGoodbye {player1.Name}.\n");
                        break;
                    case 3: // Help

                        Instructions(); // Instructions

                        break;
                }

                if (response != 2)
                {
                    Console.WriteLine("\nMain Menu:\n1:Play Again\n2:Exit\n3:Instructions\n4:Statistics\n");
                    Console.Write("---> "); // Where they enter
                    option = Console.ReadLine(); // Place response into variable

                    // Exceptions will continue with last option chosen
                    try
                    {
                        response = Int32.Parse(option); // Convert string response to integer in variable
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nWe'll take that as a yes...\n"); // Catch all letters
                    }

                    if (response == 3) // Help
                    {
                        Instructions(); // Instructions method
                        response = 1; // Loop back to game
                    }
                    else if (response == 4)
                    {
                        // Mulitideminsional array
                        int[,] stats = new int[,] { { wins }, { loses } };
                        int counted = 0; // Counting rounds for Statistics in Main Menu

        Console.WriteLine($"\tStatistics for {player1.Name}:");
                        foreach (var credit in earnings)
                        {
                            Console.WriteLine($"\n\tRound {counted + 1}:");// Display game count
                            string nfi = credit.ToString("C0", noParens); // Creates negative format
                            Console.Write($"\n\t{nfi}"); // Display credits at the end of game
                            if (credit < 1 && credit > -1) // If credits equal $0.00
                            {
                                Console.WriteLine(" Flat");
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                            ++counted; // Increase game count
                        }

                        Console.WriteLine("\n\n\tWins\tLoses:");
                        for (var row = 0; row < stats.GetLength(0); ++row)
                        {
                            // Loop through columns of current row
                            for (var column = 0; column < stats.GetLength(1); ++column)
                            {
                                Console.Write($"\t{stats[row, column]} ");
                            }
                        }

                        Console.WriteLine(); // Next line
                    }
                }
            }
            // Default
            Console.WriteLine($"\n Ok. Goodbye {player1.Name}.\n");
        }
        // ----------------------------------------------------- Methods -------------------------------------------------------------------

        private static int[] die = new int[2]; // Total number of Dice

        // Roll Dice Method
        // Roll dice, calculate sum and display results
        static int RollDice()
        {
            // Pick random die value
            die1 = randomNumbers.Next(1, 7); // First die roll
            die2 = randomNumbers.Next(1, 7); // Second die roll

            sum = die1 + die2; // Sum of die values

            
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
        
        // Game menu
        private static int Menu()
        {
            Console.WriteLine("\nReady to begin?\n1:Yes\n2:No\n3:Quit Game\n");
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

            return response;
        }

        // Read the instructions method
        private static void Instructions()
        {
            // Instructions
            Console.Write("\nINSTRUCTIONS:\t(press enter to continue)\n" + "\n");

            // Press enter to continue
            Console.ReadLine();

            // Instructions
            Console.Write($"\nYou will roll two dice. Each die has six faces, which contain one, two, three, four, five, and six spots, respectively.");

            // Press enter to continue
            Console.ReadLine();

            Console.Write("\nAfter the dice have come to rest, the sum of the spots on the two upward faces is calculated. ");

            // Press enter to continue
            Console.ReadLine();

            Console.Write("\nIf the sum is 7 or 11 on the first throw, you win. \nIf the sum is 2, 3, or 12 on the first throw (called \"craps\"), you lose (i.e. \"the house\" wins). ");

            // Press enter to continue
            Console.ReadLine();

            Console.Write("\nIf the sum is 4, 5, 6, 8, 9, or 10 on the first throw, that sum becomes your \"point.\" ");

            // Press enter to continue
            Console.ReadLine();

            Console.Write("\nTo win, you must continue rolling the dice until you \"make your point\" (i.e. roll that same point value). " +
               "\nYou lose by rolling a 7 before making your point.\n");

            // Press enter to continue
            Console.ReadLine();
        }
    }
    // Thanks for looking
}
