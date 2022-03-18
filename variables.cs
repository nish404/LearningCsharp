using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initialization

            int y = 321; //declaration + initialization

            int age = 21; //whole integer
            double height = 300.5; //decimal number
            bool human = false; //true or false
            char symbol = '$'; //only assigns a single character
            string name = "Nish";

            Console.WriteLine("you age is "+age);
            Console.WriteLine("your height is "+height+" cm");
            Console.WriteLine("are you a robot? "+human);
            Console.WriteLine("your symbol is: "+symbol);
            Console.WriteLine("hello "+name);

            string userName = symbol + name;
            Console.WriteLine("your username is: "+userName);

            Console.ReadKey();
        }
    }
}
