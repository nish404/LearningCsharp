using System;
using System.Collections.Generic;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index
            //        similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            Console.WriteLine(food[0]);
            Console.WriteLine(food[0]);
            Console.WriteLine(food[0]);
            Console.WriteLine(food[0]);

            //food.Remove("fries");
            //food.Insert(0, "Sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
