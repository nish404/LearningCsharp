using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
 
            //Accepting two inputs from the user
            Console.Write("Enter first number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number\t");
            num2 = Convert.ToInt32(Console.ReadLine());
 
            //Processing comparison
            //Check whether num1 is greater than or not
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            //Check whether num2 is greater than or not
            else if (num2 > num1)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            Console.ReadLine();
        }
    }
}
