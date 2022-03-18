using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators = can be used to check if more than 1 condition is true/false
            // && (AND)
            // || (OR)

            Console.WriteLine("What's the temperature outside: (F)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 50 && temp <= 77)
            {
                Console.WriteLine("It's warm outside");
            }
            else if (temp <= -58 || temp >= 122)
            {
                Console.WriteLine("DO NOT GO OUTSIDE");
            }

            Console.ReadKey();
        }
    }
}
