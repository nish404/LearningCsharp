using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Nish Code";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Ms.);
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4, 4);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            
            Console.ReadKey();
        }
    }
}
