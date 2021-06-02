using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Program
    {
        public static async Task Main()
    {
        using StreamWriter file = new("TextFileTest1.txt", append: true);
        await file.WriteLineAsync("\nNew Line.");
    }
    }
}
