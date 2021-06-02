using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Program
    {
        public static async Task Main()
    {
        string text =
            "This is a test, " +
            "hopefully it works. ";

        await File.WriteAllTextAsync("TextFileTest1.txt", text);
        Console.WriteLine("File writing: Completed.");
    }
    }
}
