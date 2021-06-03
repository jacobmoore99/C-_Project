using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Read_File
    {
        static void Eighth()
    {
        
        string text = System.IO.File.ReadAllText(@"TextFileTest1.txt");
        System.Console.WriteLine("\nContents of TextFileTest1.txt : {0}", "\n\n" + text);
    }
    }
}