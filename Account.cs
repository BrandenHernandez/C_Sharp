using System;


// Account.cs
/* Account class with a balnce and a deposit method */
// VeryAble 9-22-2017

class Account
{
    public string Name { get; set; } // Auto-implemented properties
    private decimal balance; // Instance variable

    // Account constructor that receives two parameters
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        balance = initialBalance; // Balance's set accessor validates
    }

    // Balance property with validation
    public decimal Balance
    {
        get
        {
            return balance;
        }

        private set // Can be used only within the class
        {
            // Validate that the balance is greater than 0.0;
            /* If it's not, instance variable balance keeps its 
             * prior value */
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            {
                balance = value;
            }
        }
    }

    // Method that deposites (adds) only a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the deposit amount is valid
        {
            Balance = Balance + depositAmount; // Add it to the balance
        }
    }
    // Thanks for looking
}
