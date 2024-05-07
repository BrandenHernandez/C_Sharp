// Player class for getters and setters of player's name

using System;
using System.Globalization;

namespace CrapsGame
{
    class Player
    {
        private string NameFirst { get; set; } // Instance variable
        private string NameLast { get; set; } // Instance variable
        public string Name { get; private set; } // Instance variable
        private string firstName; // Instance variable
        private string lastName; // Instance variable

        // Account constructor that receives two parameters
        public Player(string firstName, string lastName)
        {

            this.firstName = Capitalise(firstName);
            this.lastName = Capitalise(lastName);
            Name = this.firstName + " " + this.lastName;
            
        }

        // Capitalize first character of each name
        public string Capitalise(string str)
        {
            if (String.IsNullOrEmpty(str)) // If left blank
                return String.Empty; // Catch fault
            return Char.ToUpper(str[0]) + str.Substring(1).ToLower(); // Capitalize first character
        }

        // Name property
        public string FirstName
        {
            get
            {
                return NameFirst;
            }

            private set // Can only be used within the class
            {
                NameFirst = value;
            }
        }

        public string LastName
        {
            get
            {
                return NameLast;
            }

            private set // Can only be used within the class
            {
                NameLast = value;
            }
        }
    }
    // Thanks for looking
}
