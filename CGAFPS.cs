// Ex. 7.28: Converting Grade Averages to a Four-Point Scale (CGAFPS.cs)
/* Write a method "QualityPoints" that inputs the student's average
 * and returns GPA within a Four-Point Scaling system*/
using System;

class CGAFPS
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the integer grade in the range of 0-100.");
		int grade = int.Parse(Console.ReadLine()); // Read user input

		int point = QualityPoints(grade);
		Console.WriteLine("\nFour-Point Scale:\n4 - 90-100"
			+ "\n3 - 80-89\n2 - 70-79\n1 - 60-69\n0 - less than 60");
		Console.WriteLine($"\nStudent's grade within the Four-Point Scale is: {point}\n");
	}

	public static int QualityPoints(int grade)
	{
		int average = 0;

		if (grade >= 90)
		{
			average = 4; // Display A grade
		}
		else if (grade >= 80 && grade <= 89)
		{
			average = 3; // Display B grade
		}
		else if (grade >= 70 && grade <= 79)
		{
			average = 2; //Display C grade
		}
		else if (grade >= 60 && grade <= 69)
		{
			average = 1; //Display D grade
		}
		else if (grade < 60)
		{
			average = 0; //Display F grade
		}

		return average;
	}
// thanks for looking
}
