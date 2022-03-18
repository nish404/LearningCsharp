using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked"
            //          benefit = let's us resuse code w/o writing it multiple times
            //          good practice is to capitalize method names

            String name = "Bro";
            int age = 21;

            SingHappyBirthday(name, age);

            Console.ReadKey();
        }

        static void SingHappyBirthday(String myBirthday, int yearsOld)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear" + myBirthday);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}
