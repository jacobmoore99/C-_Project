using System;

namespace C__Project
{
    class If_Else_Statement
    {
        static void Fourth(string[] args)
        {
            string greeting = "Hello everyone";
            Console.WriteLine(greeting);
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What's up, " + name );
            string answer;
            Console.WriteLine("Want to see what I can do, " + name + "?");
            answer = Console.ReadLine();
            Console.WriteLine(answer + "? Ok. You will enter 2 numbers and I will check to see if they are equal.");
            Console.WriteLine("Enter first number.");
            string num1;
            num1 = Console.ReadLine();
            Console.WriteLine("Good. What is your second number?");
            string num2;
            num2 = Console.ReadLine();
            Console.WriteLine("Good. Performing calculation...");
            var int1 = int.Parse(num1);
            var int2 = int.Parse(num2);
            if (int1 == int2) {
            Console.WriteLine("Yes, the values are equal.");
            }
            else {
            Console.WriteLine("Sadly, the values are not equal.");
            }

        }
    }
}
