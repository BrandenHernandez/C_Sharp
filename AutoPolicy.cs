// Fig. 6.11: AutoPolicy.cs
// Class that represents an auto insurance policy.
using System;

class AutoPolicy
{
    public int AccountNumber { get; set; } // Policy account number
    public string MakeAndModel { get; set; } // Vehicle that policy applies to
    public string State { get; set; } // Two-letter state abbreviation

    // Constructor
    public AutoPolicy(int accountNumber, string makeAndModel, string state)
    {
        AccountNumber = accountNumber;
        MakeAndModel = makeAndModel;
        State = state;
    }

    // Return whther the state has no-fault insurance
    public bool IsNoFaultState
    {
        get
        {
            bool noFaultState;

            // Determine whether state has no-fault auto insurance
            switch (State) // Get AutoPolicy object's state abbreviation
            {
                case "MA": case "NJ": case "NY": case "PA": // One of 4 applicable states
                    noFaultState = true; // Yes
                    break; // Exit switch
                default: // For all other states
                    noFaultState = false; // No
                    break; // Exit switch
            }

            return noFaultState;
        }
    }
// Thanks for looking
}
