// Indirect Base Class 2-2-2018
using System; 

namespace Athena
{
    class English
    {
        // Members -------------------------------------------------------------------------------------
        public static string you = null; // First member
        public static string me = null;  // Second member
        public static string temp = null;// Third member

        /* virtual auto-implemented property. Overrides can only
        ** provide specialized behavior if they implement get and set accessors.
        */

        public virtual string Name { get; set; } // Marked "virtual" to be overriden in a derived class

// Hear ------------------------------------------------------------------------------------------------
        public virtual string Hear(string you) // Virtual to run on normal bases or change for specialization
        {
            // User input
            Console.Write("\n~~~> ");
            you = Console.ReadLine();

            return you;
        }

// Think -----------------------------------------------------------------------------------------------
        public virtual string Think(string you, string temp, string me) // Virtual for Chat class to override
        {
            return " This is a test. ";
        }

// Talk ------------------------------------------------------------------------------------------------
        public static void Speak(string me)
        {
            // Response
            Console.WriteLine($"\n---> {me}");

            Console.WriteLine("\n"); // New line before end
        }
    }
// Thanks for looking
}
