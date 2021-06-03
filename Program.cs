using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Program
    {
        static void Main()
    {
        
        string text = System.IO.File.ReadAllText(@"TextFileTest1.txt");
        System.Console.WriteLine("\nContents of TextFileTest1.txt : {0}", "\n\n" + text);
    }
    }
}
