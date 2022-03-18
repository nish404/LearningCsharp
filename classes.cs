using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = a bundle of related code
            //         can be used as a blueprint to create objects (OOP)

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("hello, welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("i am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("bye, thanks for visiting");
        }
    }
}
