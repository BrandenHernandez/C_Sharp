// Base class 2-2-2018
// Ideally Athena will take what you say, search through a database as to what to respond with, and return that.
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Athena
{
    class Chat : English
    {
        // Constructor
        Weather weather = new Athena.Weather();

        // Variable
        protected static string name;
        public string zipcode;

        public override string Hear(string you) // Overriden to add welcome message in-case of initial contact
        {
            if (you == null)
            {
                you = "Start"; // Welcome message
            }
            else
            {
                // User input
                Console.Write("\n~~~> ");
                you = Console.ReadLine();
            }
            return you;
        }

        // Think about what what was said
        public override string Think(string you, string temp, string me) // Override for specialization
        {
            // Think Testing
            //if (you == "Hello" || you == "Goodbye")
            //{
            //    me = you + ", " + name; // Output
            //}
            //else if (you != "Hello" || you != "Goodbye")
            //{
            //    me = null;
            //    // Defualt
            //    if (me == null)
            //    {
            //        me = "I don't know what to say.";
            //    }
            //}

// Think -----------------------------------------------------------------------------------------------
            switch (you) // Based on what "you" say
            {
                case "Start":
                    me = "Welcome! To begin, say \"Hello\". For help say \"Help\"";
                    break;
// Hello -----------------------------------------------------------------------------------------------
                case "Hello": // "you" say
                    Console.WriteLine("\n---> Hello, what is your first name?\n"); // "me" say
                    Console.Write("\n~~~> "); // Promt "you"
                    name = Console.ReadLine(); // your response
                    me = $"Nice to meet you {name}"; // "me" say
                    break;
                // Help
                case "Help": // "you" say
                    Console.WriteLine("\n---> You can say:"); // "me" say
                    me = "Hello, What is your name?, What is the weather like?, You too, and Goodbye.";
                    break;
                // Thank you -------------------------------------------------------------------------------------------
                case "Thank you": // "you" say
                    me = $"You are welcome {name}."; // "me" say
                    break;
// My Name ---------------------------------------------------------------------------------------------
                case "What is your name?": // "you" say
                    me = "My name is Athena"; // "me" say
                    break;
// Goodbye ---------------------------------------------------------------------------------------------
                case "Goodbye": // "you" say
                    me = you + " " + name; // "me" say
                    break;
// Weather ---------------------------------------------------------------------------------------------
                case "What is the weather like?": // "you" say
                    English.Speak("What is your zipcode?"); // "me" say
                    Console.Write("\n~~~> "); // Promt "you"
                    zipcode = Console.ReadLine(); // your response
                    me = "Sorry, I am having difficulties connecting to the Internet."; // "me" say
                    // Action
                    Weather(zipcode); // Get current weather based on zipcode
                    break;
// You Too ---------------------------------------------------------------------------------------------
                case "You too":
                    me = "How is your day going?";
                    break;
// Default ---------------------------------------------------------------------------------------------
                default:
                    me = "Can you repeat that?"; // "me" say
                    break;
            }
            // Return statement
            return me;
        }

        /* Override auto-implemented property with ordinary property
        ** to provide specialized accessor behavior.
        */
        public override string Name
        {
            get // getter
            {
                return name;
            }
            set // setter
            {
                if (value != null) // Validation
                {
                    name = value;
                }
                else // Default
                {
                    name = "Unknown user";
                }
            }
        }

        public void Weather(string zipcode)
        {
            // Used a depreciated link from Google's weather API
            // Deleted everything once realized the fault was solely in the API link
        }
    }
// thanks for looking
}
