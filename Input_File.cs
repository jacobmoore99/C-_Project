using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Input_File
    {
        public static async Task Seventh()
    {
        string input;
        Console.WriteLine("Please enter what you want added to the file.");
        input = Console.ReadLine();
        Console.WriteLine("Inputting now...");
        using StreamWriter file = new("TextFileTest1.txt", append: true);
        await file.WriteLineAsync("\n" + input);
    }
    }
}
