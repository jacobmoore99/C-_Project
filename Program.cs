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
            Console.WriteLine("Enter first number.");
            string num1;
            num1 = Console.ReadLine();
            Console.WriteLine("Good. What is your second number?");
            string num2;
            num2 = Console.ReadLine();
            Console.WriteLine("Good. Performing calculation...");
            var int1 = int.Parse(num1);
            var int2 = int.Parse(num2);
            int num3;
            num3 = int1 + int2;
            Console.WriteLine(int1.ToString() + "+" + int2.ToString() + "=" + num3.ToString());

        }
    }
}
