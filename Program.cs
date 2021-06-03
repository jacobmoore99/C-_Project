using System;

namespace C__Project
{
    class Program
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
      July,        // 7
      August,
      September,
      October,
      November,
      December
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter number from 1-12.");
      string mnum;
      mnum = Console.ReadLine();
      var int1 = int.Parse(mnum);
      var output = (Months)int1;
      Console.WriteLine(output);
    }
    }
}