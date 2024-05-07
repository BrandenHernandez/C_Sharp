// Ex. 5.31: Palindromes
// Write an app that reads in a five-digit integer
// and determines whether it is a palindrome.
// If it's not five digits long, display error message

using System;

class Palindromes
{
   static void Main(string[] args)
   {

        int palindrome = 0; // instatiate variable
        int reversed = 0;   // instatiate variable
        int remainder = 0;  // instatiate variable
        int placeHolder = 0; // instatiate variable

            // Prompt and read input from user
            Console.Write("Please enter a 5 digit number: ");
            palindrome = int.Parse(Console.ReadLine()); // place input into variable

            // Determine if input is a palindrome or not
            if (palindrome > 9999 && palindrome <= 111111)
            {
                
                placeHolder = palindrome; // exchange for the equation

                while (placeHolder > 0)
                {
                    // reverse 
                    remainder = placeHolder % 10; //for getting quotient by dividing with 10
                    reversed = reversed * 10 + remainder; // multiplying the sum with 10 and adding remainder
                    placeHolder = placeHolder / 10; //for getting remainder by dividing with 10 
                   
                }
                    if (palindrome == reversed)
                    {
                        Console.Write($"You entered {palindrome} which is a palindrome!\n"); // If it is
                    }
                    else
                    {
                        Console.Write($"You entered {palindrome} which is not a palindrome.\n"); // if it's not
                    }
            }
            // Error message and retry
            else if (palindrome < 9999 | palindrome >= 11111)
            {
                Console.Write("Please stick to only 5 digit numbers.");
                Console.WriteLine("\nTry again:\n ");

                // Prompt and read input from user
                Console.Write("Please enter a 5 digit number: ");
                palindrome = int.Parse(Console.ReadLine()); // place input into variable

                // Determine if input is a palindrome or not
                if (palindrome > 9999 && palindrome <= 111111)
                {

                    placeHolder = palindrome; // exchange for the equation

                    while (placeHolder > 0)
                    {
                        // reverse 
                        remainder = placeHolder % 10; //for getting quotient by dividing with 10
                        reversed = reversed * 10 + remainder; // multiplying the sum with 10 and adding remainder
                        placeHolder = placeHolder / 10; //for getting remainder by dividing with 10 

                    }
                    if (palindrome == reversed)
                    {
                        Console.Write($"You entered {palindrome} which is a palindrome!\n"); // If it is
                    }
                    else
                    {
                        Console.Write($"You entered {palindrome} which is not a palindrome.\n"); // if it's not
                    }
                }
            }
   }
    // Thanks for looking
}
