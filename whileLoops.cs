using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            String name = "";

            while (name == "")
            {
	     // Console.Write = print data without printing the new line
	     // Console.WriteLine = printing the data with a new line
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
