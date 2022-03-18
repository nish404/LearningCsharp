using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement = a basic form of decision making 

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            
            if (name != "")
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your name");
            }
            
            Console.ReadKey();
        }
    }
}
