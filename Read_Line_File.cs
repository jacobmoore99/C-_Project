using System;
using System.IO;
using System.Threading.Tasks;

namespace C__Project
{
    class Read_Line_File
    {
        static void Eleventh()
    {
        int counter = 0;  
        string line;  
        System.Console.WriteLine("\n");
        // Read the file and display it line by line.  
        System.IO.StreamReader file =
            new System.IO.StreamReader(@"TextFileTest1.txt");  
        while((line = file.ReadLine()) != null)  
        {  
            System.Console.WriteLine(line);  
            counter++;  
        }  
          
        file.Close();  
        System.Console.WriteLine("There were {0} lines in this text file.", counter);  
        // Suspend the screen.  
        System.Console.ReadLine();  
    }
    }
}