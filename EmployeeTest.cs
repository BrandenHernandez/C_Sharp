// EmployeeTest.cs
// Creating and manipulating an Employee object
// VeryAble 9-22-2017
using System;

class EmployeeTest
{
    static void Main()
    {
        // First employee ------------------------------------------------------------------------------------------------------
        // Prompt for, then read, input
        Console.Write($"\nEnter employee's first name: ");
           string FirstName1 = Console.ReadLine();

        // Prompt for, then read, input
        Console.Write($"\nEnter employee's last name: ");
            string LastName1 = Console.ReadLine();

        // Prompt for, then read, input
        Console.Write($"\nEnter employee's monthly salary: ");
        decimal InitialSalary1 = decimal.Parse(Console.ReadLine());

        // Second employee ------------------------------------------------------------------------------------------------------
        // Prompt for, then read, input
        Console.Write($"\nEnter employee's first name: ");
        string FirstName2 = Console.ReadLine();

        // Prompt for, then read, input
        Console.Write($"\nEnter employee's last name: ");
        string LastName2 = Console.ReadLine();

        // Prompt for, then read, input
        Console.Write($"\nEnter employee's monthly salary: ");
        decimal InitialSalary2 = decimal.Parse(Console.ReadLine());

        // Create an account object and assign it to an account  -----------------------------------------------------------------
        Employee account1 = new Employee(FirstName1, LastName1, InitialSalary1);
        Employee account2 = new Employee(FirstName2, LastName2, InitialSalary2);

        // Display the initial balance of each object ----------------------------------------------------------------------------
        Console.WriteLine(
            $"\n{account1.Name}'s annual salary: {account1.Salary:C}");
        Console.WriteLine(
            $"{account2.Name}'s annual salary: {account2.Salary:C}");

        // Prompt for, then read, input ------------------------------------------------------------------------------------------
        Console.Write($"\nEnter raise amount for {account1.Name} (percentage): ");
        decimal raiseAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {raiseAmount:F}% to {account1.Name}'s salary...\n");
        account1.Raise(raiseAmount); // Add to account1's salary

        // Display account1 salary -----------------------------------------------------------------------------------------------
        Console.WriteLine(
            $"{account1.Name}'s salary is now: {account1.Salary:C}");


        // Prompt for, then read, input ------------------------------------------------------------------------------------------
        Console.Write($"\nEnter raise amount for {account2.Name} (percentage): ");
        raiseAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {raiseAmount:F}% to {account2.Name}'s salary...\n");
        account2.Raise(raiseAmount); // Add to account2's salary

        // Display account2 salary -----------------------------------------------------------------------------------------------
        Console.WriteLine(
            $"{account2.Name}'s salary is now: {account2.Salary:C}");

    }
    // Thanks for looking
}
