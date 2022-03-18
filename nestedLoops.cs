using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loops = loops inside of other loops
            //                uses vary; used a lot in sorting algorithms

            Console.Write("how many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("how many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("what symbol?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
