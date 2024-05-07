// 4.13 Removing duplicate code in method main (RDCM)
// Takes Account and removes some duplicate codes for displaying
// VeryAble 11-22-2017

using System;

 class RDCM
{ 
    public string Name { get; set; } // Auto-implemented properties
    private decimal balance; // Instance variable

    // Account constructor that receives two parameters
    public RDCM(string accountName, decimal initialBalance)
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
            balance = value;
        }
    }

    // Method that deposites (adds) only a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        // Validate that the balance is greater than 0.0;
        /* If it's not, instance variable balance keeps its 
         * prior value */

        if (depositAmount > 0.0m) // if the deposit amount is valid
        {
            Balance = Balance + depositAmount; // Add it to the balance
        }
    }
    // Thanks for looking
}  
