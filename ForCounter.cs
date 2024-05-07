// Fig. 6.2: ForCounter.cs
// Counter-controlled iteration with the for iteration statement
using System;


class Program
{
  static void Main()
  {
        // for statement header includes initialization
        // loop-continuation condition and increment
        for (int counter = 1; counter <= 10; ++counter)
        {
            Console.Write($"{ counter} ");
        }

        Console.WriteLine();
    }
// Thanks for looking
}
