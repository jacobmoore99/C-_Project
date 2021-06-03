using System;

namespace C__Project
{
    class First_Enum
    {
      enum Months
    {
      None,
      January,    // 1
      February,   // 2
      March,      // 3
      April,      // 4
      May,        // 5
      June,       // 6
      July        // 7
    }
    static void Ninth(string[] args)
    {
      string choice;
      Console.WriteLine("Enter a month.");
      choice = Console.ReadLine();
      Console.WriteLine("Calculating...");
      int myNum = (int) Months.May;
      Console.WriteLine(myNum);
    }
    }
}