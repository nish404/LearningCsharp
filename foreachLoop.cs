using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
