// Fig. 5.9: ClassAverage.cs
// Solving the class-average problem using counter-controlled iteration

using System;


class ClassAverage
{
    static void Main()
    {
        // initialize phase
        int total = 0; // initialize sum of grades entered by the user
        int gradeCounter = 1; // initialize grade # to be entered next

        // processing phase uses counter-controlled iteration
        while (gradeCounter <= 10) // loop 10 times
        {
            Console.Write("Enter grade: "); // prompt
            int grade = int.Parse(Console.ReadLine()); // input grade
            total = total + grade; // add the grade to the total
            gradeCounter = gradeCounter + 1; // increment the counter by 1
        }

        // terminate phase
        int average = total / 10; // integer division yeilds integer result

        // display total and average of grades
        Console.WriteLine($"\nTotal of all 10 grades is {total}");
        Console.WriteLine($"Class average is {average}");
    }
 }
