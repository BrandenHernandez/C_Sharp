/* Test class for Inheritence 2-2-2018
*  ^ In Visual Studio create a project called "Inheritance Test." 
*  ^ Think about inheritance. Come up with a "base class." 
*  ^ Create a base class with at least 3 public members and at least 3 public methods. Declare some of the methods as "virtual." 
*  ^ In your comments tell me why we are using the keyword "virtual." 
*  ^ Your methods do not have to return anything, they can just write information out to the console.
*  ^ Now create 2 derived classes that extend the base class. 
*  ^ Override the virtual methods and add at least 1 public method and 1 public member to the derived classes.
*  ^ In the Main method create an instance of each derived class. 
*  ^ Prompt the user for the values of every member in the base and derived classes. 
*  ^ Initialize the members with the values the user enters. 
*  ^ Display all of the info for each object including the members and methods from the base and derived classes.
*/using System;

namespace Athena
    {
        class Inheritance_Test : Chat //: English
        {
            static void Main(string[] args)
            {
                // Constructors for instances of each base
                Chat chat = new Chat();
                English english = new English();

                Console.WriteLine(" \t\t\t\t\tAthena Cyberbot - Orbis Labs ");

                while (me != $"Goodbye {name}")
                {
                    // Input
                    you = chat.Hear(you); // Propt "you" to speak

                    // Process
                    me = chat.Think(you, temp, me); // Think about what "you" said

                    // Respond
                    Speak(me); // Say after Thinking
                }
            }
        }
// Thanks for looking
    }
