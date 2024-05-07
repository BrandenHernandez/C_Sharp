// Fig. 6.1: WhileCounter.cs
// Counter-controlled iteration with the while iteration statement.

using System;

class WhileCounter
{
  static void Main()
  {
    int counter = 1; // declare and initialize control variable
    
    while (counter <= 10) // loop-continuation condition
    {
      Console.Write($"{counter}  ");
      ++counter; // increment control variable
    }
    
    Console.WriteLine();
  }
  // Thanks for looking
}
