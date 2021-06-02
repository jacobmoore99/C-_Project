using System;

namespace C__Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello everyone";
            Console.WriteLine(greeting);
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What's up, " + name );
            string answer;
            Console.WriteLine("Want to see a cool math problem " + name + "?");
            answer = Console.ReadLine();
            Console.WriteLine(answer + "? Ok.");
            int num1 = 12;
            int num2 = 14;
            int num3;

            num3 = num1 + num2;

            Console.WriteLine(num3);

        }
    }
}
