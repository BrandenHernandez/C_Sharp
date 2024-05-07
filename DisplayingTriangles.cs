// Ex. 6.15 DisplayingTriangles.cs
// Get the output to match the display in the book with only one * used in loops
using System;

class DisplayingTriangles
{
        static void Main(string[] args) // Starting point
        {

    // -------------------------------------------------------------------------------------------------
        for (int i = 1; i <= 4; i++) // First for loop for 4 triangles
            {
                if (i == 1 || i == 4) // Conditional OR since (a) & (d) are similar triangles
                {
                    for (int j = 1; j <= 10; j++) // Nested for loop incrementing j
                        Astrisk(i, j); // From method
                }
                else // for triangles (b) & (c)
                {
                    for (int j = 10; j > 0; j--) // Nested for loop decrementing j
                        Astrisk(i, j); // From method
                }
                Console.WriteLine(); // Next Line for space between triangles
            }
        }
    // -------------------------------------------------------------------------------------------------

        private static void Astrisk(int i, int j) // Astrisk method
        {
            if (i == 3 || i == 4)
                Space(j); // From method

            while (j > 0) // Until space runs out
            {
                Console.Write('*'); // The only astrisk statement
                j--;
            }
            Console.WriteLine(); // Next line for structure
        }
    // -------------------------------------------------------------------------------------------------

    private static void Space(int iterate) // Whitespace method
        {
            int space = 10 - iterate;
            while (space > 0)
            {
                Console.Write(' ');
                space--; // Post decrement
            }
        }
    // Thanks for looking
}
