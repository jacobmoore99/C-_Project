using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Journal
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
    public static async Task Final()
    {
      Console.WriteLine("You will enter today's date.");
      
      Console.WriteLine("\nEnter the day number of the week. Monday is 1 and Sunday is 7.");
      string dnum;
      dnum = Console.ReadLine();
      var intd = int.Parse(dnum);

      Console.WriteLine("\nEnter the month number. January is 1 and December is 12.");
      string mnum;
      mnum = Console.ReadLine();
      var intm = int.Parse(mnum);

      Console.WriteLine("\nEnter the date number. 1st is 1 and 31st is 31.");
      string tnum;
      tnum = Console.ReadLine();

      var doutput = (Days)intd;
      var moutput = (Months)intm;
      var calendar = ("\nEntry Date - " + doutput + ", " + moutput + " " + tnum + ":\n");
      string input;
      Console.WriteLine("\nDate recorded. Please write journal entry.");

      input = Console.ReadLine();
      Console.WriteLine("Inputting now...");
      using StreamWriter file = new("Journal.txt", append: true);
      await file.WriteLineAsync(calendar + input);
      
      string entry;
      Console.WriteLine("\nEnter 1 if you want to see the contents of the journal. If not, enter 0.");
      entry = Console.ReadLine();
      var ent = int.Parse(entry);

        if (ent == 1) {
            string contents = System.IO.File.ReadAllText(@"Journal.txt");
            System.Console.WriteLine("\nContents of journal: {0}", "\n\n" + contents + calendar + input + "\n");
            }
            else {
            Console.WriteLine("\nEnding program.");
            }
    }
    }
}