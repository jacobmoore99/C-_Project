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

    enum Days
    {
      None,
      Monday,    // 1
      Tuesday,   // 2
      Wednesday,      // 3
      Thursday,      // 4
      Friday,        // 5
      Saturday,       // 6
      Sunday       // 7
      
    }
    static void Main(string[] args)
    {
      Random rnd = new Random();
      int day  = rnd.Next(1, 8);  // creates a number between 1 and 12
      int month   = rnd.Next(1, 13);   // creates a number between 1 and 6
      int date   = rnd.Next(1, 32);     // creates a number between 0 and 51

      Console.WriteLine("\nYour numerical calendar date is: " + day.ToString() + ", " + month.ToString() + " " + date.ToString());
      Console.WriteLine("Use this program to perform a conversion.");
      
      Console.WriteLine("\nEnter the first number from 1-7.");
      string dnum;
      dnum = Console.ReadLine();
      var intd = int.Parse(dnum);

      Console.WriteLine("\nEnter the first number from 1-12.");
      string mnum;
      mnum = Console.ReadLine();
      var intm = int.Parse(mnum);

      Console.WriteLine("\nEnter the first number from 1-31.");
      string tnum;
      tnum = Console.ReadLine();

      var doutput = (Days)intd;
      var moutput = (Months)intm;
      Console.WriteLine("\nThe date is: " + doutput + ", " + moutput + " " + tnum + ".\n");
    }
    }
}