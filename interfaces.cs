using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow
            //                     an interface declares "what a class should have"
            //                     an inheriting class defines "how it should do it"
            //                     benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();

        }
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit: IPrey
        {
            public void Flee()
            {
                Console.WriteLine("the rabbit runs away");
            }
        }
        class Hawk: IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("the hawk is searching for food");
            }
        }
        class Fish: IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("this dish swims away");
            }
            public void Hunt()
            {
                Console.WriteLine("this fish is searching for a smaller fish");
            }
        }
    }
}
