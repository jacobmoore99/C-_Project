using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Access_File
    {
        public static async Task Thirteenth()
    {
        string input;
        Console.WriteLine("Please enter what you want added to the file.");
        input = Console.ReadLine();
        Console.WriteLine("Inputting now...");
        using StreamWriter file = new("TextFileTest1.txt", append: true);
        await file.WriteLineAsync("\n" + input);

        string entry;
        Console.WriteLine("\nEnter 1 if you want to see the contents of the file. If not, enter 0.");
        entry = Console.ReadLine();
        var ent1 = int.Parse(entry);

        if (ent1 == 1) {
            string contents = System.IO.File.ReadAllText(@"TextFileTest1.txt");
            System.Console.WriteLine("\nContents of file : {0}", "\n\n" + contents + "\n" + input);
            }
            else {
            Console.WriteLine("\nEnding program.");
            }
    }
    }
}
