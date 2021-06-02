using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Append_File
    {
        public static async Task Sixth()
    {
        using StreamWriter file = new("TextFileTest1.txt", append: true);
        await file.WriteLineAsync("\nNew Line.");
    }
    }
}
