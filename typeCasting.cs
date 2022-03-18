using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = converting a value to a different data type
            //                           useful when we accept user input (string)
            //                           different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            Char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(a.GetType()); //display the data type of whatever 'a' is 
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());

            Console.ReadKey();
        }
    }
}
