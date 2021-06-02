using System;

namespace C__Project
{
    class String_Input
    {
        static void First(string[] args)
        {
            string greeting = "Hello everyone";
            Console.WriteLine(greeting);
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What's up, " + name );

        }
    }
}
