// 4.13 Removing duplicate code in method main (RDCMTest)
// Takes Account and removes some duplicate codes for displaying
// VeryAble 11-22-2017

using System;

class RDCMTest
{
    static void Main()
    {
        // Create an account object and assign it to myAccount
        RDCM account1 = new RDCM("Jane Green", 50.00m);
        RDCM account2 = new RDCM("John Blue", -7.53m);

        // Display 1
        DisplayAccount(account1);

        //Display 2
        DisplayAccount(account2);

        // Prompt for, then read, input
        Console.Write($"\nEnter deposit amount for {account1.Name}: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {depositAmount:C} to {account1.Name}'s balance\n");
        account1.Deposit(depositAmount); // Add to account1's balance

        // Display 1
        DisplayAccount(account1);

        //Display 2
        DisplayAccount(account2);

        // Prompt for, then read, input
        Console.Write($"\nEnter deposite amount for {account2.Name}: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine(
            $"adding {depositAmount:C} to {account2.Name}'s balance\n");
        account2.Deposit(depositAmount); // Add to account2's balance

        // Display 1
        DisplayAccount(account1);

        //Display 2
        DisplayAccount(account2);

    }

    // Display method
    static void DisplayAccount(RDCM accountToDisplay)
    {
        Console.WriteLine(
           $"{accountToDisplay.Name}'s balance: {accountToDisplay.Balance:C}");
    }
    // Thanks for looking
}
