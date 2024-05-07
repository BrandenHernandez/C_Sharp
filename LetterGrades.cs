// Fig. 6.9: LetterGrades.cs
// Using a switch statement to count letter grades.
using System;

class LetterGrades
{
    static void Main(string[] args)
    {
        int total = 0; // Sum of grades
        int gradeCounter = 0; // Number of grades entered
        int aCount = 0; // Count of A grades
        int bCount = 0; // Count of B grades
        int cCount = 0; // Count of C grades
        int dCount = 0; // Count of D grades
        int fCount = 0; // Count of F grades

        Console.WriteLine("Enter the integer grades in the range of 0-100.");
        Console.WriteLine("Type <Ctrl> z and press Enter to terminate input:");

        string input = Console.ReadLine(); // Read user input

        // Loop unitl user enters the end-of-file indicator (<Ctrl> z)
        while (input != null)
        {
            int grade = int.Parse(input); // Read grade from user's input
            total += grade; // Add grade to total
            ++gradeCounter; // Increment number of grades

            // Determine which grade was entered
            switch (grade / 10)
            {
                case 9: // Grade was in the 90's
                case 10: // Grade was 100
                    ++aCount; // Increment aCount
                    break; // Exit switch
                case 8: // Grade was between 80-89
                    ++bCount; // Increment bCount
                    break; // Exit switch
                case 7: // Grade was between 70-79
                    ++cCount; // Increment cCount
                    break; // Exit switch
                case 6: // Grade was betwwwn 60-69
                    ++dCount; // Increment dCount
                    break; // Exit switch
                default: // Grade was less than 60
                    ++fCount; // Increment fCount
                    break; // Exit switch
            }

            input = Console.ReadLine(); // Read user input
        }

        Console.WriteLine("\nGrade Report:");

        // If user entered at least one grade...
        if (gradeCounter != 0)
        {
            // Calculate average of all grades entered
            double average = (double)total / gradeCounter;

            // Output summery of results
            Console.WriteLine($"Total of the {gradeCounter} grades entered is {total}");
            Console.WriteLine($"Class average is {average:F}");
            Console.WriteLine("Number of students who received each grade:");
            Console.WriteLine($"A: {aCount}"); //Display number of A grades
            Console.WriteLine($"B: {bCount}"); //Display number of B grades
            Console.WriteLine($"C: {cCount}"); //Display number of C grades
            Console.WriteLine($"D: {dCount}"); //Display number of D grades
            Console.WriteLine($"F: {fCount}"); //Display number of F grades
        }
        else // No grades were entered, so output appropriate message
        {
            Console.WriteLine("No grades were entered");
        }
    }
// thanks for looking
}
