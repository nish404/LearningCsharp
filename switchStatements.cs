using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch statement = an efficient alternative to many else if statements 

            Console.WriteLine("What day is today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thrusday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
