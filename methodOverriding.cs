using System;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            //                     inherited method must be: abstract, virtual, or already overriden
            //                     used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();

        }
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("the animal makes too much noise");
            }
        }
        class Dog: Animal
        {
            public override void Speak()
            {
                Console.WriteLine("the dog barks");
            }
        }
        class Cat: Animal
        {

        }
    }
}
