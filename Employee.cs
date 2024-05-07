using System;


// Employee.cs
/* Employee class with a salary and a raise method */
// VeryAble 9-22-2017 

class Employee
{
    public string firstName { get; set; } // Instance variable
    public string lastName { get; set; } // Instance variable
    public string Name { get; private set; } // Instance variable
    private decimal salary; // Instance variable

    // Account constructor that receives three parameters
    public Employee(string firstName, string lastName, decimal initialSalary)
    {
        Name = firstName + " " + lastName;
        salary = initialSalary * 12; // Salary's set accessor validates
    }

    // Name property
    public string FirstName
    {
        get
        {
            return firstName;
        }

        private set // Can only be used within the class
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }

        private set // Can only be used within the class
        {
            lastName = value;
        }
    }

    // Monthly salary turned yearly salary property with validation 
    public decimal Salary
    {
        get
        {
            return salary;
        }

        private set // Can be used only within the class
        {
            // Validate that the salary is greater than 0.0;
            /* If it's not, instance variable salary keeps its 
             * prior value */
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            {
                salary = value;
            }
        }
    }

    // Method that raises only a valid amount to the salary
    public void Raise(decimal raiseAmount)
    {
        if (raiseAmount > 0.0m) // if the raise amount is valid
        {
            Salary = (Salary * raiseAmount / 100) + Salary; // Add percentage to the salary
        }
    }
    // Thanks for looking
}
